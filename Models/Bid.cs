using HeinHtetNaing_ADI.Common.Attributes;
using HeinHtetNaing_ADI.Common.Utils;

namespace HeinHtetNaing_ADI.Models
{
    public class Bid
    {
        [SqlColumnName("bid_id")] // Specify column name for bid_id
        [SqlType("BIGINT")]       // Explicitly specify BIGINT for bid_id (since it's auto-increment in MySQL, no need to set it manually)
        public long BidId { get; set; }

        [SqlColumnName("project_id")] // Specify column name for project_id
        [SqlType("BIGINT")]          // Specify BIGINT for project_id
        public long? ProjectId { get; set; }

        [SqlColumnName("freelancer_id")] // Specify column name for freelancer_id
        [SqlType("BIGINT")]             // Specify BIGINT for freelancer_id
        public long? FreelancerId { get; set; }

        [SqlColumnName("freelancer_name")] // Specify column name for freelancer_name
        [SqlType("VARCHAR(255)")]         // Explicitly specify VARCHAR(255) for freelancer_name
        public string? FreelancerName { get; set; }

        [SqlColumnName("rate")] // Specify column name for rate
        [SqlType("DECIMAL(18,2)")] // Specify DECIMAL(18,2) for rate
        public decimal? Rate { get; set; }

        [SqlColumnName("rate_type")] // Specify column name for rate_type
        [SqlType("VARCHAR(45)")]    // Explicitly specify VARCHAR(45) for rate_type
        public string? RateType { get; set; }

        [SqlColumnName("status")] // Specify column name for status
        [SqlType("VARCHAR(45)")]  // Explicitly specify VARCHAR(45) for status
        public string? Status { get; set; }

        [SqlColumnName("comment")] // Specify column name for comment
        [SqlType("TEXT")]          // Explicitly specify TEXT for comment
        public string? Comment { get; set; }

        [SqlColumnName("created_at")] // Specify column name for created_at
        [SqlType("BIGINT")]           // Specify BIGINT for created_at (assuming epoch timestamp)
        public long? CreatedAt { get; set; }

        public Bid()
        {

        }

        public Bid(
            long projectId,
            long freeLancerId,
            string freeLancerName,
            decimal rate,
            string rateType,
            string status,
            string comment
            )
        {
            BidId = GuidUtil.GenerateNewLongGuid();
            ProjectId = projectId;
            FreelancerId = freeLancerId;
            FreelancerName = freeLancerName;
            Rate = rate;
            RateType = rateType;
            Status = status;
            Comment = comment;
            CreatedAt = DateTimeOffset.UtcNow.ToUnixTimeSeconds();
        }
    }

}
