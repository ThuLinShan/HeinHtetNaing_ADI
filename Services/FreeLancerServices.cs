using HeinHtetNaing_ADI.Common.DTOs;
using HeinHtetNaing_ADI.Models;
using Microsoft.Data.SqlClient;
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
                    // Insert freelancer into the freelancer table
                    var freelancerQuery = "INSERT INTO freelancer (freelancer_id, first_name, last_name, email, password_hash, address, phone_no, best_project, website_link, image, rating) " +
                                          "VALUES (@FreelancerId, @FirstName, @LastName, @Email, @PasswordHash, @Address, @PhoneNo, @BestProject, @WebsiteLink, @Image, @Rating)";
                    using (var freelancerCommand = new SqlCommand(freelancerQuery, connection, transaction))
                    {
                        MapParameters(freelancerCommand, freelancer);
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

                        using var skillCommand = new SqlCommand(skillQuery.ToString(), connection, transaction);

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
            catch (SqlException ex)
            {
                Console.WriteLine($"SQL Error: {ex.Message}");
                throw;
            }
        }

        public Freelancer? GetFreelancerById(long freelancerId)
        {
            try
            {
                using var connection = _databaseService.GetConnection();
                var query = "SELECT * FROM freelancer WHERE freelancer_id = @FreelancerId";
                using var command = new SqlCommand(query, connection);
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
            catch (SqlException ex)
            {
                Console.WriteLine($"SQL Error: {ex.Message}");
                throw;
            }
        }

        public Freelancer? FindFreelancerByEmail(string email)
        {
            try
            {
                using var connection = _databaseService.GetConnection();
                var query = "SELECT * FROM freelancer WHERE email = @Email";
                using var command = new SqlCommand(query, connection);
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
            catch (SqlException ex)
            {
                Console.WriteLine($"SQL Error: {ex.Message}");
                throw;
            }
        }


        public IEnumerable<Freelancer> GetAllFreelancers()
        {
            try
            {
                using var connection = _databaseService.GetConnection();

                // Step 1: Retrieve all freelancers
                var freelancersQuery = "SELECT * FROM freelancer";
                using var command = new SqlCommand(freelancersQuery, connection);

                connection.Open();
                using var reader = command.ExecuteReader();

                var freelancers = new List<Freelancer>();
                var freelancerIds = new List<long>();

                while (reader.Read())
                {
                    var freelancer = MapReaderToFreelancer(reader);
                    freelancers.Add(freelancer);
                    freelancerIds.Add(freelancer.FreelancerId);
                }

                // If no freelancers exist, return an empty list
                if (!freelancers.Any())
                {
                    return freelancers;
                }

                // Step 2: Fetch all skills in a single query for the collected freelancer IDs
                var skills = GetSkillsByFreelancerIds(freelancerIds, connection);

                // Step 3: Map skills to their respective freelancers
                foreach (var freelancer in freelancers)
                {
                    freelancer.Skills = skills.ContainsKey(freelancer.FreelancerId)
                        ? skills[freelancer.FreelancerId]
                        : new List<Skill>();
                }

                return freelancers;
            }
            catch (SqlException ex)
            {
                Console.WriteLine($"SQL Error: {ex.Message}");
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
                    // Step 1: Update freelancer details (same as your current code)
                    var query = "UPDATE freelancer SET first_name = @FirstName, last_name = @LastName, email = @Email, " +
                                "password_hash = @PasswordHash, address = @Address, phone_no = @PhoneNo, best_project = @BestProject, " +
                                "website_link = @WebsiteLink, image = @Image, rating = @Rating WHERE freelancer_id = @FreelancerId";
                    using var command = new SqlCommand(query, connection, transaction);

                    MapParameters(command, freelancer);
                    command.ExecuteNonQuery();

                    // Step 2: Get the existing skills from the database for this freelancer
                    var existingSkills = GetExistingSkills(freelancer.FreelancerId, connection, transaction);

                    // Step 3: Compare existing skills with the new skills and process accordingly
                    ProcessSkillsBatch(freelancer.Skills, existingSkills, freelancer.FreelancerId, connection, transaction);

                    // Commit the transaction after all operations are successful
                    transaction.Commit();
                }
                catch (Exception ex)
                {
                    // Rollback the transaction in case of any error
                    transaction.Rollback();
                    throw new Exception($"Error updating freelancer and skills: {ex.Message}", ex);
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine($"SQL Error: {ex.Message}");
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
                    using (var deleteSkillsCommand = new SqlCommand(deleteSkillsQuery, connection, transaction))
                    {
                        deleteSkillsCommand.Parameters.AddWithValue("@FreelancerId", freelancerId);
                        deleteSkillsCommand.ExecuteNonQuery();
                    }

                    // Delete the freelancer
                    var deleteFreelancerQuery = "DELETE FROM freelancer WHERE freelancer_id = @FreelancerId";
                    using (var deleteFreelancerCommand = new SqlCommand(deleteFreelancerQuery, connection, transaction))
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
            catch (SqlException ex)
            {
                Console.WriteLine($"SQL Error: {ex.Message}");
                throw;
            }
        }


        public PagedResult<Freelancer> GetPagedFreelancer(int pageNumber, int pageSize)
        {
            try
            {
                using var connection = _databaseService.GetConnection();

                // Calculate the offset for pagination
                int offset = (pageNumber - 1) * pageSize;

                // Query to get paginated freelancers
                var query = "SELECT * FROM freelancer ORDER BY freelancer_id OFFSET @Offset ROWS FETCH NEXT @PageSize ROWS ONLY";

                using var command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Offset", offset);
                command.Parameters.AddWithValue("@PageSize", pageSize);

                connection.Open();
                using var reader = command.ExecuteReader();

                // Read all freelancers in one go
                var freelancers = new List<Freelancer>();
                while (reader.Read())
                {
                    freelancers.Add(MapReaderToFreelancer(reader));
                }

                // Query to get total count of freelancers
                var countQuery = "SELECT COUNT(*) FROM freelancer";
                using var countCommand = new SqlCommand(countQuery, connection);
                var totalCount = Convert.ToInt32(countCommand.ExecuteScalar());

                // Return paginated result
                return new PagedResult<Freelancer>(freelancers, totalCount, offset, pageSize);
            }
            catch (SqlException ex)
            {
                Console.WriteLine($"SQL Error: {ex.Message}");
                throw;
            }
        }
        #endregion


        #region skill

        private List<Skill> GetExistingSkills(long freelancerId, SqlConnection connection, SqlTransaction transaction)
        {
            var query = "SELECT skill_id, skill_name, skill_level FROM skill WHERE freelancer_id = @FreelancerId";
            using var command = new SqlCommand(query, connection, transaction);
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

        private void ProcessSkillsBatch(List<Skill> newSkills, List<Skill> existingSkills, long freelancerId, SqlConnection connection, SqlTransaction transaction)
        {
            // Step 1: Delete removed skills (skills that are in existingSkills but not in newSkills)
            var removedSkills = existingSkills.Where(existingSkill => !newSkills.Any(newSkill => newSkill.SkillId == existingSkill.SkillId)).ToList();
            if (removedSkills.Any())
            {
                var deleteQuery = "DELETE FROM skill WHERE skill_id IN (";
                var parameters = new List<string>();

                // Add individual parameters for each skill_id
                using var deleteCommand = new SqlCommand(deleteQuery, connection, transaction);

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

                    using var updateCommand = new SqlCommand(updateQuery, connection, transaction);

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

                using var insertCommand = new SqlCommand(insertQuery, connection, transaction);
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
                using var connection = _databaseService.GetConnection();
                var query = "INSERT INTO skill (freelancer_id, skill_name, skill_level) " +
                            "VALUES (@FreelancerId, @SkillName, @SkillLevel)";
                using var command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@FreelancerId", freelancerId);
                command.Parameters.AddWithValue("@SkillName", skill.SkillName ?? (object)DBNull.Value);
                command.Parameters.AddWithValue("@SkillLevel", skill.SkillLevel ?? (object)DBNull.Value);

                connection.Open();
                command.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                Console.WriteLine($"SQL Error: {ex.Message}");
                throw;
            }
        }

        public void UpdateSkill(Skill skill)
        {
            try
            {
                using var connection = _databaseService.GetConnection();
                var query = "UPDATE skill SET skill_name = @SkillName, skill_level = @SkillLevel " +
                            "WHERE skill_id = @SkillId";
                using var command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@SkillId", skill.SkillId);
                command.Parameters.AddWithValue("@SkillName", skill.SkillName ?? (object)DBNull.Value);
                command.Parameters.AddWithValue("@SkillLevel", skill.SkillLevel ?? (object)DBNull.Value);

                connection.Open();
                command.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                Console.WriteLine($"SQL Error: {ex.Message}");
                throw;
            }
        }

        private List<Skill> GetSkillsByFreelancerId(long freelancerId, SqlConnection connection)
        {
            var skills = new List<Skill>();

            try
            {
                var query = "SELECT * FROM skill WHERE freelancer_id = @FreelancerId";
                using var command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@FreelancerId", freelancerId);

                using var reader = command.ExecuteReader();
                while (reader.Read())
                {
                    var skill = MapReaderToSkill(reader);
                    skills.Add(skill);
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine($"SQL Error when fetching skills: {ex.Message}");
                throw;
            }

            return skills;
        }

        private Dictionary<long, List<Skill>> GetSkillsByFreelancerIds(IEnumerable<long> freelancerIds, SqlConnection connection)
        {
            // If no freelancer IDs are provided, return an empty dictionary
            if (!freelancerIds.Any())
            {
                return new Dictionary<long, List<Skill>>();
            }

            // Prepare a comma-separated list of freelancer IDs for the SQL query
            var idList = string.Join(",", freelancerIds);

            // Query to fetch all skills for the given freelancer IDs
            var query = $"SELECT * FROM skill WHERE freelancer_id IN ({idList})";
            using var command = new SqlCommand(query, connection);

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
        private static void MapParameters(SqlCommand command, Freelancer freelancer)
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
        }

        private static Skill MapReaderToSkill(SqlDataReader reader)
        {
            return new Skill
            {
                SkillId = reader.GetInt64(reader.GetOrdinal("skill_id")),
                FreelancerId = reader["freelancer_id"] as long?,
                SkillName = reader["skill_name"] as string,
                SkillLevel = reader["skill_level"] as string
            };
        }

        private static Freelancer MapReaderToFreelancer(SqlDataReader reader)
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
                Skills = new List<Skill>() // Initialize as an empty list by default
            };
        }
        #endregion
    }
}
