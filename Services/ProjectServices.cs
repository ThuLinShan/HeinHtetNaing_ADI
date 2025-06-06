﻿using HeinHtetNaing_ADI.Common.DTOs;
using HeinHtetNaing_ADI.Models;
using MySql.Data.MySqlClient;

namespace HeinHtetNaing_ADI.Services
{
    public class ProjectService
    {
        private readonly DatabaseService _databaseService;

        public ProjectService()
        {
            _databaseService = new DatabaseService();
        }

        public void AddProject(Project project)
        {
            try
            {
                using var connection = _databaseService.GetConnection();
                var query = "INSERT INTO project (project_id, client_id, freelancer_id, title, description, budget, currency, rating, dead_line, " +
                            "status, start_date, end_date, completed, client_rating, client_review, created_at, updated_at, version, skill_tags) " +
                            "VALUES (@ProjectId, @ClientId, @FreelancerId, @Title, @Description, @Budget, @Currency, @Rating, @Deadline, " +
                            "@Status, @StartDate, @EndDate, @Completed, @ClientRating, @ClientReview, @CreatedAt, @UpdatedAt, @Version, @SkillTags)";

                using var command = new MySqlCommand(query, connection);

                // Map parameters to the MySqlCommand object
                MapParameters(command, project);

                connection.Open();
                command.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                Console.WriteLine($"SQL Error: {ex.Message}");
                throw;
            }
        }
        public List<Project> GetAllCompletedProjectsByFreelancer(long freelancerId)
        {
            try
            {
                using var connection = _databaseService.GetConnection();
                var query = "SELECT * FROM project WHERE freelancer_id = @FreelancerId AND status = @Status";
                using var command = new MySqlCommand(query, connection);  // Changed SqlCommand to MySqlCommand
                command.Parameters.AddWithValue("@FreelancerId", freelancerId);
                command.Parameters.AddWithValue("@Status", "Completed");

                connection.Open();
                using var reader = command.ExecuteReader();

                var projects = new List<Project>();
                while (reader.Read())
                {
                    projects.Add(MapReaderToProject(reader)); // Assuming MapReaderToProject maps the database row to a Project object
                }

                return projects;
            }
            catch (MySqlException ex)  // Changed SqlException to MySqlException
            {
                Console.WriteLine($"SQL Error: {ex.Message}");
                throw;
            }
        }


        public Project? GetProjectById(long projectId)
        {
            try
            {
                using var connection = _databaseService.GetConnection();
                var query = "SELECT * FROM project WHERE project_id = @ProjectId";
                using var command = new MySqlCommand(query, connection);  // Changed SqlCommand to MySqlCommand
                command.Parameters.AddWithValue("@ProjectId", projectId);

                connection.Open();
                using var reader = command.ExecuteReader();
                return reader.Read() ? MapReaderToProject(reader) : null;
            }
            catch (MySqlException ex)  // Changed SqlException to MySqlException
            {
                Console.WriteLine($"SQL Error: {ex.Message}");
                throw;
            }
        }

        public PagedResult<Project> GetPagedProjectsByClientId(long clientId, int pageNumber, int pageSize)
        {
            try
            {
                using var connection = _databaseService.GetConnection();

                // Calculate the offset for pagination
                int offset = (pageNumber - 1) * pageSize;

                // Query to get paginated projects for a specific client
                var query = "SELECT * FROM project WHERE client_id = @ClientId ORDER BY project_id LIMIT @PageSize OFFSET @Offset"; // Modified pagination for MySQL

                using var command = new MySqlCommand(query, connection);  // Changed SqlCommand to MySqlCommand
                command.Parameters.AddWithValue("@ClientId", clientId);
                command.Parameters.AddWithValue("@Offset", offset);
                command.Parameters.AddWithValue("@PageSize", pageSize);

                connection.Open();
                using var reader = command.ExecuteReader();

                // Read all projects for the specified client
                var projects = new List<Project>();
                while (reader.Read())
                {
                    projects.Add(MapReaderToProject(reader));
                }

                // Query to get the total count of projects for the specified client
                var countQuery = "SELECT COUNT(*) FROM project WHERE client_id = @ClientId";
                using var countCommand = new MySqlCommand(countQuery, connection);  // Changed SqlCommand to MySqlCommand
                countCommand.Parameters.AddWithValue("@ClientId", clientId);
                var totalCount = Convert.ToInt32(countCommand.ExecuteScalar());

                // Return paginated result
                return new PagedResult<Project>(projects, totalCount, offset, pageSize);
            }
            catch (MySqlException ex)  // Changed SqlException to MySqlException
            {
                Console.WriteLine($"SQL Error: {ex.Message}");
                throw;
            }
        }

        public IEnumerable<Project> GetAllProjects()
        {
            try
            {
                using var connection = _databaseService.GetConnection();
                var query = "SELECT * FROM project";
                using var command = new MySqlCommand(query, connection);

                connection.Open();
                using var reader = command.ExecuteReader();

                var projects = new List<Project>();
                while (reader.Read())
                {
                    projects.Add(MapReaderToProject(reader));
                }
                return projects;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine($"MySQL Error: {ex.Message}");
                throw;
            }
        }

