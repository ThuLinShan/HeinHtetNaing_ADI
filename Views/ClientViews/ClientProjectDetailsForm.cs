using HeinHtetNaing_ADI.Models;
using HeinHtetNaing_ADI.Services;

namespace HeinHtetNaing_ADI.Views.ClientViews
{
    public partial class ClientProjectDetailsForm : Form
    {
        private long _projectId;
        private Project _project;
        private Client _client;
        private ProjectService _projectService;
        private ClientService _clientService;
        private BidService _bidService;
        private List<Bid> _bidList;

        public ClientProjectDetailsForm(long projectId)
        {
            _projectId = projectId;
            _clientService = new ClientService();
            _bidService = new BidService();
            _projectService = new ProjectService();
            _project = _projectService.GetProjectById(projectId);
            _client = _clientService.GetClientById((long)_project.ClientId);
            _bidList = _bidService.GetAllBidsByProjectId(projectId).ToList();
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
            projectDescriptionTextBox.GotFocus += (s, ev) => this.Focus();
        }

        private void ClientProjectDetailsForm_Load(object sender, EventArgs e)
        {
            clientNameLabel.Text = _client.FirstName + " " + _client.LastName;
            long epochTime = (long)_project.CreatedAt; // Assuming this is in seconds
            DateTime dateTime = DateTimeOffset.FromUnixTimeSeconds(epochTime).LocalDateTime; // Convert to local time
            projectPostedAtLabel.Text = dateTime.ToString("yyyy-MM-dd"); // Format the DateTime
            projectFreeLancerNameLabel.Text = _project.FreelancerId != null ? "Username" : "None";
            deadLineLabel.Text = _project.Deadline.ToString("yyyy-MM-dd");
            projectDescriptionTextBox.Text = _project.Description;

            if (_project.FreelancerId != null)
            {
                reviewPanel.Enabled = true;
            }

            PopulateBidsContainerPanel();
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
                    MessageBox.Show($"Freelancer Name: {currentBid.FreelancerName}\nDetails about the freelancer can be shown here.");
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
                    MessageBox.Show($"You accepted the bid from {currentBid.FreelancerName} with rate {currentBid.Rate}/hr");
                };
                bidPanel.Controls.Add(acceptBidButton);

                bidsContainerPanel.Controls.Add(bidPanel);
            }
        }

    }
}
