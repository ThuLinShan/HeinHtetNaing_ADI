﻿using HeinHtetNaing_ADI.Common.DTOs;
using HeinHtetNaing_ADI.Models;
using Microsoft.Data.SqlClient;

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
                            "status, start_date, end_date, completed, client_rating, client_review, created_at, updated_at, version) " +
                            "VALUES (@ProjectId, @ClientId, @FreelancerId, @Title, @Description, @Budget, @Currency, @Rating, @Deadline, " +
                            "@Status, @StartDate, @EndDate, @Completed, @ClientRating, @ClientReview, @CreatedAt, @UpdatedAt, @Version)";
                using var command = new SqlCommand(query, connection);

                MapParameters(command, project);

                connection.Open();
                command.ExecuteNonQuery();
            }
            catch (SqlException ex)
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
                using var command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@ProjectId", projectId);

                connection.Open();
                using var reader = command.ExecuteReader();
                return reader.Read() ? MapReaderToProject(reader) : null;
            }
            catch (SqlException ex)
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
                var query = "SELECT * FROM project WHERE client_id = @ClientId ORDER BY project_id OFFSET @Offset ROWS FETCH NEXT @PageSize ROWS ONLY";

                using var command = new SqlCommand(query, connection);
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
                using var countCommand = new SqlCommand(countQuery, connection);
                countCommand.Parameters.AddWithValue("@ClientId", clientId);
                var totalCount = Convert.ToInt32(countCommand.ExecuteScalar());

                // Return paginated result
                return new PagedResult<Project>(projects, totalCount, offset, pageSize);
            }
            catch (SqlException ex)
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
                using var command = new SqlCommand(query, connection);

                connection.Open();
                using var reader = command.ExecuteReader();

                var projects = new List<Project>();
                while (reader.Read())
                {
                    projects.Add(MapReaderToProject(reader));
                }
                return projects;
            }
            catch (SqlException ex)
            {
                Console.WriteLine($"SQL Error: {ex.Message}");
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
                            "client_review = @ClientReview, updated_at = @UpdatedAt, version = @Version " +
                            "WHERE project_id = @ProjectId";
                using var command = new SqlCommand(query, connection);

                MapParameters(command, project);

                connection.Open();
                command.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                Console.WriteLine($"SQL Error: {ex.Message}");
                throw;
            }
        }

        public void DeleteProject(long projectId)
        {
            try
            {
                using var connection = _databaseService.GetConnection();
                var query = "DELETE FROM project WHERE project_id = @ProjectId";
                using var command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@ProjectId", projectId);

                connection.Open();
                command.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                Console.WriteLine($"SQL Error: {ex.Message}");
                throw;
            }
        }

        private static void MapParameters(SqlCommand command, Project project)
        {
            command.Parameters.AddWithValue("@ProjectId", project.ProjectId);
            command.Parameters.AddWithValue("@ClientId", project.ClientId ?? (object)DBNull.Value);
            command.Parameters.AddWithValue("@FreelancerId", project.FreelancerId ?? (object)DBNull.Value);
            command.Parameters.AddWithValue("@Title", project.Title ?? (object)DBNull.Value);
            command.Parameters.AddWithValue("@Description", project.Description ?? (object)DBNull.Value);
            command.Parameters.AddWithValue("@Budget", project.Budget ?? (object)DBNull.Value);
            command.Parameters.AddWithValue("@Currency", project.Currency ?? (object)DBNull.Value);
            command.Parameters.AddWithValue("@Rating", project.Rating ?? (object)DBNull.Value);
            command.Parameters.AddWithValue("@Deadline", project.Deadline?.ToString("yyyy-MM-dd") ?? (object)DBNull.Value);
            command.Parameters.AddWithValue("@Status", project.Status ?? (object)DBNull.Value);
            command.Parameters.AddWithValue("@StartDate", project.StartDate ?? (object)DBNull.Value);
            command.Parameters.AddWithValue("@EndDate", project.EndDate ?? (object)DBNull.Value);
            command.Parameters.AddWithValue("@Completed", project.Completed ?? (object)DBNull.Value);
            command.Parameters.AddWithValue("@ClientRating", project.ClientRating ?? (object)DBNull.Value);
            command.Parameters.AddWithValue("@ClientReview", project.ClientReview ?? (object)DBNull.Value);
            command.Parameters.AddWithValue("@CreatedAt", project.CreatedAt);
            command.Parameters.AddWithValue("@UpdatedAt", project.UpdatedAt);
            command.Parameters.AddWithValue("@Version", project.Version ?? (object)DBNull.Value);
        }

        private static Project MapReaderToProject(SqlDataReader reader)
        {
            return new Project
            {
                ProjectId = reader.GetInt64(reader.GetOrdinal("project_id")),
                ClientId = reader["client_id"] as long?,
                FreelancerId = reader["freelancer_id"] as long?,
                Title = reader["title"] as string,
                Description = reader["description"] as string,
                Budget = reader["budget"] as decimal?,
                Currency = reader["currency"] as string,
                Rating = reader["rating"] as decimal?,
                Deadline = reader["dead_line"] as DateTime?,
                Status = reader["status"] as string,
                StartDate = reader["start_date"] as long?,
                EndDate = reader["end_date"] as long?,
                Completed = reader["completed"] as bool?,
                ClientRating = reader["client_rating"] as decimal?,
                ClientReview = reader["client_review"] as string,
                CreatedAt = reader.GetInt64(reader.GetOrdinal("created_at")),
                UpdatedAt = reader.GetInt64(reader.GetOrdinal("updated_at")),
                Version = reader["version"] as int?
            };
        }
    }

}