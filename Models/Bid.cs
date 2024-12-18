using HeinHtetNaing_ADI.Common.Attributes;
using HeinHtetNaing_ADI.Common.Utils;

namespace HeinHtetNaing_ADI.Models
{
    public class Bid
    {
        [SqlColumnName("bid_id")] // Specify column name for bid_id
        public long BidId { get; set; }

        [SqlColumnName("project_id")] // Specify column name for project_id
        public long? ProjectId { get; set; }

        [SqlColumnName("freelancer_id")] // Specify column name for freelancer_id
        public long? FreelancerId { get; set; }

        [SqlColumnName("freelancer_name")] // Specify column name for FreelancerName
        [SqlType("VARCHAR(255)")]         // Explicitly specify VARCHAR for FreelancerName
        public string? FreelancerName { get; set; }

        [SqlColumnName("rate")] // Specify column name for rate
        [SqlType("DECIMAL")]   // Explicitly specify DECIMAL for rate
        public decimal? Rate { get; set; }

        [SqlColumnName("rate_type")] // Specify column name for rate_type
        [SqlType("VARCHAR(45)")]    // Explicitly specify VARCHAR for rate_type
        public string? RateType { get; set; }

        [SqlColumnName("status")] // Specify column name for status
        [SqlType("VARCHAR(45)")] // Explicitly specify VARCHAR for status
        public string? Status { get; set; }

        [SqlColumnName("comment")] // Specify column name for comment
        [SqlType("TEXT")]          // Explicitly specify TEXT for comment
        public string? Comment { get; set; }

        [SqlColumnName("created_at")] // Specify column name for created_at
        public long? CreatedAt { get; set; } // Assuming BIGINT stores timestamps in epoch format

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
