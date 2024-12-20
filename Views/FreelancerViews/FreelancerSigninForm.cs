using HeinHtetNaing_ADI.Models;
using HeinHtetNaing_ADI.Services;

namespace HeinHtetNaing_ADI.Views.FreelancerViews
{
    public partial class FreelancerSigninForm : Form
    {
        private Form _welcomeForm;
        private readonly FreelancerService _freelancerService;

        public FreelancerSigninForm(Form welcomeForm)
        {
            _welcomeForm = welcomeForm;
            _freelancerService = new FreelancerService();
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.KeyPreview = true;
        }

        private void FreelancerSigninForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            _welcomeForm.Show();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            _welcomeForm.Show();
            this.Close();
        }
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

            Freelancer freelancer = this._freelancerService.FindFreelancerByEmail(emailTextBox.Text);

            if (freelancer == null)
            {
                MessageBox.Show(
                "Freelancer account not found with this email",
                "System Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
                return;
            }

            bool success = freelancer.Login(inputPassword);

            if (success)
            {
                Form homeForm = new FreelancerHomeForm(_welcomeForm, freelancer.FreelancerId);
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

        private void siginUpLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form signupForm = new FreelancerSignupForm(this);
            signupForm.Show();
            this.Hide();
        }

        private void FreelancerSigninForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.signinButton_Click(sender, e);
            }
        }
    }
}
