using HeinHtetNaing_ADI.Models;
using HeinHtetNaing_ADI.Services;

namespace HeinHtetNaing_ADI.Views.ClientViews
{
    public partial class ClientSignUpForm : Form
    {

        private readonly ClientService _clientService;
        private Form _siginForm;

        public ClientSignUpForm(Form siginForm)
        {
            _clientService = new ClientService();
            InitializeComponent();
            _siginForm = siginForm;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.KeyPreview = true;
        }

        private void ClientSignUpForm_Load(object sender, EventArgs e)
        {
            //False Click
        }

        #region Sign Up Action
        private void signupButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(firstNameTextBox.Text) ||
                string.IsNullOrWhiteSpace(lastNameTextBox.Text) ||
                string.IsNullOrWhiteSpace(emailTextBox.Text) ||
                string.IsNullOrWhiteSpace(passwordTextBox.Text) ||
                string.IsNullOrWhiteSpace(addressTextBox.Text) ||
                string.IsNullOrWhiteSpace(phoneNumberTextBox.Text))
            {
                MessageBox.Show(
                    "Please enter all the inputs",
                    "Validation Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            // Password validation: between 8 and 12 characters, with at least one lowercase and one uppercase letter
            string inputPassword = passwordTextBox.Text;
            if (inputPassword.Length < 8 || inputPassword.Length > 12 ||
                !inputPassword.Any(char.IsLower) || !inputPassword.Any(char.IsUpper))
            {
                MessageBox.Show(
                    "Password must be between 8 and 12 characters long and contain at least one lowercase and one uppercase letter.",
                    "Validation Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            if (passwordTextBox.Text != confirmPasswordTextBox.Text)
            {
                MessageBox.Show(
                "Passwords do not match.",
                "Validation Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
                return;
            }

            Client clientWithExistingEmail = this._clientService.FindClientByEmail(emailTextBox.Text);

            if (clientWithExistingEmail != null)
            {
                MessageBox.Show(
                    "A client with email " + emailTextBox.Text + " address already exists.",
                    "Validation Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            Client client = new Client(
                firstNameTextBox.Text,
                lastNameTextBox.Text,
                emailTextBox.Text,
                passwordTextBox.Text,
                addressTextBox.Text,
                phoneNumberTextBox.Text);

            this._clientService.AddClient(client);

            this.Close();
            _siginForm.Show();
        }
        #endregion

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close();
            _siginForm.Show();
        }

        private void ClientSignUpForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            _siginForm.Show();
        }

        private void ClientSignUpForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.signupButton_Click(sender, e);
            }
        }
    }
}
