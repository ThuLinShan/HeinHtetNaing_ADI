using HeinHtetNaing_ADI.Models;
using Microsoft.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace HeinHtetNaing_ADI.Services
{
    public class BidService
    {
        private readonly DatabaseService _databaseService;

        public BidService()
        {
            _databaseService = new DatabaseService();
        }
        public void AddBid(Bid bid)
        {
            try
            {
                using var connection = _databaseService.GetConnection();

                // Check if the same bid already exists
                var checkQuery = "SELECT COUNT(*) FROM bids WHERE project_id = @ProjectId AND freelancer_id = @FreelancerId";
                using var checkCommand = new MySqlCommand(checkQuery, connection); // Use MySqlCommand for MySQL
                checkCommand.Parameters.AddWithValue("@ProjectId", bid.ProjectId);
                checkCommand.Parameters.AddWithValue("@FreelancerId", bid.FreelancerId);

                connection.Open();
                var existingBidCount = Convert.ToInt32(checkCommand.ExecuteScalar());

                if (existingBidCount > 0)
                {
                    throw new InvalidOperationException("A bid with the same project ID and freelancer ID already exists.");
                }

                // Insert the new bid
                var insertQuery = "INSERT INTO bids (bid_id, project_id, freelancer_id, rate, rate_type, status, comment, created_at, freelancer_name) " +
                                  "VALUES (@BidId, @ProjectId, @FreelancerId, @Rate, @RateType, @Status, @Comment, @CreatedAt, @FreelancerName)";
                using var insertCommand = new MySqlCommand(insertQuery, connection); // Use MySqlCommand for MySQL

                MapParameters(insertCommand, bid);

                insertCommand.ExecuteNonQuery();
            }
            catch (MySqlException ex) // Use MySqlException for MySQL
            {
                Console.WriteLine($"SQL Error: {ex.Message}");
                throw;
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine($"Validation Error: {ex.Message}");
                throw;
            }
        }

        public void AcceptBid(Bid bid)
        {
            try
            {
                using var connection = _databaseService.GetConnection();
                connection.Open();

                // Begin a transaction to ensure atomicity
                using var transaction = connection.BeginTransaction();

                try
                {
                    // Update the selected bid to "SUCCESS"
                    var successQuery = @"
                                UPDATE bids 
                                SET status = 'SUCCESS' 
                                WHERE bid_id = @BidId";
                    using (var successCommand = new MySqlCommand(successQuery, connection, transaction))
                    {
                        successCommand.Parameters.AddWithValue("@BidId", bid.BidId);
                        successCommand.ExecuteNonQuery();
                    }

                    // Update all other bids in the same project to "FAIL"
                    var failQuery = "UPDATE bids SET status = 'FAIL' WHERE project_id = @ProjectId AND bid_id != @BidId";
                    using (var failCommand = new MySqlCommand(failQuery, connection, transaction))
                    {
                        failCommand.Parameters.AddWithValue("@ProjectId", bid.ProjectId);
                        failCommand.Parameters.AddWithValue("@BidId", bid.BidId);
                        failCommand.ExecuteNonQuery();
                    }

                    // Update the project table to set the status to "OnGoing" and add freelancer details
                    var updateProjectQuery = @"
                                    UPDATE project
                                    SET 
                                        status = 'OnGoing', 
                                        freelancer_id = @FreelancerId
                                    WHERE project_id = @ProjectId";
                    using (var updateProjectCommand = new MySqlCommand(updateProjectQuery, connection, transaction))
                    {
                        updateProjectCommand.Parameters.AddWithValue("@FreelancerId", bid.FreelancerId);
                        updateProjectCommand.Parameters.AddWithValue("@ProjectId", bid.ProjectId);
                        updateProjectCommand.ExecuteNonQuery();
                    }

                    // Commit the transaction
                    transaction.Commit();
                }
                catch
                {
                    // Rollback transaction if anything goes wrong
                    transaction.Rollback();
                    throw;
                }
            }
            catch (MySqlException ex) // Use MySqlException for MySQL
            {
                Console.WriteLine($"SQL Error: {ex.Message}");
                throw;
            }
        }

        public Bid? GetBidById(long bidId)
        {
            try
            {
                using var connection = _databaseService.GetConnection();
                var query = "SELECT * FROM bids WHERE bid_id = @BidId";
                using var command = new MySqlCommand(query, connection); // Changed to MySqlCommand
                command.Parameters.AddWithValue("@BidId", bidId);

                connection.Open();
                using var reader = command.ExecuteReader();
                return reader.Read() ? MapReaderToBid(reader) : null;
            }
            catch (MySqlException ex) // Changed to MySqlException
            {
                Console.WriteLine($"SQL Error: {ex.Message}");
                throw;
            }
        }
        public IEnumerable<Bid> GetAllBids()
        {
            try
            {
                using var connection = _databaseService.GetConnection();
                var query = "SELECT * FROM bids";
                using var command = new MySqlCommand(query, connection); // Changed to MySqlCommand

                connection.Open();
                using var reader = command.ExecuteReader();

                var bids = new List<Bid>();
                while (reader.Read())
                {
                    bids.Add(MapReaderToBid(reader));
                }
                return bids;
            }
            catch (MySqlException ex) // Changed to MySqlException
            {
                Console.WriteLine($"SQL Error: {ex.Message}");
                throw;
            }
        }

        public IEnumerable<Bid> GetAllBidsByProjectId(long projectId)
        {
            try
            {
                using var connection = _databaseService.GetConnection();
                var query = "SELECT * FROM bids WHERE project_id = @ProjectId";
                using var command = new MySqlCommand(query, connection); // Changed to MySqlCommand
                command.Parameters.AddWithValue("@ProjectId", projectId);

                connection.Open();
                using var reader = command.ExecuteReader();

                var bids = new List<Bid>();
                while (reader.Read())
                {
                    bids.Add(MapReaderToBid(reader));
                }
                return bids;
            }
            catch (MySqlException ex) // Changed to MySqlException
            {
                Console.WriteLine($"SQL Error: {ex.Message}");
                throw;
            }
        }


        public void UpdateBid(Bid bid)
        {
            try
            {
                using var connection = _databaseService.GetConnection();
                var query = "UPDATE bids SET project_id = @ProjectId, freelancer_id = @FreelancerId, rate = @Rate, " +
                            "rate_type = @RateType, status = @Status, comment = @Comment, created_at = @CreatedAt, freelancer_name = @FreelancerName " +
                            "WHERE bid_id = @BidId";
                using var command = new MySqlCommand(query, connection); // Changed to MySqlCommand

                MapParameters(command, bid);

                connection.Open();
                command.ExecuteNonQuery();
            }
            catch (MySqlException ex) // Changed to MySqlException
            {
                Console.WriteLine($"SQL Error: {ex.Message}");
                throw;
            }
        }

        public void DeleteBid(long bidId)
        {
            try
            {
                using var connection = _databaseService.GetConnection();
                var query = "DELETE FROM bids WHERE bid_id = @BidId";
                using var command = new MySqlCommand(query, connection); // Changed to MySqlCommand
                command.Parameters.AddWithValue("@BidId", bidId);

                connection.Open();
                command.ExecuteNonQuery();
            }
            catch (MySqlException ex) // Changed to MySqlException
            {
                Console.WriteLine($"SQL Error: {ex.Message}");
                throw;
            }
        }

        private static void MapParameters(MySqlCommand command, Bid bid) // Use MySqlCommand for MySQL
        {
            command.Parameters.AddWithValue("@BidId", bid.BidId);
            command.Parameters.AddWithValue("@ProjectId", bid.ProjectId ?? (object)DBNull.Value);
            command.Parameters.AddWithValue("@FreelancerId", bid.FreelancerId ?? (object)DBNull.Value);
            command.Parameters.AddWithValue("@Rate", bid.Rate ?? (object)DBNull.Value);
            command.Parameters.AddWithValue("@RateType", bid.RateType ?? (object)DBNull.Value);
            command.Parameters.AddWithValue("@Status", bid.Status ?? (object)DBNull.Value);
            command.Parameters.AddWithValue("@Comment", bid.Comment ?? (object)DBNull.Value);
            command.Parameters.AddWithValue("@CreatedAt", bid.CreatedAt ?? (object)DBNull.Value);
            command.Parameters.AddWithValue("@FreelancerName", bid.FreelancerName ?? (object)DBNull.Value);
        }

        private static Bid MapReaderToBid(MySqlDataReader reader) // Use MySqlDataReader for MySQL
        {
            return new Bid
            {
                BidId = reader.GetInt64(reader.GetOrdinal("bid_id")),
                ProjectId = reader["project_id"] as long?,
                FreelancerId = reader["freelancer_id"] as long?,
                FreelancerName = reader["freelancer_name"] as string,
                Rate = reader["rate"] as decimal?,
                RateType = reader["rate_type"] as string,
                Status = reader["status"] as string,
                Comment = reader["comment"] as string,
                CreatedAt = reader["created_at"] as long?,
            };
        }

    }

}
