using HeinHtetNaing_ADI.Models;
using HeinHtetNaing_ADI.Services;

namespace HeinHtetNaing_ADI.Views.ClientViews
{
    public partial class ClientSigninForm : Form
    {
        private Form _welcomeForm;

        private readonly ClientService _clientService;
        public ClientSigninForm(Form welcomeForm)
        {
            InitializeComponent();
            _welcomeForm = welcomeForm;
            _clientService = new ClientService();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.KeyPreview = true;
        }

        private void siginUpLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var clientSignUpForm = new ClientSignUpForm(this);
            clientSignUpForm.Show();
            this.Hide();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            _welcomeForm.Show();
            this.Close();
        }

        private void ClientSigninForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            _welcomeForm.Show();
        }

        #region sign in
        private void signinButton_Click(object sender, EventArgs e)
        {
            string inputPassword = passwordTextBox.Text;

            if (string.IsNullOrEmpty(inputPassword) || string.IsNullOrWhiteSpace(emailTextBox.Text))
            {
                MessageBox.Show(
                "Please enter all the inputs",
                "Validation Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
                return;
            }

            Client client = this._clientService.FindClientByEmail(emailTextBox.Text);

            if (client == null)
            {
                MessageBox.Show(
                "Client account not found with this email",
                "System Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
                return;
            }

            bool success = client.Login(inputPassword);

            if (success)
            {
                Form homeForm = new ClientHomeForm(_welcomeForm);
                homeForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show(
                "Wrong Password. Please try again.",
                "System Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
                return;
            }

        }
        #endregion

        private void ClientSigninForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.signinButton_Click(sender, e);
            }
        }

        private void ClientSigninForm_Load(object sender, EventArgs e)
        {
            //False click
        }
    }
}
