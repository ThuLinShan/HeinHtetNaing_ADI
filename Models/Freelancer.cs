using HeinHtetNaing_ADI.Common.Attributes;
using HeinHtetNaing_ADI.Common.Utils;

namespace HeinHtetNaing_ADI.Models
{
    public class Freelancer
    {
        [SqlColumnName("freelancer_id")] // Specify column name for freelancer_id
        public long FreelancerId { get; set; }

        [SqlColumnName("first_name")] // Specify column name for first_name
        [SqlType("VARCHAR(255)")]     // Adjusted VARCHAR size for first name
        public string? FirstName { get; set; }

        [SqlColumnName("last_name")] // Specify column name for last_name
        [SqlType("VARCHAR(255)")]    // Adjusted VARCHAR size for last name
        public string? LastName { get; set; }

        [SqlColumnName("email")] // Specify column name for email
        [SqlType("VARCHAR(320)")]  // Set to 320, maximum length for valid email addresses
        public string? Email { get; set; }

        [SqlColumnName("password_hash")] // Specify column name for password_hash
        [SqlType("VARCHAR(255)")]         // Adjusted size for hash storage
        public string? PasswordHash { get; set; } // Private setter to ensure controlled updates

        [SqlColumnName("address")]   // Specify column name for address
        [SqlType("TEXT")]            // Changed to TEXT for longer addresses
        public string? Address { get; set; }

        [SqlColumnName("phone_no")] // Specify column name for phone_no
        [SqlType("VARCHAR(15)")]    // Adjusted size for phone numbers
        public string? PhoneNo { get; set; }

        [SqlColumnName("best_project")] // Specify column name for best_project
        public long? BestProject { get; set; } // Nullable, referencing a project ID

        [SqlColumnName("website_link")] // Specify column name for website_link
        [SqlType("VARCHAR(2083)")]      // Maximum length for URLs as per standards
        public string? WebsiteLink { get; set; }

        [SqlColumnName("image")]  // Specify column name for image
        [SqlType("TEXT")]         // Changed to TEXT for image URLs or paths
        public string? Image { get; set; }

        [SqlColumnName("rating")] // Specify column name for rating
        public decimal? Rating { get; set; } // Nullable, for cases where rating is not yet provided


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
