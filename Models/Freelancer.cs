using HeinHtetNaing_ADI.Common.Attributes;
using HeinHtetNaing_ADI.Common.Utils;

namespace HeinHtetNaing_ADI.Models
{
    public class Freelancer
    {
        [SqlColumnName("freelancer_id")]
        public long FreelancerId { get; set; }

        [SqlColumnName("first_name")]
        [SqlType("VARCHAR(255)")]
        public string? FirstName { get; set; }

        [SqlColumnName("last_name")]
        [SqlType("VARCHAR(255)")]
        public string? LastName { get; set; }

        [SqlColumnName("email")]
        [SqlType("VARCHAR(320)")]
        public string? Email { get; set; }

        [SqlColumnName("password_hash")]
        [SqlType("VARCHAR(255)")]
        public string? PasswordHash { get; set; }

        [SqlColumnName("address")]
        [SqlType("TEXT")]
        public string? Address { get; set; }

        [SqlColumnName("phone_no")]
        [SqlType("VARCHAR(15)")]
        public string? PhoneNo { get; set; }

        [SqlColumnName("best_project")]
        public long? BestProject { get; set; }

        [SqlColumnName("website_link")]
        [SqlType("VARCHAR(2083)")]
        public string? WebsiteLink { get; set; }

        [SqlColumnName("image")]
        [SqlType("TEXT")]
        public string? Image { get; set; }

        [SqlColumnName("rating")]
        public decimal? Rating { get; set; }

        public List<Skill> Skills { get; set; } = new();

        public Freelancer()
        {
            FreelancerId = GuidUtil.GenerateNewLongGuid();
        }

        public Freelancer(string firstName, string lastName, string email, string password, string? address = null, string? phoneNo = null,
                          long? bestProject = null, string? websiteLink = null, string? image = null, decimal? rating = null)
        {
            FreelancerId = GuidUtil.GenerateNewLongGuid();
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Address = address;
            PhoneNo = phoneNo;
            BestProject = bestProject;
            WebsiteLink = websiteLink;
            Image = image;
            Rating = rating;

            PasswordHash = PasswordUtil.HashPassword(password);
        }

        public bool VerifyPassword(string password)
        {
            if (string.IsNullOrEmpty(password) || string.IsNullOrEmpty(PasswordHash))
            {
                Console.WriteLine("Password or password hash cannot be null or empty.");
                return false;
            }

            return PasswordUtil.VerifyPassword(password, PasswordHash);
        }
    }

}
