using HeinHtetNaing_ADI.Models;
using HeinHtetNaing_ADI.Services;

namespace HeinHtetNaing_ADI.Views.FreelancerViews
{
    public partial class FreelancerDashboardForm : Form
    {
        private Freelancer _freelancer;
        private FreelancerService _freelancerService;
        private ProjectService _projectService;
        private ClientService _clientService;
        List<Project> _ongoingProjects;
        List<Project> _completedProjects;
        public FreelancerDashboardForm(Freelancer freelancer)
        {
            _freelancer = freelancer;
            _freelancerService = new FreelancerService();
            _projectService = new ProjectService();
            _clientService = new ClientService();
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
        }
        private void FreelancerDashboardForm_Load(object sender, EventArgs e)
        {
            _ongoingProjects = _projectService
                .GetOngoingProjectsByFreelancerId(_freelancer.FreelancerId)
                .ToList();
            _completedProjects = _projectService
                .GetAllCompletedProjectsByFreelancer(_freelancer.FreelancerId);
            ongoingProjectCountLabel.Text = _ongoingProjects.Count.ToString();
            completedProjectCountLabel.Text = _completedProjects.Count.ToString();
            LoadOngoingProjects();
            LoadCompletedProjects();
        }

        private void LoadOngoingProjects()
        {
            ongoingProjectsContainer.Controls.Clear();
            int yOffset = 0; // Vertical offset for stacking child controls

            // Loop through the list of ongoing projects
            for (int i = 0; i < _ongoingProjects.Count; i++)
            {
                var project = _ongoingProjects[i]; // Get the project data

                // Create the parent panel for a project
                Panel ongoingProject = new Panel
                {
                    BackColor = Color.Salmon,
                    Location = new Point(3, yOffset),
                    Name = $"ongoingProject{i}",
                    Size = new Size(554, 267),
                    TabIndex = i
                };

                // Project Title Label
                Label projectTitleLabel = new Label
                {
                    AutoSize = true,
                    Font = new Font("Segoe UI", 14.25F, FontStyle.Bold),
                    ForeColor = Color.Yellow,
                    Location = new Point(32, 23),
                    Name = $"projectTitleLabel{i}",
                    Text = project.Title // Set from project data
                };
                ongoingProject.Controls.Add(projectTitleLabel);

                // Labels and other controls
                Label label3 = CreateLabel($"label3{i}", "Started At :", new Point(32, 63), Color.White);
                ongoingProject.Controls.Add(label3);

                Label label4 = CreateLabel($"label4{i}", "Status :", new Point(32, 96), Color.White);
                ongoingProject.Controls.Add(label4);

                Label label5 = CreateLabel($"label5{i}", "Deadline :", new Point(32, 129), Color.White);
                ongoingProject.Controls.Add(label5);

                Label label6 = CreateLabel($"label6{i}", "Client Info", new Point(32, 173), Color.Yellow, true);
                ongoingProject.Controls.Add(label6);

                Label label7 = CreateLabel($"label7{i}", "Name :", new Point(32, 204), Color.White);
                ongoingProject.Controls.Add(label7);

                string startDate = project?.StartDate != null &&
                    long.TryParse(project.StartDate.ToString(), out var startDateEpoch) && startDateEpoch >= 0 ?
                    DateTimeOffset.FromUnixTimeSeconds(startDateEpoch).LocalDateTime.ToString("yyyy-MM-dd")
                    : "NA";

                Client client = _clientService.GetClientById((long)project.ClientId);

                Label projectClientNameLabel = CreateLabel(
                    $"projectClientNameLabel{i}",
                    client.FirstName + " " + client.LastName,
                    new Point(122, 204), Color.White);

                ongoingProject.Controls.Add(projectClientNameLabel);

                Label projectStatedAtLabel = CreateLabel($"projectStatedAtLabel{i}", startDate, new Point(280, 63), Color.White);
                ongoingProject.Controls.Add(projectStatedAtLabel);

                // ComboBox for status
                ComboBox comboBox1 = new ComboBox
                {
                    BackColor = Color.LightCoral,
                    DropDownStyle = ComboBoxStyle.DropDownList,
                    Font = new Font("Segoe UI", 11.25F),
                    FormattingEnabled = true,
                    Location = new Point(280, 93),
                    Name = $"comboBox1{i}",
                    Size = new Size(200, 28)
                };

                // Populate the ComboBox with status options
                var statusItems = new List<KeyValuePair<string, string>>
        {
            new KeyValuePair<string, string>("Ongoing", "Ongoing"),
            new KeyValuePair<string, string>("Completed", "Completed")
        };

                comboBox1.DisplayMember = "Key";
                comboBox1.ValueMember = "Value";
                comboBox1.DataSource = statusItems;

                // Set the selected status based on the project data
                comboBox1.SelectedItem = statusItems.FirstOrDefault(x => x.Value == project.Status);

                ongoingProject.Controls.Add(comboBox1);

                // DateTimePicker for deadline
                DateTimePicker projectDeadlineDateTimePicker = new DateTimePicker
                {
                    CalendarFont = new Font("Segoe UI", 11.25F),
                    CalendarMonthBackground = Color.LightCoral,
                    CalendarTitleBackColor = Color.LightCoral,
                    Location = new Point(280, 129),
                    Name = $"projectDeadlineDateTimePicker{i}",
                    Size = new Size(200, 23),
                    Value = project.Deadline // Set from project data
                };
                ongoingProject.Controls.Add(projectDeadlineDateTimePicker);

                // Update button
                Button projectUpdateButton = new Button
                {
                    BackColor = Color.Tomato,
                    FlatStyle = FlatStyle.Flat,
                    Font = new Font("Segoe UI", 12F),
                    ForeColor = Color.White,
                    Location = new Point(284, 184),
                    Name = $"projectUpdateButton{i}",
                    Size = new Size(196, 40),
                    Text = "Update",
                    UseVisualStyleBackColor = false,
                    Tag = project.ProjectId // Attach the project ID for easy access
                };

                projectUpdateButton.Click += (s, e) =>
                    UpdateProjectClick(
                        project.ProjectId, (string)comboBox1.SelectedValue, // Use the selected value for status
                        projectDeadlineDateTimePicker.Value,
                        s,
                        e
                    );
                ongoingProject.Controls.Add(projectUpdateButton);

                // Add the panel to the container
                ongoingProjectsContainer.Controls.Add(ongoingProject);

                // Update yOffset for the next panel
                yOffset += ongoingProject.Height + 10; // Add spacing between panels
            }
        }

