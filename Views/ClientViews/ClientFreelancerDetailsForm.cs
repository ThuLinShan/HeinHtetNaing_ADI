using HeinHtetNaing_ADI.Models;
using HeinHtetNaing_ADI.Services;

namespace HeinHtetNaing_ADI.Views.ClientViews
{
    public partial class ClientFreelancerDetailsForm : Form
    {

        Freelancer _freelancer;
        ProjectService _projectService;
        ClientService _clientService;
        List<Project> _projects;

        public ClientFreelancerDetailsForm(Freelancer freelancer)
        {
            _freelancer = freelancer;
            _clientService = new ClientService();
            _projectService = new ProjectService();
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void ClientFreelancerDetailsForm_Load(object sender, EventArgs e)
        {
            _projects = _projectService.GetAllCompletedProjectsByFreelancer(_freelancer.FreelancerId);

            freelancerFIrstNameLabel.Text = _freelancer.FirstName ?? string.Empty;
            freelancerLastnameLabel.Text = _freelancer.LastName ?? string.Empty;
            freelancerEmailLabel.Text = _freelancer.Email ?? string.Empty;
            freelancerPhoneNoLabel.Text = _freelancer.PhoneNo ?? string.Empty;
            // Loop through the Skills list and concatenate each skill's name and level
            freelancerSkillsLabel.Text = _freelancer.Skills != null && _freelancer.Skills.Any()
                ? string.Join(", ", _freelancer.Skills.Select(skill => $"{skill.SkillName ?? string.Empty} ({skill.SkillLevel ?? string.Empty})"))
                : string.Empty;

            freelancerWebisteLabel.Text = _freelancer.WebsiteLink ?? string.Empty;
            freelancerExpertiseLabel.Text = _freelancer.Expertise ?? string.Empty;

            AddProjectPanels(_projects);
        }

        void AddProjectPanels(List<Project> completedProjects)
        {
            completedProjectsContainer.Controls.Clear();
            int yOffset = 10; // Initial vertical offset for the first panel

            foreach (var project in completedProjects)
            {
                Panel projectPanel = new Panel
                {
                    BackColor = Color.IndianRed,
                    Size = new Size(513, 142),
                    Location = new Point(3, yOffset) // Set vertical offset
                };

                // Add controls to projectPanel
                Label projectTitle = new Label
                {
                    AutoSize = true,
                    Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold),
                    ForeColor = Color.White,
                    Location = new Point(16, 8),
                    Name = "projectTitle",
                    Text = project.Title
                };
                projectPanel.Controls.Add(projectTitle);

                Label label9 = new Label
                {
                    AutoSize = true,
                    Font = new Font("Segoe UI", 11.25F, FontStyle.Regular),
                    ForeColor = Color.White,
                    Location = new Point(16, 64),
                    Name = "label9",
                    Text = "Rating : "
                };
                projectPanel.Controls.Add(label9);

                Label projectRatingLabel = new Label
                {
                    AutoSize = true,
                    Font = new Font("Segoe UI", 11.25F, FontStyle.Regular),
                    ForeColor = Color.White,
                    Location = new Point(89, 64),
                    Name = "projectRatingLabel",
                    Text = project.Rating.ToString()
                };
                projectPanel.Controls.Add(projectRatingLabel);

                Label label11 = new Label
                {
                    AutoSize = true,
                    Font = new Font("Segoe UI", 11.25F, FontStyle.Regular),
                    ForeColor = Color.White,
                    Location = new Point(16, 98),
                    Name = "label11",
                    Text = "Client : "
                };
                projectPanel.Controls.Add(label11);

                Client client = _clientService.GetClientById((long)project.ClientId);
                Label projectClientnameLabel = new Label
                {
                    AutoSize = true,
                    Font = new Font("Segoe UI", 11.25F, FontStyle.Regular),
                    ForeColor = Color.White,
                    Location = new Point(89, 98),
                    Name = "projectClientnameLabel",
                    Text = client.FirstName + " " + client.LastName,
                };
                projectPanel.Controls.Add(projectClientnameLabel);

                TextBox projectReviewTextBox = new TextBox
                {
                    BackColor = Color.IndianRed,
                    ForeColor = Color.Yellow,
                    BorderStyle = BorderStyle.None,
                    Font = new Font("Segoe UI", 11.25F, FontStyle.Regular),
                    Location = new Point(226, 8),
                    Multiline = true,
                    Name = "projectReviewTextBox",
                    ReadOnly = true,
                    Size = new Size(266, 119),
                    Text = "Client Review : " + project.ClientReview
                };
                projectPanel.Controls.Add(projectReviewTextBox);

                // Add projectPanel to the container
                completedProjectsContainer.Controls.Add(projectPanel);

                // Update vertical offset for next panel
                yOffset += projectPanel.Height + 10; // Add a margin of 10px between panels
            }
        }
    }
}
