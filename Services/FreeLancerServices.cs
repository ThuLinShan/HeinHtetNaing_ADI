using HeinHtetNaing_ADI.Common.DTOs;
using HeinHtetNaing_ADI.Models;
using MySql.Data.MySqlClient;
using System.Text;

namespace HeinHtetNaing_ADI.Services
{
    public class FreelancerService
    {
        private readonly DatabaseService _databaseService;

        public FreelancerService()
        {
            _databaseService = new DatabaseService();
        }

        #region freelancer
        public void AddFreelancer(Freelancer freelancer)
        {
            try
            {
                using var connection = _databaseService.GetConnection();
                connection.Open();

                // Start a transaction to ensure data consistency
                using var transaction = connection.BeginTransaction();

                try
                {
                    // Insert freelancer into the freelancer table, including the expertise field
                    var freelancerQuery = "INSERT INTO freelancer (freelancer_id, first_name, last_name, email, password_hash, address, phone_no, best_project, website_link, image, rating, expertise) " +
                                          "VALUES (@FreelancerId, @FirstName, @LastName, @Email, @PasswordHash, @Address, @PhoneNo, @BestProject, @WebsiteLink, @Image, @Rating, @Expertise)";
                    using (var freelancerCommand = new MySqlCommand(freelancerQuery, connection, transaction))
                    {
                        MapParameters(freelancerCommand, freelancer);  // Make sure this method maps the new field too
                        freelancerCommand.ExecuteNonQuery();
                    }

                    // Insert skills into the skill table
                    if (freelancer.Skills != null && freelancer.Skills.Count > 0)
                    {
                        var skillQuery = new StringBuilder("INSERT INTO skill (skill_id, freelancer_id, skill_name, skill_level) VALUES ");

                        // Build a single SQL statement with multiple rows
                        for (int i = 0; i < freelancer.Skills.Count; i++)
                        {
                            var skill = freelancer.Skills[i];
                            skillQuery.Append($"(@SkillId{i}, @FreelancerId{i}, @SkillName{i}, @SkillLevel{i})");
                            if (i < freelancer.Skills.Count - 1)
                            {
                                skillQuery.Append(", ");
                            }
                        }

                        using var skillCommand = new MySqlCommand(skillQuery.ToString(), connection, transaction);

                        // Add parameters for each skill
                        for (int i = 0; i < freelancer.Skills.Count; i++)
                        {
                            var skill = freelancer.Skills[i];
                            skillCommand.Parameters.AddWithValue($"@SkillId{i}", skill.SkillId);
                            skillCommand.Parameters.AddWithValue($"@FreelancerId{i}", freelancer.FreelancerId);
                            skillCommand.Parameters.AddWithValue($"@SkillName{i}", skill.SkillName ?? (object)DBNull.Value);
                            skillCommand.Parameters.AddWithValue($"@SkillLevel{i}", skill.SkillLevel ?? (object)DBNull.Value);
                        }

                        // Execute the batch insert
                        skillCommand.ExecuteNonQuery();
                    }

                    // Commit the transaction
                    transaction.Commit();
                }
                catch (Exception)
                {
                    // Rollback the transaction in case of an error
                    transaction.Rollback();
                    throw;
                }
            }
            catch (MySqlException ex)
            {
                Console.WriteLine($"MySQL Error: {ex.Message}");
                throw;
            }
        }

        public Freelancer? GetFreelancerById(long freelancerId)
        {
            try
            {
                using var connection = _databaseService.GetConnection();
                var query = "SELECT * FROM freelancer WHERE freelancer_id = @FreelancerId";
                using var command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@FreelancerId", freelancerId);

                connection.Open();
                using var reader = command.ExecuteReader();

                if (reader.Read())
                {
                    var freelancer = MapReaderToFreelancer(reader);
                    reader.Close();
                    freelancer.Skills = GetSkillsByFreelancerId(freelancerId, connection);
                    return freelancer;
                }
                return null;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine($"MySQL Error: {ex.Message}");
                throw;
            }
        }
        #endregion
        public Freelancer? FindFreelancerByEmail(string email)
        {
            try
            {
                using var connection = _databaseService.GetConnection();
                var query = "SELECT * FROM freelancer WHERE email = @Email";
                using var command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@Email", email);

                connection.Open();
                using var reader = command.ExecuteReader();

                if (reader.Read())
                {
                    var freelancer = MapReaderToFreelancer(reader);

                    // Close the reader before calling another command
                    reader.Close();

                    freelancer.Skills = GetSkillsByFreelancerId(freelancer.FreelancerId, connection);
                    return freelancer;
                }
                return null;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine($"MySQL Error: {ex.Message}");
                throw;
            }
        }

