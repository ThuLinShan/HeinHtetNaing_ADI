using HeinHtetNaing_ADI.Common.Attributes;
using HeinHtetNaing_ADI.Common.Utils;

namespace HeinHtetNaing_ADI.Models
{
    public class Client
    {
        [SqlColumnName("client_id")] // Specify column name for client_id
        [SqlType("BIGINT")]          // Explicitly specify BIGINT for client_id
        public long ClientId { get; set; }

        [SqlColumnName("first_name")] // Specify column name for first_name
        [SqlType("VARCHAR(255)")]     // Explicitly specify VARCHAR(255) for first_name
        public string? FirstName { get; set; }

        [SqlColumnName("last_name")]  // Specify column name for last_name
        [SqlType("VARCHAR(255)")]     // Explicitly specify VARCHAR(255) for last_name
        public string? LastName { get; set; }

        [SqlColumnName("email")]      // Specify column name for email
        [SqlType("VARCHAR(255)")]     // Explicitly specify VARCHAR(255) for email
        public string? Email { get; set; }

        [SqlColumnName("password_hash")] // Specify column name for password_hash
        [SqlType("VARCHAR(255)")]        // Explicitly specify VARCHAR(255) for password_hash
        public string? PasswordHash { get; set; }

        [SqlColumnName("address")]   // Specify column name for address
        [SqlType("TEXT")]            // Explicitly specify TEXT for address
        public string? Address { get; set; }

        [SqlColumnName("phone_no")]  // Specify column name for phone_no
        [SqlType("VARCHAR(15)")]     // Explicitly specify VARCHAR(15) for phone_no
        public string? PhoneNo { get; set; }

        [SqlColumnName("image")]     // Specify column name for image
        [SqlType("TEXT")]            // Explicitly specify TEXT for image
        public string? Image { get; set; }

        public Client() { }

        public Client(string firstName, string lastName, string email, string password, string? address = null, string? phoneNo = null, string? image = null)
        {
            ClientId = GuidUtil.GenerateNewLongGuid();
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Address = address;
            PhoneNo = phoneNo;

            // Hash the input password using PasswordUtil
            PasswordHash = PasswordUtil.HashPassword(password);
        }

        internal bool Login(string password)
        {
            if (string.IsNullOrEmpty(password) || string.IsNullOrEmpty(PasswordHash))
            {
                Console.WriteLine("Password or password hash cannot be null or empty.");
                return false;
            }

            return PasswordUtil.VerifyPassword(password, PasswordHash);
        }

        internal void update(
            String firstName,
            String lastName,
            String email,
            String PhoneNo,
            String Address)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Email = email;
            this.PhoneNo = PhoneNo;
            this.Address = Address;
        }
    }
}
