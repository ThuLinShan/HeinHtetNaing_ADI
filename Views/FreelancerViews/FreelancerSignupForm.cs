using HeinHtetNaing_ADI.Models;
using HeinHtetNaing_ADI.Services;

namespace HeinHtetNaing_ADI.Views.FreelancerViews
{
    public partial class FreelancerSignupForm : Form
    {

        Form _signInForm;
        FreelancerService _freelancerService;

        public FreelancerSignupForm(Form signInForm)
        {
            _signInForm = signInForm;
            _freelancerService = new FreelancerService();
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.KeyPreview = true;
        }

        private void signupButton_Click(object sender, EventArgs e)
        {
            // Validate required inputs
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

            // Validate password confirmation
            if (passwordTextBox.Text != confirmPasswordTextBox.Text)
            {
                MessageBox.Show(
                    "Passwords do not match.",
                    "Validation Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            // Check if a freelancer with the same email already exists
            var freelancerWithSameEmail = this._freelancerService.FindFreelancerByEmail(emailTextBox.Text);
            if (freelancerWithSameEmail != null)
            {
                MessageBox.Show(
                    "An account with this email already exists.",
                    "Validation Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            string firstName = firstNameTextBox.Text;
            string lastName = lastNameTextBox.Text;
            string email = emailTextBox.Text;
            string password = passwordTextBox.Text;
            string address = addressTextBox.Text;
            string phoneNo = phoneNumberTextBox.Text;
            string expertise = string.IsNullOrEmpty(expertiseTextBox.Text) ? string.Empty : expertiseTextBox.Text;
            string websiteLink = string.IsNullOrEmpty(webSiteTextBox.Text) ? string.Empty : webSiteTextBox.Text;


            // Create new freelancer object
            var newFreelancer = new Freelancer(
            firstName,
            lastName,
            email,
            password,
            expertise,
            address,
            phoneNo,
            websiteLink)
            { };

            // Fetch skills from DataGridView
            var skills = GetSkillsFromDataGridView(newFreelancer.FreelancerId);

            // Validate at least one skill is added
            if (skills.Count == 0)
            {
                MessageBox.Show(
                    "Please add at least one skill.",
                    "Validation Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            newFreelancer.Skills = skills;

            // Save freelancer using the service
            try
            {
                this._freelancerService.AddFreelancer(newFreelancer);

                MessageBox.Show(
                    "Account created successfully!",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                // Clear form fields after success
                ClearFormFields();
                this.Close();
                _signInForm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"An error occurred while creating the account: {ex.Message}",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close();
            _signInForm.Show();
        }

        private void FreelancerSignupForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            _signInForm.Show();
        }


        #region helper methods
        private List<Skill> GetSkillsFromDataGridView(long freelancerId)
        {
            var skills = new List<Skill>();
            var skillNamesSet = new HashSet<string>(StringComparer.OrdinalIgnoreCase);

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.IsNewRow || string.IsNullOrWhiteSpace(row.Cells["skill_name"].Value?.ToString()))
                {
                    continue;
                }

                var skillName = row.Cells["skill_name"].Value?.ToString();
                var skillLevel = row.Cells["skill_level"].Value?.ToString();

                if (!skillNamesSet.Contains(skillName))
                {
                    skills.Add(new Skill(freelancerId, skillName, skillLevel));
                    skillNamesSet.Add(skillName);
                }
            }

            return skills;
        }

        private void ClearFormFields()
        {
            firstNameTextBox.Text = string.Empty;
            lastNameTextBox.Text = string.Empty;
            emailTextBox.Text = string.Empty;
            passwordTextBox.Text = string.Empty;
            confirmPasswordTextBox.Text = string.Empty;
            addressTextBox.Text = string.Empty;
            phoneNumberTextBox.Text = string.Empty;
            dataGridView1.Rows.Clear();
        }
        #endregion
    }
}
