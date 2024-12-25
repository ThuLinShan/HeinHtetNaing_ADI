using HeinHtetNaing_ADI.Models;
using HeinHtetNaing_ADI.Services;

namespace HeinHtetNaing_ADI.Views.ClientViews
{
    public partial class ClientBrowseFreelancerForm : Form
    {

        List<Freelancer> _freelancers;
        FreelancerService _freelancerService;

        public ClientBrowseFreelancerForm()
        {
            _freelancerService = new FreelancerService();
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
        }

        private void ClientBrowseFreelancerForm_Load(object sender, EventArgs e)
        {
            string keyword = this.searchFreelancerTextBox.Text;
            _freelancers = _freelancerService.BrowseFreelancers(keyword).ToList();
            loadFreelancers(_freelancers);
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            string keyword = this.searchFreelancerTextBox.Text;
            _freelancers = _freelancerService.BrowseFreelancers(keyword).ToList();
            loadFreelancers(_freelancers);
        }

        // Method to load freelancers into the freelancerContainerPanel
        private void loadFreelancers(List<Freelancer> freelancerList)
        {
            freelancerContainerPanel.Controls.Clear();  // Clear existing controls

            int xPosition = 10;  // Starting position for the panels
            int yPosition = 10;  // Starting vertical position
            int panelWidth = 560; // Width of each freelancer panel
            int panelHeight = 238; // Height of each freelancer panel
            int horizontalSpacing = 100; // Horizontal space between panels
            int verticalSpacing = 20; // Vertical space between rows of panels

            foreach (var freelancer in freelancerList)
            {
                // Create a new panel for each freelancer
                Panel freelancerPanel = new Panel
                {
                    BackColor = Color.White,
                    Size = new Size(panelWidth, panelHeight),
                    Location = new Point(xPosition, yPosition),  // Set the panel location based on xPosition and yPosition
                    Margin = new Padding(10)
                };

                // Freelancer Name Label
                freelancerPanel.Controls.Add(new Label
                {
                    Text = freelancer.FirstName + " " + freelancer.LastName,
                    Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold),
                    ForeColor = Color.DarkRed,
                    Location = new Point(10, 10)
                });

                // Construct the skills text
                var skillText = freelancer.Skills != null && freelancer.Skills.Any()
                    ? string.Join(", ", freelancer.Skills.Select(skill => $"{skill.SkillName ?? string.Empty} ({skill.SkillLevel ?? string.Empty})"))
                    : string.Empty;

                Console.WriteLine(skillText);  // Debug output

                // Create the skill label with auto-sizing
                var skillLabel = new Label
                {
                    Text = skillText,
                    Font = new Font("Segoe UI", 10F, FontStyle.Regular),
                    ForeColor = Color.DarkRed,
                    Location = new Point(10, 50),
                    AutoSize = true,  // Automatically adjust the size of the label
                    MaximumSize = new Size(panelWidth - 20, 0) // Set the maximum width for the label to avoid overflow
                };

                freelancerPanel.Controls.Add(skillLabel);

                // Adjust the panel height based on the skill label's height
                freelancerPanel.Height = Math.Max(panelHeight, skillLabel.Height + 60);  // Adjust 60 to account for other labels and margin

                // Expertise Label (adjust for wrapping and auto-sizing)
                var expertiseLabel = new Label
                {
                    Text = "Expertise: " + freelancer.Expertise,
                    Font = new Font("Segoe UI", 10F, FontStyle.Regular),
                    ForeColor = Color.DarkRed,
                    Location = new Point(10, skillLabel.Bottom + 10), // Position it after the skill label
                    AutoSize = true,  // Automatically adjust the size of the label
                    MaximumSize = new Size(panelWidth - 20, 0) // Set the maximum width for the label to avoid overflow
                };

                freelancerPanel.Controls.Add(expertiseLabel);

                // Adjust the panel height based on the expertise label's height
                freelancerPanel.Height = Math.Max(freelancerPanel.Height, expertiseLabel.Bottom + 10); // Ensure enough space for expertise label

                // Freelancer Details Button
                Button detailsButton = new Button
                {
                    Text = "Details",
                    ForeColor = Color.DarkRed,
                    Location = new Point(400, freelancerPanel.Height - 60), // Position the button near the bottom
                    Size = new Size(149, 38)
                };
                detailsButton.Click += (sender, e) =>
                {
                    Freelancer freelancerDetails = _freelancerService.GetFreelancerById(freelancer.FreelancerId);
                    Form freelancerDetailsForm = new ClientFreelancerDetailsForm(freelancerDetails);
                    freelancerDetailsForm.FormClosed += (s, args) => { this.ClientBrowseFreelancerForm_Load(sender, e); };
                    freelancerDetailsForm.ShowDialog();
                };
                freelancerPanel.Controls.Add(detailsButton);

                // Add the freelancer panel to the container panel
                freelancerContainerPanel.Controls.Add(freelancerPanel);

                // Update the xPosition for the next panel (move horizontally)
                xPosition += panelWidth + horizontalSpacing;

                // Check if the panel exceeds the container width, move to the next row
                if (xPosition + panelWidth > freelancerContainerPanel.Width)
                {
                    xPosition = 10;  // Reset x position to start a new row
                    yPosition += freelancerPanel.Height + verticalSpacing;  // Move down to the next row
                }
            }
        }


    }
}
