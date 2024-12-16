using HeinHtetNaing_ADI.Common.DTOs;
using HeinHtetNaing_ADI.Models;
using Microsoft.Data.SqlClient;

namespace HeinHtetNaing_ADI.Services
{
    public class ClientService
    {
        private readonly DatabaseService _databaseService;

        public ClientService()
        {
            _databaseService = new DatabaseService();
        }

        public void AddClient(Client client)
        {
            try
            {
                using var connection = _databaseService.GetConnection();
                var query = "INSERT INTO client (client_id, first_name, last_name, email, password_hash, address, phone_no, image) " +
                            "VALUES (@ClientId, @FirstName, @LastName, @Email, @PasswordHash, @Address, @PhoneNo, @Image)";
                using var command = new SqlCommand(query, connection);

                MapParameters(command, client);

                connection.Open();
                command.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                Console.WriteLine($"SQL Error: {ex.Message}");
                throw;
            }
        }

        public Client? GetClientById(long clientId)
        {
            try
            {
                using var connection = _databaseService.GetConnection();
                var query = "SELECT * FROM client WHERE client_id = @ClientId";
                using var command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@ClientId", clientId);

                connection.Open();
                using var reader = command.ExecuteReader();
                return reader.Read() ? MapReaderToClient(reader) : null;
            }
            catch (SqlException ex)
            {
                Console.WriteLine($"SQL Error: {ex.Message}");
                throw;
            }
        }

        public Client? FindClientByEmail(string email)
        {
            try
            {
                using var connection = _databaseService.GetConnection();
                var query = "SELECT * FROM client WHERE email = @Email";
                using var command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Email", email);

                connection.Open();
                using var reader = command.ExecuteReader();
                return reader.Read() ? MapReaderToClient(reader) : null;
            }
            catch (SqlException ex)
            {
                Console.WriteLine($"SQL Error: {ex.Message}");
                throw;
            }
        }

        public IEnumerable<Client> GetAllClients()
        {
            try
            {
                using var connection = _databaseService.GetConnection();
                var query = "SELECT * FROM client";
                using var command = new SqlCommand(query, connection);

                connection.Open();
                using var reader = command.ExecuteReader();

                var clients = new List<Client>();
                while (reader.Read())
                {
                    clients.Add(MapReaderToClient(reader));
                }
                return clients;
            }
            catch (SqlException ex)
            {
                Console.WriteLine($"SQL Error: {ex.Message}");
                throw;
            }
        }

        public void UpdateClient(Client client)
        {
            try
            {
                using var connection = _databaseService.GetConnection();
                var query = "UPDATE client SET first_name = @FirstName, last_name = @LastName, email = @Email, " +
                            "password_hash = @PasswordHash, address = @Address, phone_no = @PhoneNo, image = @Image " +
                            "WHERE client_id = @ClientId";
                using var command = new SqlCommand(query, connection);

                MapParameters(command, client);

                connection.Open();
                command.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                Console.WriteLine($"SQL Error: {ex.Message}");
                throw;
            }
        }

        public void DeleteClient(long clientId)
        {
            try
            {
                using var connection = _databaseService.GetConnection();
                var query = "DELETE FROM client WHERE client_id = @ClientId";
                using var command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@ClientId", clientId);

                connection.Open();
                command.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                Console.WriteLine($"SQL Error: {ex.Message}");
                throw;
            }
        }

        public PagedResult<Client> GetPagedClient(int pageNumber, int pageSize)
        {
            try
            {
                using var connection = _databaseService.GetConnection();

                // Calculate the offset for pagination
                int offset = (pageNumber - 1) * pageSize;

                // Query to get paginated clients
                var query = "SELECT * FROM client ORDER BY client_id OFFSET @Offset ROWS FETCH NEXT @PageSize ROWS ONLY";

                using var command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Offset", offset);
                command.Parameters.AddWithValue("@PageSize", pageSize);

                connection.Open();
                using var reader = command.ExecuteReader();

                // Read all clients in one go
                var clients = new List<Client>();
                while (reader.Read())
                {
                    clients.Add(MapReaderToClient(reader));
                }

                // Query to get total count of clients
                var countQuery = "SELECT COUNT(*) FROM client";
                using var countCommand = new SqlCommand(countQuery, connection);
                var totalCount = Convert.ToInt32(countCommand.ExecuteScalar());

                // Return paginated result
                return new PagedResult<Client>(clients, totalCount, offset, pageSize);
            }
            catch (SqlException ex)
            {
                Console.WriteLine($"SQL Error: {ex.Message}");
                throw;
            }
        }

        private static void MapParameters(SqlCommand command, Client client)
        {
            command.Parameters.AddWithValue("@ClientId", client.ClientId);
            command.Parameters.AddWithValue("@FirstName", client.FirstName ?? (object)DBNull.Value);
            command.Parameters.AddWithValue("@LastName", client.LastName ?? (object)DBNull.Value);
            command.Parameters.AddWithValue("@Email", client.Email ?? (object)DBNull.Value);
            command.Parameters.AddWithValue("@PasswordHash", client.PasswordHash ?? (object)DBNull.Value);
            command.Parameters.AddWithValue("@Address", client.Address ?? (object)DBNull.Value);
            command.Parameters.AddWithValue("@PhoneNo", client.PhoneNo ?? (object)DBNull.Value);
            command.Parameters.AddWithValue("@Image", client.Image ?? (object)DBNull.Value);
        }

        private static Client MapReaderToClient(SqlDataReader reader)
        {
            return new Client
            {
                ClientId = reader.GetInt64(reader.GetOrdinal("client_id")),
                FirstName = reader["first_name"] as string,
                LastName = reader["last_name"] as string,
                Email = reader["email"] as string,
                PasswordHash = reader["password_hash"] as string,
                Address = reader["address"] as string,
                PhoneNo = reader["phone_no"] as string,
                Image = reader["image"] as string
            };
        }
    }
}
