using HeinHtetNaing_ADI.Models;
using HeinHtetNaing_ADI.Services;

namespace HeinHtetNaing_ADI.Views.ClientViews
{
    public partial class ClientHomeForm : Form
    {

        private Form _welcomeForm;
        private List<Project> _projects;
        private ProjectService _projectService;
        private long _clientId;

        public ClientHomeForm(Form welcomeForm, long clientId)
        {
            _clientId = clientId;
            this.StartPosition = FormStartPosition.CenterScreen;
            this._welcomeForm = welcomeForm;
            _projectService = new ProjectService();
            InitializeComponent();
        }
        private void ClientHomeForm_Load(object sender, EventArgs e)
        {
            _projects = _projectService.GetAllProjects().ToList();
            LoadProjects();
        }

        private void ClientHomeForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            _welcomeForm.Show();
            _welcomeForm.Close();
        }

        private void postProjectButton_Click(object sender, EventArgs e)
        {
            Form postProjectForm = new ClientPostProjectForm(_clientId);
            postProjectForm.FormClosed += (s, args) =>
            {
                // Reload the form or refresh the contents here
                this.ClientHomeForm_Load(sender, e);
            };
            postProjectForm.ShowDialog();
        }

        private void projectBudgetLabel_Click(object sender, EventArgs e)
        {
            //False click
        }
        private void LoadProjects()
        {
            // Clear any existing panels before adding new ones
            projectContainerPanel.Controls.Clear();

            // Loop through each project in _projects
            // Loop through the list of projects
            foreach (var project in _projects)
            {
                // Create a new panel for each project
                var projectPanel = new Panel
                {
                    BackColor = Color.White,
                    Size = new Size(802, 152), // Set the size of the project panel
                    Location = new Point(22, 160 * projectContainerPanel.Controls.Count), // Position below previous panels (with a gap)
                    Name = $"projectPanel_{project.ProjectId}", // Dynamically set the name based on the ProjectId
                };

                // Create and set the ProjectTitleLabel
                var projectTitleLabel = new Label
                {
                    Text = project.Title,
                    Font = new Font("Segoe UI", 14.25F, FontStyle.Bold | FontStyle.Underline),
                    ForeColor = Color.DarkRed,
                    Location = new Point(13, 13),
                    AutoSize = true,
                    Name = "projectTitleLabel",
                };
                projectPanel.Controls.Add(projectTitleLabel);

                // Create and set the ProjectDescriptionTextBox
                var projectDescriptionTextBox = new TextBox
                {
                    Text = project.Description,
                    Font = new Font("Segoe UI", 11.25F, FontStyle.Regular),
                    Location = new Point(211, 18),
                    Size = new Size(575, 120),
                    Multiline = true,
                    ReadOnly = true,
                    Name = "projectDescriptionTextBox"
                };
                projectPanel.Controls.Add(projectDescriptionTextBox);

                // Create and set the ProjectDetailsButton
                var projectDetailsButton = new Button
                {
                    Text = "Details",
                    Font = new Font("Segoe UI", 12F, FontStyle.Regular),
                    ForeColor = Color.DarkRed,
                    Location = new Point(15, 109),
                    Size = new Size(86, 29),
                    Name = "projectDetailsButton",
                };
                projectDetailsButton.Click += (sender, e) =>
                {
                    Form clientProjectDetailsForm = new ClientProjectDetailsForm(project.ProjectId);
                    clientProjectDetailsForm.FormClosed += (s, args) =>
                    {
                        // Reload the form or refresh the contents here
                        this.ClientHomeForm_Load(sender, e);
                    };
                    clientProjectDetailsForm.ShowDialog();
                };
                projectPanel.Controls.Add(projectDetailsButton);

                // Create and set the DeleteProjectButton
                var deleteProjectButton = new Button
                {
                    BackColor = Color.Red,
                    Font = new Font("Segoe UI", 12F, FontStyle.Regular),
                    ForeColor = Color.White,
                    Location = new Point(107, 109),
                    Name = $"deleteProjectButton_{project.ProjectId}", // Set a dynamic name based on ProjectId
                    Size = new Size(86, 29),
                    Text = "Delete",
                    UseVisualStyleBackColor = false,
                };
                deleteProjectButton.Click += (sender, e) =>
                {
                    DialogResult result = MessageBox.Show($"Are you sure you want to delete the project: {project.Title}?", "Delete Project", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        _projectService.DeleteProject(project.ProjectId);
                        this.ClientHomeForm_Load(sender, e);
                        MessageBox.Show($"Project {project.Title} deleted successfully.");
                    }
                };
                projectPanel.Controls.Add(deleteProjectButton);

                // Create and set the Budget label
                var projectBudgetLabel = new Label
                {
                    Text = project.Budget.ToString(),
                    Font = new Font("Arial", 11.25F, FontStyle.Regular),
                    ForeColor = Color.DarkRed,
                    Location = new Point(75, 80),
                    AutoSize = true,
                    Name = "projectBudgetLabel",
                };
                projectPanel.Controls.Add(projectBudgetLabel);

                // Create and set the Currency label
                var projectCurrencyLabel = new Label
                {
                    Text = project.Currency,
                    Font = new Font("Arial", 11.25F, FontStyle.Regular),
                    ForeColor = Color.White,
                    BackColor = Color.DarkRed,
                    Location = new Point(170, 80),
                    AutoSize = true,
                    Name = "projectCurrencyLabel",
                };
                projectPanel.Controls.Add(projectCurrencyLabel);

                // Create and set the Deadline label
                var projectDeadLineLabel = new Label
                {
                    Text = project.Deadline.ToString("yyyy/MM/dd"), // Format the deadline date
                    Font = new Font("Arial", 11.25F, FontStyle.Regular),
                    ForeColor = Color.DarkRed,
                    Location = new Point(107, 53),
                    AutoSize = true,
                    Name = "projectDeadLineLabel",
                };
                projectPanel.Controls.Add(projectDeadLineLabel);

                // Create and set the Label for Deadline
                var label2 = new Label
                {
                    Text = "Dead Line:",
                    Font = new Font("Arial", 11.25F, FontStyle.Regular),
                    ForeColor = Color.DarkRed,
                    Location = new Point(15, 53),
                    AutoSize = true,
                    Name = "label2",
                };
                projectPanel.Controls.Add(label2);

                // Create and set the Label for Budget
                var label1 = new Label
                {
                    Text = "Budget:",
                    Font = new Font("Arial", 11.25F, FontStyle.Regular),
                    ForeColor = Color.DarkRed,
                    Location = new Point(15, 80),
                    AutoSize = true,
                    Name = "label1",
                };
                projectPanel.Controls.Add(label1);

                // Add the projectPanel to the projectContainerPanel
                projectContainerPanel.Controls.Add(projectPanel);
            }
        }

        private void projectDetailsButton_Click(object sender, EventArgs e)
        {
            //False click
        }
    }

}

