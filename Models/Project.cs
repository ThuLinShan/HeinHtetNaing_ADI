﻿using HeinHtetNaing_ADI.Common.Attributes;
using HeinHtetNaing_ADI.Common.Utils;

namespace HeinHtetNaing_ADI.Models
{
    public class Project
    {
        [SqlColumnName("project_id")]
        public long ProjectId { get; set; }

        [SqlColumnName("client_id")]
        public long? ClientId { get; set; }

        [SqlColumnName("freelancer_id")]
        public long? FreelancerId { get; set; }

        [SqlColumnName("title")]
        [SqlType("VARCHAR(255)")]
        public string? Title { get; set; }

        [SqlColumnName("description")]
        [SqlType("TEXT")]
        public string? Description { get; set; }

        [SqlColumnName("skill_tags")]
        [SqlType("TEXT")]
        public List<string>? SkillTags { get; set; }

        [SqlColumnName("budget")]
        public decimal? Budget { get; set; }

        [SqlColumnName("currency")]
        [SqlType("VARCHAR(3)")]
        public string? Currency { get; set; }

        [SqlColumnName("rating")]
        [SqlType("DECIMAL")]
        public decimal? Rating { get; set; }

        [SqlColumnName("dead_line")]
        public DateTime Deadline { get; set; }

        [SqlColumnName("status")]
        [SqlType("VARCHAR(50)")]
        public string? Status { get; set; }

        [SqlColumnName("start_date")]
        public long? StartDate { get; set; }

        [SqlColumnName("end_date")]
        public long? EndDate { get; set; }

        [SqlColumnName("completed")]
        [SqlType("TINYINT")]
        public bool? Completed { get; set; }

        [SqlColumnName("client_rating")]
        public decimal? ClientRating { get; set; }

        [SqlColumnName("client_review")]
        [SqlType("TEXT")]
        public string? ClientReview { get; set; }

        [SqlColumnName("created_at")]
        public long? CreatedAt { get; set; }

        [SqlColumnName("updated_at")]
        public long? UpdatedAt { get; set; }

        [SqlColumnName("version")]
        public int? Version { get; set; }


        public Project() { }

        // Constructor
        public Project(
            long? clientId,
            string? title,
            string? description,
            List<String>? skillTags,
            decimal? budget,
            string? currency,
            DateTime deadline,
            long? startDate)
        {
            ProjectId = GuidUtil.GenerateNewLongGuid(); // Generate a unique project ID
            ClientId = clientId;
            FreelancerId = null;
            Title = title;
            Description = description;
            SkillTags = skillTags;
            Budget = budget;
            Currency = currency;
            Rating = null;
            Deadline = deadline;
            Status = "Pending";
            StartDate = startDate;
            EndDate = null;
            Completed = false;
            ClientRating = null;
            ClientReview = null;
            CreatedAt = DateTimeOffset.UtcNow.ToUnixTimeSeconds();
            UpdatedAt = DateTimeOffset.UtcNow.ToUnixTimeSeconds();
            Version = 1;
        }

        public void Accepted(long freelancerId)
        {
            this.Status = "Ongoing";
            this.UpdatedAt = DateTimeOffset.UtcNow.ToUnixTimeSeconds();
            this.StartDate = DateTimeOffset.UtcNow.ToUnixTimeSeconds();
            this.FreelancerId = freelancerId;
            Version += 1;
        }

        public void Finished()
        {
            this.Status = "Completed";
            this.Completed = true;
            this.EndDate = DateTimeOffset.UtcNow.ToUnixTimeSeconds();
            Version += 1;
        }

        // Helper to convert SkillTags to a comma-separated string for database storage
        public string SkillTagsToString()
        {
            return SkillTags != null ? string.Join(", ", SkillTags) : string.Empty;
        }

        // Helper to convert a comma-separated string back to SkillTags list
        public static List<string> StringToSkillTags(string skillTagsString)
        {
            return !string.IsNullOrEmpty(skillTagsString)
                ? skillTagsString.Split(',').Select(tag => tag.Trim()).ToList()
                : new List<string>();
        }
    }
}
