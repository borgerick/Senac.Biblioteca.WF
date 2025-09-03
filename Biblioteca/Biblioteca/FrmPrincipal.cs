namespace Biblioteca
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal(string nomeUsuario)
        {
            InitializeComponent();
        }

        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            this.Hide();
            var frmLoginAdmin = new LoginAdmin();
            frmLoginAdmin.ShowDialog();
        }

        private void btnDevolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            var frmDevolver = new DevolucaoAluno();
            frmDevolver.ShowDialog();
        }

        private void btnAlun_Click(object sender, EventArgs e)
        {
            this.Hide();
            var frmAluno = new LoginAluno();
            frmAluno.ShowDialog();
        }

        private void btnfechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