        public IEnumerable<Freelancer> BrowseFreelancers(string keyword)
        {
            try
            {
                using var connection = _databaseService.GetConnection();

                // Step 1: Define query to fetch freelancers matching the keyword
                var query = @"
        SELECT f.freelancer_id, f.first_name, f.last_name, f.email, f.password_hash, 
               f.address, f.phone_no, f.best_project, f.website_link, f.image, f.rating, f.expertise
        FROM freelancer f
        LEFT JOIN skill s ON f.freelancer_id = s.freelancer_id
        WHERE (@Keyword IS NULL OR s.skill_name LIKE @Keyword OR f.expertise LIKE @Keyword)";

                using var command = new MySqlCommand(query, connection);

                // Add keyword parameter
                if (!string.IsNullOrEmpty(keyword))
                {
                    command.Parameters.AddWithValue("@Keyword", $"%{keyword}%");
                }
                else
                {
                    command.Parameters.AddWithValue("@Keyword", DBNull.Value);
                }

                connection.Open();
                using var reader = command.ExecuteReader();

                // Step 2: Create a dictionary to hold freelancer details and their skills
                var freelancers = new Dictionary<long, Freelancer>();

                while (reader.Read())
                {
                    var freelancerId = reader.GetInt64(reader.GetOrdinal("freelancer_id"));

                    // If freelancer is already in the dictionary, skip adding them again
                    if (!freelancers.ContainsKey(freelancerId))
                    {
                        var freelancer = MapReaderToFreelancer(reader);
                        freelancers[freelancerId] = freelancer;
                    }
                }

                // Step 3: Fetch skills for the freelancers
                var freelancerIds = freelancers.Keys.ToList();
                reader.Close();
                var skills = GetSkillsByFreelancerIds(freelancerIds, connection);

                // Step 4: Map skills to their respective freelancers
                foreach (var freelancer in freelancers.Values)
                {
                    freelancer.Skills = skills.ContainsKey(freelancer.FreelancerId)
                        ? skills[freelancer.FreelancerId]
                        : new List<Skill>();
                }

                return freelancers.Values;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine($"MySQL Error: {ex.Message}");
                throw;
            }
        }


        public void UpdateFreelancer(Freelancer freelancer)
        {
            try
            {
                using var connection = _databaseService.GetConnection();
                connection.Open();
                var transaction = connection.BeginTransaction(); // Start transaction for atomic operation

                try
                {
                    // Step 1: Update freelancer details
                    var query = "UPDATE freelancer SET first_name = @FirstName, last_name = @LastName, email = @Email, " +
                                "password_hash = @PasswordHash, address = @Address, phone_no = @PhoneNo, best_project = @BestProject, " +
                                "website_link = @WebsiteLink, image = @Image, rating = @Rating WHERE freelancer_id = @FreelancerId";
                    using var command = new MySqlCommand(query, connection, transaction);

                    MapParameters(command, freelancer);
                    command.ExecuteNonQuery();

                    // Step 2: Get the existing skills from the database for this freelancer
                    var existingSkills = GetExistingSkills(freelancer.FreelancerId, connection, transaction);

                    // Step 3: Compare existing skills with the new skills and process accordingly
                    ProcessSkillsBatch(freelancer.Skills, existingSkills, freelancer.FreelancerId, connection, transaction);

                    // Step 4: Update `freelancer_name` in the `Bids` table
                    var updateBidsQuery = "UPDATE bids " +
                                           "SET freelancer_name = @FreelancerName " +
                                           "WHERE freelancer_id = @FreelancerId";

                    using var updateCommand = new MySqlCommand(updateBidsQuery, connection, transaction);
                    updateCommand.Parameters.AddWithValue("@FreelancerName", $"{freelancer.FirstName} {freelancer.LastName}");
                    updateCommand.Parameters.AddWithValue("@FreelancerId", freelancer.FreelancerId);
                    updateCommand.ExecuteNonQuery();

                    // Commit the transaction after all operations are successful
                    transaction.Commit();
                }
                catch (Exception ex)
                {
                    // Rollback the transaction in case of any error
                    transaction.Rollback();
                    throw new Exception($"Error updating freelancer and related records: {ex.Message}", ex);
                }
            }
            catch (MySqlException ex)
            {
                Console.WriteLine($"MySQL Error: {ex.Message}");
                throw;
            }
        }

