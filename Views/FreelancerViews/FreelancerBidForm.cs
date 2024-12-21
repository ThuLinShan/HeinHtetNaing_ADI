using HeinHtetNaing_ADI.Models;
using HeinHtetNaing_ADI.Services;

namespace HeinHtetNaing_ADI.Views.FreelancerViews
{
    public partial class FreelancerBidForm : Form
    {

        Freelancer _freelancer;
        Project _project;
        BidService _bidService;

        public FreelancerBidForm(Project project, Freelancer freelancer)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            _project = project;
            _freelancer = freelancer;
            _bidService = new BidService();
            LoadRateTypeComboBoxItems();
        }

        private void FreelancerBidForm_Load(object sender, EventArgs e)
        {
            // Set project details with null-safe checks
            projectTitleLabel.Text = _project?.Title ?? "N/A";
            projectDeadlineLabel.Text = _project?.Deadline.ToString("yyyy-MM-dd") ?? "N/A";
            projectBudgetLabel.Text = _project?.Budget.ToString() + " /" + (_project?.Currency ?? "N/A");
        }

        private void LoadRateTypeComboBoxItems()
        {
            rateTypeComboBox.DataSource = null; // Clears any existing data binding

            var rateTypeItems = new List<KeyValuePair<string, string>>
            {
                new KeyValuePair<string, string>("Fixed", "Fixed"),
                new KeyValuePair<string, string>("Hourly", "Hourly"),
                new KeyValuePair<string, string>("Daily", "Daily"),
                new KeyValuePair<string, string>("Weekly", "Weekly"),
                new KeyValuePair<string, string>("Monthly", "Monthly")
            };

            rateTypeComboBox.DisplayMember = "Key";
            rateTypeComboBox.ValueMember = "Value";
            rateTypeComboBox.DataSource = rateTypeItems;
            rateTypeComboBox.SelectedIndex = 0; // Default selection
        }


        private void confirmBidButton_Click(object sender, EventArgs e)
        {
            if (!decimal.TryParse(rateTextBox?.Text, out decimal rate))
            {
                MessageBox.Show("Please enter a valid rate.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            String rateType = rateTypeComboBox?.SelectedValue?.ToString();
            if (string.IsNullOrEmpty(rateType))
            {
                MessageBox.Show("Please select a valid rate type." + rateType, "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string comment = commentTextBox.Text ?? string.Empty;

            Bid bid = new Bid(
                _project.ProjectId,
                _freelancer.FreelancerId,
                _freelancer.FirstName + " " + _freelancer.LastName,
                rate,
                rateType,
                "PENDING",
                comment);
            MessageBox.Show(
                $"Your bid has been submitted successfully!\n\nRate: {rate}\nRate Type: {rateType}",
                "Success",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
            _bidService.AddBid(bid);
            this.Close();

        }


        private void rateTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow control characters (backspace, etc.)
            if (char.IsControl(e.KeyChar)) { return; }

            // Allow digits (0-9)
            if (char.IsDigit(e.KeyChar)) { return; }

            // Allow one decimal point
            if (e.KeyChar == '.' && !((TextBox)sender).Text.Contains(".")) { return; }

            // If we reach here, the character is not allowed
            e.Handled = true;
        }
    }
}
