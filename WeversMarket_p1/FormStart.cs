namespace WeversMarket_p1
{
    public partial class FormStart : Form
    {
        public FormStart()
        {
            InitializeComponent();
        }

        private void BtStart_Click(object sender, EventArgs e)
        {
            FormPrincipal formPrincipal = new FormPrincipal();
            this.Hide();
            formPrincipal.Show();
        }
    }
}