        public void DeleteFreelancer(long freelancerId)
        {
            try
            {
                using var connection = _databaseService.GetConnection();
                connection.Open();

                using var transaction = connection.BeginTransaction();
                try
                {
                    // Delete skills associated with the freelancer
                    var deleteSkillsQuery = "DELETE FROM skill WHERE freelancer_id = @FreelancerId";
                    using (var deleteSkillsCommand = new MySqlCommand(deleteSkillsQuery, connection, transaction))
                    {
                        deleteSkillsCommand.Parameters.AddWithValue("@FreelancerId", freelancerId);
                        deleteSkillsCommand.ExecuteNonQuery();
                    }

                    // Delete the freelancer
                    var deleteFreelancerQuery = "DELETE FROM freelancer WHERE freelancer_id = @FreelancerId";
                    using (var deleteFreelancerCommand = new MySqlCommand(deleteFreelancerQuery, connection, transaction))
                    {
                        deleteFreelancerCommand.Parameters.AddWithValue("@FreelancerId", freelancerId);
                        deleteFreelancerCommand.ExecuteNonQuery();
                    }

                    // Commit transaction
                    transaction.Commit();
                }
                catch
                {
                    // Rollback transaction in case of an error
                    transaction.Rollback();
                    throw;
                }
            }
            catch (MySqlException ex)
            {
                Console.WriteLine($"MySQL Error: {ex.Message}");
                throw;
            }
        }

        #region skill

        private List<Skill> GetExistingSkills(long freelancerId, MySqlConnection connection, MySqlTransaction transaction)
        {
            var query = "SELECT skill_id, skill_name, skill_level FROM skill WHERE freelancer_id = @FreelancerId";
            using var command = new MySqlCommand(query, connection, transaction);
            command.Parameters.AddWithValue("@FreelancerId", freelancerId);

            using var reader = command.ExecuteReader();
            var existingSkills = new List<Skill>();

            while (reader.Read())
            {
                existingSkills.Add(new Skill
                {
                    SkillId = reader.GetInt64(0),
                    SkillName = reader.GetString(1),
                    SkillLevel = reader.GetString(2)
                });
            }

            return existingSkills;
        }


