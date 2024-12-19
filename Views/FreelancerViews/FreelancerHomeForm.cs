namespace HeinHtetNaing_ADI.Views.FreelancerViews
{
    public partial class FreelancerHomeForm : Form
    {

        Form _welcomeForm;
        long _freelancerId;
        public FreelancerHomeForm(Form welcomeForm, long feelancerId)
        {
            _welcomeForm = welcomeForm;
            _freelancerId = feelancerId;
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void FreelancerHomeForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            _welcomeForm.Show();
            _welcomeForm.Close();
        }
    }
}
