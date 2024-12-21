using HeinHtetNaing_ADI.Models;
using HeinHtetNaing_ADI.Services;

namespace HeinHtetNaing_ADI.Views.ClientViews
{
    public partial class ClientProjectDetailsForm : Form
    {
        private long _projectId;
        private Project _project;
        private Client _client;
        private FreelancerService _freelancerService;
        private ProjectService _projectService;
        private ClientService _clientService;
        private BidService _bidService;
        private List<Bid> _bidList;

        public ClientProjectDetailsForm(long projectId)
        {
            _projectId = projectId;
            _clientService = new ClientService();
            _freelancerService = new FreelancerService();
            _bidService = new BidService();
            _projectService = new ProjectService();
            _projectId = projectId;
            _bidList = _bidService.GetAllBidsByProjectId(projectId).ToList();
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
            projectDescriptionTextBox.GotFocus += (s, ev) => this.Focus();
        }

        private void ClientProjectDetailsForm_Load(object sender, EventArgs e)
        {
            // Load project and client details
            _project = _projectService.GetProjectById(_projectId);
            _client = _clientService.GetClientById((long)_project.ClientId);
            clientNameLabel.Text = $"{_client.FirstName} {_client.LastName}";

            // Convert epoch time to DateTime
            long epochTime = (long)_project.CreatedAt; // Assuming this is in seconds
            DateTime dateTime = DateTimeOffset.FromUnixTimeSeconds(epochTime).LocalDateTime;
            projectPostedAtLabel.Text = dateTime.ToString("yyyy-MM-dd");

            // Update UI with project details
            projectFreeLancerNameLabel.Text = _project.FreelancerId != null ? "Username" : "None";
            deadLineLabel.Text = _project.Deadline.ToString("yyyy-MM-dd");
            projectDescriptionTextBox.Text = _project.Description;
            projectTitleLabel.Text = _project.Title;

            projectStartDateLabel.Text =
                _project?.StartDate != null && long.TryParse(_project.StartDate.ToString(), out var startDateEpoch) &&
                startDateEpoch >= 0
                    ? DateTimeOffset.FromUnixTimeSeconds(startDateEpoch).LocalDateTime.ToString("yyyy-MM-dd")
                    : "NA";

            projectEndDateLabel.Text =
                _project?.EndDate != null && long.TryParse(_project.EndDate.ToString(), out var endDateEpoch) &&
                endDateEpoch >= 0
                    ? DateTimeOffset.FromUnixTimeSeconds(endDateEpoch).LocalDateTime.ToString("yyyy-MM-dd")
                    : "NA";


            // Load total bids
            totalBidLabel.Text = $"Total bids: {_bidList.Count}";

            // Update status labels and related panels
            UpdateStatusLabel(statusPendingLabel, _project.Status == "Pending", Color.DarkRed, Color.Transparent, _project.Status == "Pending", bidsContainerPanel);
            UpdateStatusLabel(statusOngoingLabel, _project.Status == "Ongoing", Color.DarkRed, Color.Transparent);
            UpdateStatusLabel(statusCompletedLabel, _project.Status == "Completed", Color.DarkRed, Color.Transparent, _project.Status == "Completed", reviewPanel);

            if (_project.Status == "Completed")
            {
                projectRatingNumericUpDown.Value = _project.Rating.HasValue ? (decimal)_project.Rating : 0; // Default to 0 if Rating is null
                projectReviewTextBox.Text = !string.IsNullOrWhiteSpace(_project.ClientReview) ?
                    _project.ClientReview :
                    string.Empty; // Default to empty string if ClientReview is null or whitespace
            }

            // Populate bids container panel
            PopulateBidsContainerPanel();
        }

        private void saveProjectReviewButton_Click(object sender, EventArgs e)
        {
            decimal rating = projectRatingNumericUpDown.Value > 0 ? projectRatingNumericUpDown.Value : 0; // Default to 0 if no value is set
            string comment = !string.IsNullOrWhiteSpace(projectReviewTextBox.Text) ? projectReviewTextBox.Text : string.Empty; // Default to empty string if null or whitespace

            _project.Rating = rating;
            _project.ClientReview = comment;

            _projectService.UpdateProject(_project);
            MessageBox.Show("Project review is saved");
            ClientProjectDetailsForm_Load(sender, e);
        }

        private void projectRatingNumericUpDown_ValueChanged(object sender, EventArgs e)
        {

        }

