namespace HeinHtetNaing_ADI.Views.ClientViews
{
    public partial class ClientProjectDetailsForm : Form
    {
        private long _projectId;
        public ClientProjectDetailsForm(long projectId)
        {
            _projectId = projectId;
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
        }
    }
}
