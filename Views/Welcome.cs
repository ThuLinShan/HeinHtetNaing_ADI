using HeinHtetNaing_ADI.Views.ClientViews;
using HeinHtetNaing_ADI.Views.FreelancerViews;

namespace HeinHtetNaing_ADI
{
    public partial class Welcome : Form
    {
        public Welcome()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void iamLabel1_Click(object sender, EventArgs e)
        {
            // False Click
        }

        private void clientLabelLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var clientSigninForm = new ClientSigninForm(this);
            this.Hide();
            clientSigninForm.Show();
        }

        private void freeLancerLabelLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var freelancerSigninForm = new FreelancerSigninForm(this);
            this.Hide();
            freelancerSigninForm.Show();
        }
        private void Welcome_FormClosing(object sender, FormClosingEventArgs e)
        {
            var result = MessageBox.Show(
                "Are you sure you want to exit the application?",
                "Exit Confirmation",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

    }
}