        private void PopulateBidsContainerPanel()
        {
            bidsContainerPanel.Controls.Clear();
            const int panelSpacing = 265; // Space between panels

            for (int i = 0; i < _bidList.Count; i++)
            {
                Bid currentBid = _bidList[i]; // Capture the current bid in a separate variable

                Panel bidPanel = new Panel
                {
                    BackColor = Color.MistyRose,
                    BorderStyle = BorderStyle.FixedSingle,
                    Size = new System.Drawing.Size(300, 245), // Adjust height to fit two buttons
                    Location = new System.Drawing.Point(10, i * panelSpacing),
                    Name = $"bidPanel{i + 1}"
                };

                Label label = new Label
                {
                    Text = $"Bid by:",
                    Location = new System.Drawing.Point(3, 17),
                    AutoSize = true,
                    Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold),
                    ForeColor = Color.IndianRed,
                    Name = $"label{i + 1}"
                };
                bidPanel.Controls.Add(label);

                Label bidRateLabel = new Label
                {
                    Text = $"{currentBid.Rate}/hr",
                    Location = new System.Drawing.Point(231, 59),
                    AutoSize = true,
                    Font = new Font("Segoe UI", 9.75F),
                    Name = $"bidRateLabel{i + 1}"
                };
                bidPanel.Controls.Add(bidRateLabel);

                Label rateLabel = new Label
                {
                    Text = "Rate: ",
                    Location = new System.Drawing.Point(183, 59),
                    AutoSize = true,
                    Font = new Font("Segoe UI", 9.75F),
                    Name = $"rateLabel{i + 1}"
                };
                bidPanel.Controls.Add(rateLabel);

                TextBox bidCommentTextBox = new TextBox
                {
                    Text = currentBid.Comment,
                    Location = new System.Drawing.Point(3, 88),
                    Size = new System.Drawing.Size(290, 107),
                    Multiline = true,
                    BackColor = Color.MistyRose,
                    Name = $"bidCommentTextBox{i + 1}",
                    ReadOnly = true
                };
                bidPanel.Controls.Add(bidCommentTextBox);

                // Freelancer Details Button
                Button freelancerDetailsButton = new Button
                {
                    AutoSize = true,
                    BackColor = Color.IndianRed,
                    FlatStyle = FlatStyle.Flat,
                    Font = new Font("Segoe UI", 11.25F, FontStyle.Underline, GraphicsUnit.Point, 0),
                    ForeColor = SystemColors.Control,
                    Location = new Point(150, 11),
                    Name = $"freelancerDetailsButton{i + 1}",
                    Size = new Size(133, 32),
                    TabIndex = 2,
                    Text = currentBid.FreelancerName,
                    UseVisualStyleBackColor = false
                };
                freelancerDetailsButton.Click += (sender, e) =>
                {
                    Freelancer freelancer = _freelancerService.GetFreelancerById((long)currentBid.FreelancerId);
                    Form freelancerDetailsForm = new ClientFreelancerDetailsForm(freelancer);
                    freelancerDetailsForm.FormClosed += (s, args) =>
                    {
                        // Reload the form or refresh the contents here
                        this.ClientProjectDetailsForm_Load(sender, e);
                    };
                    freelancerDetailsForm.ShowDialog();
                };
                bidPanel.Controls.Add(freelancerDetailsButton);

                // Accept Bid Button
                Button acceptBidButton = new Button
                {
                    Text = "Accept",
                    BackColor = Color.IndianRed,
                    ForeColor = SystemColors.Control,
                    Font = new Font("Segoe UI", 12F, FontStyle.Regular),
                    Location = new System.Drawing.Point(3, 201),
                    Size = new System.Drawing.Size(290, 41),
                    Name = $"acceptBidButton{i + 1}"
                };

                // Inline Click Event Handler with captured `currentBid`
                acceptBidButton.Click += (sender, e) =>
                {
                    _bidService.AcceptBid(currentBid);
                    _project.Accepted((long)currentBid.FreelancerId);
                    _projectService.UpdateProject(_project);
                    this.ClientProjectDetailsForm_Load(sender, e);
                    MessageBox.Show($"You accepted the bid from {currentBid.FreelancerName} with rate {currentBid.Rate}/hr");
                };
                bidPanel.Controls.Add(acceptBidButton);

                bidsContainerPanel.Controls.Add(bidPanel);
            }
        }
        private void UpdateStatusLabel(Label label, bool isActive, Color activeBackColor, Color inactiveBackColor, bool enablePanel = false, Panel panel = null)
        {
            label.ForeColor = isActive ? Color.White : Color.Gray;
            label.BackColor = isActive ? activeBackColor : inactiveBackColor;

            // Add 3D border for active labels
            label.BorderStyle = isActive ? BorderStyle.Fixed3D : BorderStyle.None;
            label.FlatStyle = isActive ? FlatStyle.Popup : FlatStyle.Standard;

            if (panel != null)
            {
                panel.Enabled = enablePanel;
            }
        }

    }
}
