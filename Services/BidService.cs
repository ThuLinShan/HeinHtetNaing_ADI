using HeinHtetNaing_ADI.Models;
using Microsoft.Data.SqlClient;

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
                var query = "INSERT INTO bids (bid_id, project_id, freelancer_id, rate, rate_type, status, comment, created_at, freelancer_name) " +
                            "VALUES (@BidId, @ProjectId, @FreelancerId, @Rate, @RateType, @Status, @Comment, @CreatedAt, @FreelancerName)";
                using var command = new SqlCommand(query, connection);

                MapParameters(command, bid);

                connection.Open();
                command.ExecuteNonQuery();
            }
            catch (SqlException ex)
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
                using var command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@BidId", bidId);

                connection.Open();
                using var reader = command.ExecuteReader();
                return reader.Read() ? MapReaderToBid(reader) : null;
            }
            catch (SqlException ex)
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
                using var command = new SqlCommand(query, connection);

                connection.Open();
                using var reader = command.ExecuteReader();

                var bids = new List<Bid>();
                while (reader.Read())
                {
                    bids.Add(MapReaderToBid(reader));
                }
                return bids;
            }
            catch (SqlException ex)
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
                using var command = new SqlCommand(query, connection);
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
            catch (SqlException ex)
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
                using var command = new SqlCommand(query, connection);

                MapParameters(command, bid);

                connection.Open();
                command.ExecuteNonQuery();
            }
            catch (SqlException ex)
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
                using var command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@BidId", bidId);

                connection.Open();
                command.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                Console.WriteLine($"SQL Error: {ex.Message}");
                throw;
            }
        }

        private static void MapParameters(SqlCommand command, Bid bid)
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

        private static Bid MapReaderToBid(SqlDataReader reader)
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
