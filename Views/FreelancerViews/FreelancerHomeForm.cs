using HeinHtetNaing_ADI.Common.Utils;
using HeinHtetNaing_ADI.Models;
using HeinHtetNaing_ADI.Services;

namespace HeinHtetNaing_ADI.Views.FreelancerViews
{
    public partial class FreelancerHomeForm : Form
    {

        Form _welcomeForm;
        long _freelancerId;
        Freelancer _freelancer;
        FreelancerService _freelancerService;
        ProjectService _projectService;
        BidService _bidService;
        string _searchKeyword = "";
        IEnumerable<(Project Project, int TotalBids)> _projects;

        public FreelancerHomeForm(Form welcomeForm, long feelancerId)
        {
            _welcomeForm = welcomeForm;
            _freelancerId = feelancerId;
            _freelancerService = new FreelancerService();
            _projectService = new ProjectService();
            _bidService = new BidService();
            _freelancer = _freelancerService.GetFreelancerById(_freelancerId);
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void FreelancerHomeForm_Load(object sender, EventArgs e)
        {
            InitializeProjects();
            InitializeSkills();
            firstNameTextBox.Text = _freelancer.FirstName;
            lastNameTextBox.Text = _freelancer.LastName;
            emailTextBox.Text = _freelancer.Email;
            phoneNoTextBox.Text = _freelancer.PhoneNo;
        }

        private void saveProfileButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Retrieve values from the text boxes and controls
                var firstName = firstNameTextBox.Text ?? string.Empty;
                var lastName = lastNameTextBox.Text ?? string.Empty;
                var email = emailTextBox.Text ?? string.Empty;
                var phoneNo = phoneNoTextBox.Text ?? string.Empty;

                _freelancer.FirstName = firstName;
                _freelancer.LastName = lastName;
                _freelancer.Email = email;
                _freelancer.PhoneNo = phoneNo;

                // Get skills from the skillsDataGridView
                var skills = new List<Skill>();
                foreach (DataGridViewRow row in skillsDataGridView.Rows)
                {
                    if (row.IsNewRow) continue; // Skip the new row used for adding new skills

                    // Get the skillId from the row, or generate it if null
                    var skillId = row.Cells["skillId"].Value ?? GuidUtil.GenerateNewLongGuid();

                    var skillName = row.Cells["skillName"].Value?.ToString();
                    var skillLevel = row.Cells["skillLevel"].Value?.ToString();

                    // Ensure that skill name and level are not empty
                    if (!string.IsNullOrEmpty(skillName) && !string.IsNullOrEmpty(skillLevel))
                    {
                        // Ensure skill names are unique in the list
                        if (skills.Any(skill => skill.SkillName.Equals(skillName, StringComparison.OrdinalIgnoreCase)))
                        {
                            continue; // Skip if the skill name already exists
                        }

                        // Add the skill to the list
                        skills.Add(new Skill
                        {
                            SkillId = Convert.ToInt64(skillId),
                            SkillName = skillName,
                            SkillLevel = skillLevel
                        });
                    }
                }

                // Ensure at least one skill is added
                if (skills.Count == 0)
                {
                    MessageBox.Show("You must add at least one skill.");
                    return; // Stop execution if no skills are added
                }

                // Assign the list of skills to the freelancer object
                _freelancer.Skills = skills;

                // Call the update method to save the changes
                _freelancerService.UpdateFreelancer(_freelancer);

                // Reload the freelancer home form (or update the display as needed)
                FreelancerHomeForm_Load(sender, e);

                // Optionally, show a message indicating the update was successful
                MessageBox.Show("Profile updated successfully.");
            }
            catch (Exception ex)
            {
                // Handle any exceptions that occur during the save process
                MessageBox.Show($"Error: {ex.Message}");
            }
        }




        private void searchButton_Click(object sender, EventArgs e)
        {
            _searchKeyword = string.IsNullOrEmpty(searchTextBox.Text) ? null : searchTextBox.Text;
            InitializeProjects();
        }

