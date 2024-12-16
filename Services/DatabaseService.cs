using Microsoft.Data.SqlClient;

namespace HeinHtetNaing_ADI.Services
{
    public class DatabaseService
    {
        private readonly string _connectionString;

        public DatabaseService()
        {
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

        public SqlConnection GetConnection()
        {
            return new SqlConnection(this._connectionString);
        }
    }
}