        public IEnumerable<(Project Project, int TotalBids)> BrowseProjects(string keyword, long freelancerId)
        {
            try
            {
                using var connection = _databaseService.GetConnection();

                // Base query with relevance score calculation
                var query = @"
        WITH FreelancerSkills AS (
            SELECT skill_name
            FROM skill
            WHERE freelancer_id = @FreelancerId
        )
        SELECT 
            p.*, 
            (SELECT COUNT(*) 
             FROM bids b 
             WHERE b.project_id = p.project_id) AS TotalBids,
            COALESCE((
                SELECT COUNT(1)
                FROM FreelancerSkills fs
                WHERE p.skill_tags LIKE CONCAT('%', fs.skill_name, '%')
            ), 0) AS RelevanceScore
        FROM project p
        WHERE p.status = 'Pending' 
        AND NOT EXISTS (
            SELECT 1 
            FROM bids b 
            WHERE b.freelancer_id = @FreelancerId AND b.project_id = p.project_id
        )
        ";

                // Add keyword filter if provided
                if (!string.IsNullOrEmpty(keyword))
                {
                    query += " AND (p.title LIKE @Keyword OR p.description LIKE @Keyword)";
                }

                // Sort by relevance score and total bids
                query += " ORDER BY RelevanceScore DESC, TotalBids ASC";

                using var command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@FreelancerId", freelancerId);

                if (!string.IsNullOrEmpty(keyword))
                {
                    command.Parameters.AddWithValue("@Keyword", $"%{keyword}%");
                }

                connection.Open();
                using var reader = command.ExecuteReader();

                var results = new List<(Project Project, int TotalBids)>();
                while (reader.Read())
                {
                    var project = MapReaderToProject(reader);
                    var totalBids = reader.GetInt32(reader.GetOrdinal("TotalBids"));

                    results.Add((project, totalBids));
                }
                return results;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine($"MySQL Error: {ex.Message}");
                throw;
            }
        }

        public IEnumerable<Project> GetAllProjectsByClientId(long clientId)
        {
            try
            {
                using var connection = _databaseService.GetConnection();
                var query = "SELECT * FROM project WHERE client_id = @ClientId";
                using var command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@ClientId", clientId);

                connection.Open();
                using var reader = command.ExecuteReader();

                var projects = new List<Project>();
                while (reader.Read())
                {
                    projects.Add(MapReaderToProject(reader));
                }
                return projects;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine($"MySQL Error: {ex.Message}");
                throw;
            }
        }
        public IEnumerable<Project> GetOngoingProjectsByFreelancerId(long freelancerId)
        {
            try
            {
                using var connection = _databaseService.GetConnection();
                var query = "SELECT * FROM project WHERE status = 'Ongoing' AND freelancer_id = @FreelancerId";
                using var command = new MySqlCommand(query, connection); // Changed to MySqlCommand
                command.Parameters.AddWithValue("@FreelancerId", freelancerId);

                connection.Open();
                using var reader = command.ExecuteReader();

                var projects = new List<Project>();
                while (reader.Read())
                {
                    projects.Add(MapReaderToProject(reader));
                }
                return projects;
            }
            catch (MySqlException ex) // Changed to MySqlException
            {
                Console.WriteLine($"MySQL Error: {ex.Message}");
                throw;
            }
        }

        public int GetTotalProjectsByClientId(long clientId)
        {
            try
            {
                using var connection = _databaseService.GetConnection();
                var query = "SELECT COUNT(*) FROM project WHERE client_id = @ClientId";
                using var command = new MySqlCommand(query, connection); // Changed to MySqlCommand
                command.Parameters.AddWithValue("@ClientId", clientId);

                connection.Open();
                return Convert.ToInt32(command.ExecuteScalar());
            }
            catch (MySqlException ex) // Changed to MySqlException
            {
                Console.WriteLine($"MySQL Error: {ex.Message}");
                throw;
            }
        }

        public void UpdateProject(Project project)
        {
            try
            {
                using var connection = _databaseService.GetConnection();
                var query = "UPDATE project SET client_id = @ClientId, freelancer_id = @FreelancerId, title = @Title, description = @Description, " +
                            "budget = @Budget, currency = @Currency, rating = @Rating, dead_line = @Deadline, status = @Status, " +
                            "start_date = @StartDate, end_date = @EndDate, completed = @Completed, client_rating = @ClientRating, " +
                            "client_review = @ClientReview, updated_at = @UpdatedAt, version = @Version, skill_tags = @SkillTags " +
                            "WHERE project_id = @ProjectId";
                using var command = new MySqlCommand(query, connection); // Changed to MySqlCommand

                MapParameters(command, project);

                connection.Open();
                command.ExecuteNonQuery();
            }
            catch (MySqlException ex) // Changed to MySqlException
            {
                Console.WriteLine($"MySQL Error: {ex.Message}");
                throw;
            }
        }

