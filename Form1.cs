namespace PingPong
{
    public partial class frmDificuldade : Form
    {
        public frmDificuldade()
        {
            InitializeComponent();
        }

        private void btnIniciante_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmTela frmTela = new frmTela(200);
            frmTela.Show();
        }

        private void btnMedio_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmTela frmTela = new frmTela(100);
            frmTela.Show();
        }

        private void btnAvancado_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmTela frmTela = new frmTela(50);
            frmTela.Show();
        }
    }
}