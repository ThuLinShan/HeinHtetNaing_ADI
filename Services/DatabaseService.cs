using Microsoft.Data.SqlClient;
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
                // Use project directory in development environment
                string projectDirectory = AppContext.BaseDirectory;

                while (!string.IsNullOrEmpty(projectDirectory) && !projectDirectory.EndsWith("HeinHtetNaing_ADI"))
                {
                    projectDirectory = Directory.GetParent(projectDirectory)?.FullName;
                }

                if (projectDirectory != null)
                {
                    string databaseFilePath = Path.Combine(projectDirectory, "Database", "Freelancing_Project.mdf");
                    this._connectionString = $@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename={databaseFilePath};Integrated Security=True";
                }
                else
                {
                    throw new InvalidOperationException("Project directory could not be determined.");
                }
            }
            else
            {
                // Use output directory in published environment
                string databaseFileName = "Freelancing_Project.mdf";
                string outputDirectory = AppContext.BaseDirectory;
                string databaseFilePath = Path.Combine(outputDirectory, "Database", databaseFileName);
                this._connectionString = $@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename={databaseFilePath};Integrated Security=True";
            }
        }

        private bool IsDevelopmentEnvironment()
        {
            // Check if the application is running in a debugger
            return Debugger.IsAttached;
        }

        public SqlConnection GetConnection()
        {
            return new SqlConnection(this._connectionString);
        }
    }
}
