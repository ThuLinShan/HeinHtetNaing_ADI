using HeinHtetNaing_ADI.Common.DTOs;
using HeinHtetNaing_ADI.Models;
using Microsoft.Data.SqlClient;

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
                var query = "INSERT INTO freelancer (freelancer_id, first_name, last_name, email, password_hash, address, phone_no, best_project, website_link, image, rating) " +
                            "VALUES (@FreelancerId, @FirstName, @LastName, @Email, @PasswordHash, @Address, @PhoneNo, @BestProject, @WebsiteLink, @Image, @Rating)";
                using var command = new SqlCommand(query, connection);

                MapParameters(command, freelancer);

                connection.Open();
                command.ExecuteNonQuery();
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
                var query = "UPDATE freelancer SET first_name = @FirstName, last_name = @LastName, email = @Email, " +
                            "password_hash = @PasswordHash, address = @Address, phone_no = @PhoneNo, best_project = @BestProject, " +
                            "website_link = @WebsiteLink, image = @Image, rating = @Rating WHERE freelancer_id = @FreelancerId";
                using var command = new SqlCommand(query, connection);

                MapParameters(command, freelancer);

                connection.Open();
                command.ExecuteNonQuery();
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
                var query = "DELETE FROM freelancer WHERE freelancer_id = @FreelancerId";
                using var command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@FreelancerId", freelancerId);

                connection.Open();
                command.ExecuteNonQuery();
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
        public void AddSkillToFreelancer(long freelancerId, Skill skill)
        {
            try
            {
                using var connection = _databaseService.GetConnection();
                var query = "INSERT INTO skills (freelancer_id, skill_name, skill_level) " +
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
                var query = "UPDATE skills SET skill_name = @SkillName, skill_level = @SkillLevel " +
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
                var query = "SELECT * FROM skills WHERE freelancer_id = @FreelancerId";
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
            var query = $"SELECT * FROM skills WHERE freelancer_id IN ({idList})";
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