        private void ProcessSkillsBatch(List<Skill> newSkills, List<Skill> existingSkills, long freelancerId, MySqlConnection connection, MySqlTransaction transaction)
        {
            // Step 1: Delete removed skills (skills that are in existingSkills but not in newSkills)
            var removedSkills = existingSkills.Where(existingSkill => !newSkills.Any(newSkill => newSkill.SkillId == existingSkill.SkillId)).ToList();
            if (removedSkills.Any())
            {
                var deleteQuery = "DELETE FROM skill WHERE skill_id IN (";
                var parameters = new List<string>();

                // Add individual parameters for each skill_id
                using var deleteCommand = new MySqlCommand(deleteQuery, connection, transaction);

                for (int i = 0; i < removedSkills.Count; i++)
                {
                    parameters.Add($"@SkillId_{i}");
                    deleteCommand.Parameters.AddWithValue($"@SkillId_{i}", removedSkills[i].SkillId);
                }

                // Concatenate the parameters to form the query
                deleteQuery += string.Join(", ", parameters) + ")";

                deleteCommand.CommandText = deleteQuery;
                deleteCommand.Parameters.AddWithValue("@FreelancerId", freelancerId);

                // Execute the query
                deleteCommand.ExecuteNonQuery();
            }

            // Step 2: Update existing skills (those that have changed)
            var updatedSkills = newSkills.Where(newSkill => existingSkills.Any(existingSkill => existingSkill.SkillId == newSkill.SkillId &&
                                                                                                         (existingSkill.SkillLevel != newSkill.SkillLevel ||
                                                                                                          existingSkill.SkillName != newSkill.SkillName))).ToList();
            if (updatedSkills.Any())
            {
                // Loop through each updated skill and execute an individual UPDATE query
                foreach (var updatedSkill in updatedSkills)
                {
                    var updateQuery = @"
                                    UPDATE skill
                                    SET skill_name = @SkillName, skill_level = @SkillLevel
                                    WHERE freelancer_id = @FreelancerId AND skill_id = @SkillId";

                    using var updateCommand = new MySqlCommand(updateQuery, connection, transaction);

                    // Add parameters for the current updated skill
                    updateCommand.Parameters.AddWithValue("@FreelancerId", freelancerId);
                    updateCommand.Parameters.AddWithValue("@SkillId", updatedSkill.SkillId);
                    updateCommand.Parameters.AddWithValue("@SkillName", updatedSkill.SkillName ?? string.Empty);  // Default to empty string if null
                    updateCommand.Parameters.AddWithValue("@SkillLevel", updatedSkill.SkillLevel ?? string.Empty);  // Default to empty string if null

                    // Execute the update command
                    updateCommand.ExecuteNonQuery();
                }
            }

            // Step 3: Add new skills (those that are in newSkills but not in existingSkills)
            var newSkillsToAdd = newSkills.Where(newSkill => !existingSkills.Any(existingSkill => existingSkill.SkillId == newSkill.SkillId)).ToList();
            if (newSkillsToAdd.Any())
            {
                var insertQuery = @"
                            INSERT INTO skill (freelancer_id, skill_id, skill_name, skill_level)
                            VALUES " +
                                    string.Join(", ", newSkillsToAdd.Select(skill => $"(@FreelancerId, @SkillId_{skill.SkillId}, @SkillName_{skill.SkillId}, @SkillLevel_{skill.SkillId})"));

                using var insertCommand = new MySqlCommand(insertQuery, connection, transaction);
                insertCommand.Parameters.AddWithValue("@FreelancerId", freelancerId);

                // Add parameters for each new skill
                foreach (var newSkill in newSkillsToAdd)
                {
                    insertCommand.Parameters.AddWithValue($"@SkillId_{newSkill.SkillId}", newSkill.SkillId);  // Add SkillId parameter
                    insertCommand.Parameters.AddWithValue($"@SkillName_{newSkill.SkillId}", newSkill.SkillName);
                    insertCommand.Parameters.AddWithValue($"@SkillLevel_{newSkill.SkillId}", newSkill.SkillLevel);
                }

                insertCommand.ExecuteNonQuery();
            }
        }

        public void AddSkillToFreelancer(long freelancerId, Skill skill)
        {
            try
            {
                using var connection = _databaseService.GetConnection();  // Assuming GetMySqlConnection is adapted for MySQL
                var query = "INSERT INTO skill (freelancer_id, skill_name, skill_level) " +
                            "VALUES (@FreelancerId, @SkillName, @SkillLevel)";
                using var command = new MySqlCommand(query, connection);

                command.Parameters.AddWithValue("@FreelancerId", freelancerId);
                command.Parameters.AddWithValue("@SkillName", skill.SkillName ?? (object)DBNull.Value);
                command.Parameters.AddWithValue("@SkillLevel", skill.SkillLevel ?? (object)DBNull.Value);

                connection.Open();
                command.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                Console.WriteLine($"MySQL Error: {ex.Message}");
                throw;
            }
        }

        public void UpdateSkill(Skill skill)
        {
            try
            {
                using var connection = _databaseService.GetConnection();  // Assuming GetMySqlConnection is adapted for MySQL
                var query = "UPDATE skill SET skill_name = @SkillName, skill_level = @SkillLevel " +
                            "WHERE skill_id = @SkillId";
                using var command = new MySqlCommand(query, connection);

                // Handle potential null or empty strings explicitly before adding them to parameters
                command.Parameters.AddWithValue("@SkillId", skill.SkillId);
                command.Parameters.AddWithValue("@SkillName", string.IsNullOrEmpty(skill.SkillName) ? (object)DBNull.Value : skill.SkillName);
                command.Parameters.AddWithValue("@SkillLevel", string.IsNullOrEmpty(skill.SkillLevel) ? (object)DBNull.Value : skill.SkillLevel);

                connection.Open();
                command.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                Console.WriteLine($"MySQL Error: {ex.Message}");
                throw;
            }
        }



        private List<Skill> GetSkillsByFreelancerId(long freelancerId, MySqlConnection connection)
        {
            var skills = new List<Skill>();

            try
            {
                var query = "SELECT * FROM skill WHERE freelancer_id = @FreelancerId";
                using var command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@FreelancerId", freelancerId);

                using var reader = command.ExecuteReader();
                while (reader.Read())
                {
                    var skill = MapReaderToSkill(reader);
                    skills.Add(skill);
                }
            }
            catch (MySqlException ex)
            {
                Console.WriteLine($"MySQL Error when fetching skills: {ex.Message}");
                throw;
            }

            return skills;
        }

