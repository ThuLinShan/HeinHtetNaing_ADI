namespace HeinHtetNaing_ADI.Views.ClientViews
{
    public partial class ClientPostProjectForm : Form
    {
        public ClientPostProjectForm()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
            LoadComboBoxItems();
            projectBudgetLabel.KeyPress += new KeyPressEventHandler(projectBudgetTextBox_KeyPress);
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

        private void postProjectButton_Click(object sender, EventArgs e)
        {

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

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
