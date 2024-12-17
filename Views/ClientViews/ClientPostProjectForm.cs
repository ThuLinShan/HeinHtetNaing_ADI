using HeinHtetNaing_ADI.Models;
using HeinHtetNaing_ADI.Services;

namespace HeinHtetNaing_ADI.Views.ClientViews
{
    public partial class ClientPostProjectForm : Form
    {

        private ProjectService _projectService;
        private long _clientId;

        public ClientPostProjectForm(long clientId)
        {
            _clientId = clientId;
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
            LoadComboBoxItems();
            projectBudgetLabel.KeyPress += new KeyPressEventHandler(projectBudgetTextBox_KeyPress);
            _projectService = new ProjectService();
        }
        private void LoadComboBoxItems()
        {
            var items = new List<KeyValuePair<string, string>>
            {
                new KeyValuePair<string, string>("£ GBP", "GBP"),
                new KeyValuePair<string, string>("$ USD", "USD")
            };
            projectCurrencyComboBox.DisplayMember = "Key"; projectCurrencyComboBox.ValueMember = "Value";
            projectCurrencyComboBox.DataSource = items;
        }

        private void ClientPostProjectForm_Load(object sender, EventArgs e)
        {
            // False click
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void clearStartDateButton_Click(object sender, EventArgs e)
        {
            this.startDateTimePicker.CustomFormat = " ";
            startDateTimePicker.Value = DateTime.Now;

        }

        private void startDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            this.startDateTimePicker.CustomFormat = "dd/MM/yyyy";
        }

        private void projectBudgetTextBox_KeyPress(object sender, KeyPressEventArgs e)
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

        #region postProject
        private void postProjectButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(projectTitleTextBox.Text) ||
                string.IsNullOrWhiteSpace(projectDescriptionTextBox.Text) ||
                string.IsNullOrWhiteSpace(skillTagTextBox.Text) ||
                string.IsNullOrWhiteSpace(projectBudgetTextBox.Text) ||
                projectCurrencyComboBox.SelectedValue == null ||
                deadLineDateTimePicker.CustomFormat == " ")
            {
                MessageBox.Show
                    (
                    "Please enter all the inputs",
                    "Validation Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                    );
                return;
            }
            String projectTitle = projectTitleTextBox.Text;
            String projectDescription = projectDescriptionTextBox.Text;
            String skillTag = skillTagTextBox.Text;
            decimal budget = Convert.ToDecimal(projectBudgetTextBox.Text);
            String currency = projectCurrencyComboBox.SelectedValue.ToString();
            DateTime deadLine = deadLineDateTimePicker.Value;
            long startDateEpoch = 0;
            if (startDateTimePicker.CustomFormat != " ")
            {

                DateTime selectedDate = startDateTimePicker.Value;
                TimeZoneInfo localZone = TimeZoneInfo.Local;
                DateTimeOffset dateTimeOffset = new DateTimeOffset(selectedDate, localZone.GetUtcOffset(selectedDate));
                startDateEpoch = dateTimeOffset.ToUnixTimeSeconds();
            }

            skillTag = skillTagTextBox.Text;

            // Convert the string into a list of strings
            List<string> skillTagList = skillTag
                .Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries) // Split by comma
                .Select(tag => tag.Trim()) // Remove any leading/trailing spaces
                .ToList();

            Project project = new Project
                (_clientId,
                projectTitle,
                projectDescription,
                skillTagList,
                budget,
                currency,
                deadLine,
                startDateEpoch
                );
            _projectService.AddProject(project);

            this.Close();
        }
        #endregion

    }
}