        private Dictionary<long, List<Skill>> GetSkillsByFreelancerIds(IEnumerable<long> freelancerIds, MySqlConnection connection)
        {
            // If no freelancer IDs are provided, return an empty dictionary
            if (!freelancerIds.Any())
            {
                return new Dictionary<long, List<Skill>>();
            }

            // Create the parameterized query for multiple freelancer IDs
            var query = "SELECT * FROM skill WHERE freelancer_id IN (" +
                        string.Join(", ", freelancerIds.Select((id, index) => $"@FreelancerId{index}")) + ")";

            using var command = new MySqlCommand(query, connection);

            // Add parameters for each freelancerId
            for (int i = 0; i < freelancerIds.Count(); i++)
            {
                command.Parameters.AddWithValue($"@FreelancerId{i}", freelancerIds.ElementAt(i));
            }

            using var reader = command.ExecuteReader();

            // Group skills by freelancer_id
            var skillsByFreelancerId = new Dictionary<long, List<Skill>>();
            while (reader.Read())
            {
                var skill = MapReaderToSkill(reader);
                var freelancerId = reader.GetInt64(reader.GetOrdinal("freelancer_id"));

                if (!skillsByFreelancerId.ContainsKey(freelancerId))
                {
                    skillsByFreelancerId[freelancerId] = new List<Skill>();
                }
                skillsByFreelancerId[freelancerId].Add(skill);
            }

            return skillsByFreelancerId;
        }

        #endregion

        #region Helpers
        private static void MapParameters(MySqlCommand command, Freelancer freelancer)
        {
            command.Parameters.AddWithValue("@FreelancerId", freelancer.FreelancerId);
            command.Parameters.AddWithValue("@FirstName", freelancer.FirstName ?? (object)DBNull.Value);
            command.Parameters.AddWithValue("@LastName", freelancer.LastName ?? (object)DBNull.Value);
            command.Parameters.AddWithValue("@Email", freelancer.Email ?? (object)DBNull.Value);
            command.Parameters.AddWithValue("@PasswordHash", freelancer.PasswordHash ?? (object)DBNull.Value);
            command.Parameters.AddWithValue("@Address", freelancer.Address ?? (object)DBNull.Value);
            command.Parameters.AddWithValue("@PhoneNo", freelancer.PhoneNo ?? (object)DBNull.Value);
            command.Parameters.AddWithValue("@BestProject", freelancer.BestProject ?? (object)DBNull.Value);
            command.Parameters.AddWithValue("@WebsiteLink", freelancer.WebsiteLink ?? (object)DBNull.Value);
            command.Parameters.AddWithValue("@Image", freelancer.Image ?? (object)DBNull.Value);
            command.Parameters.AddWithValue("@Rating", freelancer.Rating ?? (object)DBNull.Value);
            command.Parameters.AddWithValue("@Expertise", freelancer.Expertise ?? (object)DBNull.Value); // Map expertise field
        }

        private static Skill MapReaderToSkill(MySqlDataReader reader)
        {
            return new Skill
            {
                SkillId = reader.GetInt64(reader.GetOrdinal("skill_id")),
                FreelancerId = reader["freelancer_id"] as long?,
                SkillName = reader["skill_name"] as string,
                SkillLevel = reader["skill_level"] as string
            };
        }

        private static Freelancer MapReaderToFreelancer(MySqlDataReader reader)
        {
            return new Freelancer
            {
                FreelancerId = reader.GetInt64(reader.GetOrdinal("freelancer_id")),
                FirstName = reader["first_name"] as string,
                LastName = reader["last_name"] as string,
                Email = reader["email"] as string,
                PasswordHash = reader["password_hash"] as string,
                Address = reader["address"] as string,
                PhoneNo = reader["phone_no"] as string,
                BestProject = reader["best_project"] as long?,
                WebsiteLink = reader["website_link"] as string,
                Image = reader["image"] as string,
                Rating = reader["rating"] as decimal?,
                Expertise = reader["expertise"] as string, // Add this line to map the expertise field
                Skills = new List<Skill>() // Initialize as an empty list by default
            };
        }
        #endregion
    }
}