        public void DeleteProject(long projectId)
        {
            try
            {
                using var connection = _databaseService.GetConnection();
                connection.Open();  // Open the connection before executing any commands

                // Start a transaction to ensure both deletions are successful or rolled back
                using var transaction = connection.BeginTransaction();

                // Delete bids associated with the project
                var deleteBidsQuery = "DELETE FROM bids WHERE project_id = @ProjectId";
                using var deleteBidsCommand = new MySqlCommand(deleteBidsQuery, connection, transaction); // Changed to MySqlCommand
                deleteBidsCommand.Parameters.AddWithValue("@ProjectId", projectId);
                deleteBidsCommand.ExecuteNonQuery();

                // Delete the project itself
                var deleteProjectQuery = "DELETE FROM project WHERE project_id = @ProjectId";
                using var deleteProjectCommand = new MySqlCommand(deleteProjectQuery, connection, transaction); // Changed to MySqlCommand
                deleteProjectCommand.Parameters.AddWithValue("@ProjectId", projectId);
                deleteProjectCommand.ExecuteNonQuery();

                // Commit the transaction if both deletions are successful
                transaction.Commit();
            }
            catch (MySqlException ex) // Changed to MySqlException
            {
                Console.WriteLine($"MySQL Error: {ex.Message}");
                throw;
            }
        }


        private static void MapParameters(MySqlCommand command, Project project)
        {
            command.Parameters.AddWithValue("@ProjectId", project.ProjectId);
            command.Parameters.AddWithValue("@ClientId", project.ClientId ?? (object)DBNull.Value);
            command.Parameters.AddWithValue("@FreelancerId", project.FreelancerId ?? (object)DBNull.Value);
            command.Parameters.AddWithValue("@Title", project.Title ?? (object)DBNull.Value);
            command.Parameters.AddWithValue("@Description", project.Description ?? (object)DBNull.Value);
            command.Parameters.AddWithValue("@Budget", project.Budget ?? (object)DBNull.Value);
            command.Parameters.AddWithValue("@Currency", project.Currency ?? (object)DBNull.Value);
            command.Parameters.AddWithValue("@Rating", project.Rating ?? (object)DBNull.Value);
            command.Parameters.AddWithValue("@Deadline", project.Deadline.ToString("yyyy-MM-dd HH:mm:ss") ?? (object)DBNull.Value);
            command.Parameters.AddWithValue("@Status", project.Status ?? (object)DBNull.Value);
            command.Parameters.AddWithValue("@StartDate", project.StartDate ?? (object)DBNull.Value);
            command.Parameters.AddWithValue("@EndDate", project.EndDate ?? (object)DBNull.Value);
            command.Parameters.AddWithValue("@Completed", project.Completed.HasValue ? (object)(project.Completed.Value ? 1 : 0) : DBNull.Value);
            command.Parameters.AddWithValue("@ClientRating", project.ClientRating ?? (object)DBNull.Value);
            command.Parameters.AddWithValue("@ClientReview", project.ClientReview ?? (object)DBNull.Value);
            command.Parameters.AddWithValue("@CreatedAt", project.CreatedAt ?? (object)DBNull.Value);
            command.Parameters.AddWithValue("@UpdatedAt", project.UpdatedAt ?? (object)DBNull.Value);
            command.Parameters.AddWithValue("@Version", project.Version ?? (object)DBNull.Value);

            // Convert SkillTags list to a comma-separated string
            var skillTagsString = project.SkillTags != null ? string.Join(",", project.SkillTags) : (object)DBNull.Value;
            command.Parameters.AddWithValue("@SkillTags", skillTagsString);
        }
        private static Project MapReaderToProject(MySqlDataReader reader)
        {
            var project = new Project
            {
                ProjectId = reader.GetInt64(reader.GetOrdinal("project_id")),
                ClientId = reader["client_id"] as long?,
                FreelancerId = reader["freelancer_id"] as long?,
                Title = reader["title"] as string,
                Description = reader["description"] as string,
                Budget = reader["budget"] as decimal?,
                Currency = reader["currency"] as string,
                Rating = reader["rating"] as decimal?,
                Deadline = reader["dead_line"] as DateTime? ?? default(DateTime),
                Status = reader["status"] as string,
                StartDate = reader["start_date"] as long?,
                EndDate = reader["end_date"] as long?,
                Completed = reader["completed"] != DBNull.Value ? Convert.ToByte(reader["completed"]) == 1 : (bool?)null,
                ClientRating = reader["client_rating"] as decimal?,
                ClientReview = reader["client_review"] as string,
                CreatedAt = reader.GetInt64(reader.GetOrdinal("created_at")),
                UpdatedAt = reader.GetInt64(reader.GetOrdinal("updated_at")),
                Version = reader["version"] as int?
            };

            // Parse SkillTags back to a List<string>
            var skillTagsString = reader["skill_tags"] as string;
            project.SkillTags = skillTagsString?.Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries).ToList();

            return project;
        }


    }

}