        private void LoadCompletedProjects()
        {
            completedProjectContainer.Controls.Clear(); // Clear existing controls

            int yOffset = 0; // Vertical offset for placing panels
            foreach (var project in _completedProjects)
            {
                Client client = _clientService.GetClientById((long)project.ClientId);
                string clientName = client != null
                    ? $"{client.FirstName} {client.LastName}"
                    : "Unknown Client";

                // Create the completed project panel
                var completedProject = new Panel
                {
                    BackColor = Color.PaleTurquoise,
                    Location = new Point(3, yOffset),
                    Name = $"completedProject_{project.ProjectId}",
                    Size = new Size(555, 215),
                    TabIndex = 0
                };
                // Add controls to the completed project panel
                completedProject.Controls.Add(CreateLabel(project.Title, new Point(34, 23),
                    $"titleLabel_{project.ProjectId}",
                    new Font("Segoe UI", 14.25F, FontStyle.Bold)));

                completedProject.Controls.Add(CreateLabel(
                    $"Started At: {DateTimeOffset.FromUnixTimeSeconds((long)project.StartDate).LocalDateTime:yyyy-MM-dd}",
                    new Point(34, 67),
                    $"startedAtLabel_{project.ProjectId}"
                ));

                completedProject.Controls.Add(CreateLabel(
                    $"Ended At: {DateTimeOffset.FromUnixTimeSeconds((long)project.EndDate).LocalDateTime:yyyy-MM-dd}",
                    new Point(34, 101),
                    $"endedAtLabel_{project.ProjectId}"
                ));

                completedProject.Controls.Add(CreateLabel(
                    $"Client Name: {clientName}",
                    new Point(34, 132),
                    $"clientNameLabel_{project.ProjectId}"
                ));

                // Conditional Rating Check
                string clientRatingText = project.Rating > 0
                    ? $"{string.Format("{0:0.#}", project.Rating)}/5"
                    : " NA /5";

                completedProject.Controls.Add(CreateLabel(
                    $"Rating: {clientRatingText}",
                    new Point(34, 161),
                    $"ratingLabel_{project.ProjectId}"
                ));

                completedProject.Controls.Add(CreateLabel(
                    "Client Comment:",
                    new Point(296, 27),
                    $"clientCommentLabel_{project.ProjectId}"
                ));

                completedProject.Controls.Add(CreateTextBox(
                    project.ClientReview ?? "No comment provided",
                    new Point(296, 50),
                    $"commentTextBox_{project.ProjectId}",
                    new Size(233, 131)
                ));

                // Add the completed project panel to the container
                completedProjectContainer.Controls.Add(completedProject);

                // Increment the offset for the next project
                yOffset += completedProject.Height + 10; // Add spacing between projects
            }
        }


        private Label CreateLabel(string text, Point location, string name, Font font = null)
        {
            return new Label
            {
                AutoSize = true,
                Font = font ?? new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0),
                ForeColor = Color.DarkRed,
                Location = location,
                Name = name,
                Text = text
            };
        }

        private TextBox CreateTextBox(string text, Point location, string name, Size size)
        {
            return new TextBox
            {
                BackColor = Color.PaleTurquoise,
                Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0),
                ForeColor = Color.DarkRed,
                Location = location,
                Multiline = true,
                Name = name,
                ReadOnly = true,
                Size = size,
                Text = text
            };
        }


        private void UpdateProjectClick(long projectId, string status, DateTime deadline, object sender, EventArgs e)
        {
            Project project = _projectService.GetProjectById(projectId);

            if (status == "Completed")
            {
                project.Finished();
            }
            project.Deadline = deadline;
            _projectService.UpdateProject(project);
            FreelancerDashboardForm_Load(sender, e);
            LoadOngoingProjects();

            MessageBox.Show($"Project updated successfully");
        }


        // Helper method to create labels dynamically
        private Label CreateLabel(string name, string text, Point location, Color foreColor, bool isBold = false)
        {
            return new Label
            {
                AutoSize = true,
                Font = new Font("Segoe UI", isBold ? 14.25F : 11.25F, isBold ? FontStyle.Bold : FontStyle.Regular),
                ForeColor = foreColor,
                Location = location,
                Name = name,
                Text = text
            };
        }
    }
}
