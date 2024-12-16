namespace HeinHtetNaing_ADI.Views.ClientViews
{
    public partial class ClientHomeForm : Form
    {

        private Form _welcomeForm;

        public ClientHomeForm(Form welcomeForm)
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            this._welcomeForm = welcomeForm;
            InitializeComponent();
        }
        private void ClientHomeForm_Load(object sender, EventArgs e)
        {

        }

        private void ClientHomeForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            _welcomeForm.Close();
        }

        private void postProjectButton_Click(object sender, EventArgs e)
        {
            Form postProjectForm = new ClientPostProjectForm();
            postProjectForm.ShowDialog();
        }
    }
}
