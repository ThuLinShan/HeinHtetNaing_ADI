using HeinHtetNaing_ADI.Common.Attributes;
using HeinHtetNaing_ADI.Common.Utils;

namespace HeinHtetNaing_ADI.Models
{
    public class Project
    {
        [SqlColumnName("project_id")] // Specify column name for project_id
        public long ProjectId { get; set; }

        [SqlColumnName("client_id")] // Specify column name for client_id
        public long? ClientId { get; set; }

        [SqlColumnName("freelancer_id")] // Specify column name for freelancer_id
        public long? FreelancerId { get; set; }

        [SqlColumnName("title")] // Specify column name for title
        [SqlType("VARCHAR(255)")] // Explicitly specify VARCHAR for title
        public string? Title { get; set; }

        [SqlColumnName("description")] // Specify column name for description
        [SqlType("TEXT")] // Use TEXT for potentially long descriptions
        public string? Description { get; set; }

        [SqlColumnName("budget")] // Specify column name for budget
        public decimal? Budget { get; set; }

        [SqlColumnName("currency")] // Specify column name for currency
        [SqlType("VARCHAR(3)")] // Use ISO 4217 currency codes (e.g., USD, EUR)
        public string? Currency { get; set; }

        [SqlColumnName("rating")] // Specify column name for rating
        public decimal? Rating { get; set; }

        [SqlColumnName("dead_line")] // Specify column name for dead_line
        public DateTime? Deadline { get; set; }

        [SqlColumnName("status")] // Specify column name for status
        [SqlType("VARCHAR(50)")] // Explicitly specify VARCHAR for status
        public string? Status { get; set; }

        [SqlColumnName("start_date")] // Specify column name for start_date
        public long? StartDate { get; set; }

        [SqlColumnName("end_date")] // Specify column name for end_date
        public long? EndDate { get; set; }

        [SqlColumnName("completed")] // Specify column name for completed
        public bool? Completed { get; set; }

        [SqlColumnName("client_rating")] // Specify column name for client_rating
        public decimal? ClientRating { get; set; }

        [SqlColumnName("client_review")] // Specify column name for client_review
        [SqlType("TEXT")] // Use TEXT for potentially long reviews
        public string? ClientReview { get; set; }

        [SqlColumnName("created_at")] // Specify column name for created_at
        public long? CreatedAt { get; set; }

        [SqlColumnName("updated_at")] // Specify column name for updated_at
        public long? UpdatedAt { get; set; }

        [SqlColumnName("version")] // Specify column name for version
        public int? Version { get; set; }

        public Project() { }

        // Constructor
        public Project(
            long? clientId,
            long? freelancerId,
            string? title,
            string? description,
            decimal? budget,
            string? currency,
            decimal? rating,
            DateTime? deadline,
            string? status,
            long? startDate,
            long? endDate,
            bool? completed,
            decimal? clientRating,
            string? clientReview)
        {
            ProjectId = GuidUtil.GenerateNewLongGuid(); // Generate a unique project ID
            ClientId = clientId;
            FreelancerId = freelancerId;
            Title = title;
            Description = description;
            Budget = budget;
            Currency = currency;
            Rating = rating;
            Deadline = deadline;
            Status = status;
            StartDate = startDate;
            EndDate = endDate;
            Completed = completed;
            ClientRating = clientRating;
            ClientReview = clientReview;
            CreatedAt = DateTimeOffset.UtcNow.ToUnixTimeSeconds();
            UpdatedAt = DateTimeOffset.UtcNow.ToUnixTimeSeconds();
            Version = 1;
        }
    }
}