        private void FreelancerHomeForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            _welcomeForm.Show();
            _welcomeForm.Close();
        }

        private void InitializeProjects()
        {
            // Fetch projects with totalBids
            var projectsWithBids = _projectService.BrowseProjects(_searchKeyword, _freelancerId);

            // Clear existing panels (optional, if updating dynamically)
            projectsContainerPanel.Controls.Clear();

            int panelIndex = 0;
            foreach (var (project, totalBids) in projectsWithBids)
            {
                // Create a new instance of the projectPanel
                var projectPanel = new Panel
                {
                    BackColor = Color.Tomato,
                    BorderStyle = BorderStyle.FixedSingle,
                    Size = new Size(780, 191),
                    Location = new Point(4, 4 + panelIndex * 200), // Position each panel with spacing
                    Name = $"projectPanel_{panelIndex}"
                };

                // Project Title Label
                var projectTitleLabel = new Label
                {
                    Text = project.Title,
                    Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold),
                    ForeColor = Color.DarkRed,
                    BackColor = Color.White,
                    AutoSize = true,
                    Location = new Point(3, 2),
                    Padding = new Padding(3)
                };

                // Description TextBox
                var projectDescriptionTextBox = new TextBox
                {
                    Text = project.Description,
                    BackColor = Color.Salmon,
                    BorderStyle = BorderStyle.None,
                    Font = new Font("Segoe UI", 11.25F),
                    ForeColor = Color.White,
                    Location = new Point(3, 34),
                    Multiline = true,
                    ReadOnly = true,
                    Size = new Size(542, 150)
                };

                // Project Created At Label
                var projectCreatedAtLabel = new Label
                {
                    Text = $"Posted at: {project.CreatedAt:yyyy/MM/dd}",
                    Font = new Font("Segoe UI", 9.75F),
                    ForeColor = Color.White,
                    Location = new Point(405, 5),
                    AutoSize = true
                };
                // Budget Label
                var profectBudgetLabel = new Label
                {
                    Text = $"{project.Budget} GPD",
                    Font = new Font("Segoe UI", 11.25F),
                    ForeColor = Color.White,
                    Location = new Point(640, 28), // Moved 20 pixels down
                    AutoSize = true
                };

                // Total Bids Label
                var totalBidsLabel = new Label
                {
                    Text = $"Total Bids: {totalBids}",
                    Font = new Font("Segoe UI", 11.25F),
                    ForeColor = Color.DarkRed,
                    Location = new Point(554, 5), // Moved 20 pixels down
                    AutoSize = true
                };

                var label2 = new Label
                {
                    Text = "Budget: ",
                    Font = new Font("Segoe UI", 11.25F),
                    ForeColor = Color.White,
                    Location = new Point(554, 28), // Moved 20 pixels down
                    AutoSize = true
                };

                // Deadline Label
                var projectDeadlineLabel = new Label
                {
                    Text = project.Deadline.ToString("yyyy/MM/dd"),
                    Font = new Font("Segoe UI", 11.25F),
                    ForeColor = Color.White,
                    Location = new Point(640, 55), // Moved 20 pixels down
                    AutoSize = true
                };

                var label3 = new Label
                {
                    Text = "Deadline: ",
                    Font = new Font("Segoe UI", 11.25F),
                    ForeColor = Color.White,
                    Location = new Point(554, 55), // Moved 20 pixels down
                    AutoSize = true
                };

                // Required Skills TextBox
                var projectRequiredSkillsTextBox = new TextBox
                {
                    Text = string.Join(", ", project.SkillTags),
                    BackColor = Color.DarkRed,
                    BorderStyle = BorderStyle.None,
                    Font = new Font("Segoe UI", 11),
                    ForeColor = Color.Aqua,
                    Location = new Point(551, 107), // Moved 20 pixels down
                    ReadOnly = true,
                    Size = new Size(214, 26)
                };

                var label4 = new Label
                {
                    Text = "Required Skill(s): ",
                    Font = new Font("Segoe UI", 11.25F),
                    ForeColor = Color.Yellow,
                    Location = new Point(554, 84), // Moved 20 pixels down
                    AutoSize = true
                };

                // Bid Button
                var bidButton = new Button
                {
                    Text = "Bid",
                    Font = new Font("Segoe UI", 12F),
                    ForeColor = Color.Tomato,
                    BackColor = Color.White,
                    Location = new Point(550, 139), // Moved 20 pixels down
                    Size = new Size(215, 35)
                };



                bidButton.Click += (s, e) =>
                {
                    Form freelancerBidForm = new FreelancerBidForm(project, _freelancer);
                    freelancerBidForm.FormClosed += (s, args) =>
                    {
                        // Reload the form or refresh the contents here
                        this.FreelancerHomeForm_Load(s, e);
                    };
                    freelancerBidForm.ShowDialog();
                };

                // Add controls to the panel
                projectPanel.Controls.Add(projectTitleLabel);
                projectPanel.Controls.Add(projectDescriptionTextBox);
                projectPanel.Controls.Add(projectCreatedAtLabel);
                projectPanel.Controls.Add(profectBudgetLabel);
                projectPanel.Controls.Add(label2);
                projectPanel.Controls.Add(projectDeadlineLabel);
                projectPanel.Controls.Add(label3);
                projectPanel.Controls.Add(projectRequiredSkillsTextBox);
                projectPanel.Controls.Add(label4);
                projectPanel.Controls.Add(totalBidsLabel);
                projectPanel.Controls.Add(bidButton);

                // Add the projectPanel to the projectsContainerPanel
                projectsContainerPanel.Controls.Add(projectPanel);

                panelIndex++;
            }

        }

        private void InitializeSkills()
        {
            // Clear the existing rows (if any)
            skillsDataGridView.Rows.Clear();

            // Loop through the list of skills from _freelancer.Skills
            foreach (var skill in _freelancer.Skills)
            {
                // Add a new row to the DataGridView with SkillName and SkillLevel
                skillsDataGridView.Rows.Add(
                    skill.SkillId,                 // skillId column (hidden)
                    skill.SkillName ?? string.Empty, // skillName column
                    skill.SkillLevel ?? string.Empty // skillLevel column
                );
            }

        }

        private void dashboardLinkedLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form dashboardForm = new FreelancerDashboardForm(_freelancer);
            dashboardForm.FormClosed += (s, args) =>
            {
                // Reload the form or refresh the contents here
                this.FreelancerHomeForm_Load(s, e);
            };
            dashboardForm.ShowDialog();
        }
    }
}
