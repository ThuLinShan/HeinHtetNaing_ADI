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
                return reader.Read() ? MapReaderToFreelancer(reader) : null;
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
                return reader.Read() ? MapReaderToFreelancer(reader) : null;
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
                var query = "SELECT * FROM freelancer";
                using var command = new SqlCommand(query, connection);

                connection.Open();
                using var reader = command.ExecuteReader();

                var freelancers = new List<Freelancer>();
                while (reader.Read())
                {
                    freelancers.Add(MapReaderToFreelancer(reader));
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

                var freelancers = new List<Freelancer>();
                while (reader.Read())
                {
                    freelancers.Add(MapReaderToFreelancer(reader));
                }

                // Query to get total count of freelancers
                var countQuery = "SELECT COUNT(*) FROM freelancer";
                using var countCommand = new SqlCommand(countQuery, connection);
                var totalCount = Convert.ToInt32(countCommand.ExecuteScalar());

                return new PagedResult<Freelancer>(freelancers, totalCount, offset, pageSize);
            }
            catch (SqlException ex)
            {
                Console.WriteLine($"SQL Error: {ex.Message}");
                throw;
            }
        }

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
                Rating = reader["rating"] as decimal?
            };
        }
    }

}
