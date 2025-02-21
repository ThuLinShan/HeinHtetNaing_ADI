using Microsoft.Data.SqlClient;
using MySql.Data.MySqlClient;
using System.Diagnostics;

namespace HeinHtetNaing_ADI.Services
{
    public class DatabaseService
    {
        private readonly string _connectionString;

        public DatabaseService()
        {
            if (IsDevelopmentEnvironment())
            {
                // Use MySQL connection in the development environment
                this._connectionString = "server=localhost;port=3306;database=heinhtetnaing_adi;user=root;password=password;";
            }
            else
            {
                // Use MySQL connection in the published environment
                this._connectionString = "server=localhost;port=3306;database=heinhtetnaing_adi;user=root;password=password;";
            }
        }

        private bool IsDevelopmentEnvironment()
        {
            // Check if the application is running in a debugger
            return Debugger.IsAttached;
        }

        public MySqlConnection GetConnection()
        {
            return new MySqlConnection(this._connectionString);
        }
    }
}
