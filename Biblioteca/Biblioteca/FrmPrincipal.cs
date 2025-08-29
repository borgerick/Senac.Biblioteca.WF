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
            var frmLoginAdmin = new LoginAdmin();
            frmLoginAdmin.ShowDialog();
        }

        private void btnDevolver_Click(object sender, EventArgs e)
        {
            var frmDevolver = new DevolucaoAluno();
            frmDevolver.ShowDialog();
        }

        private void btnAlun_Click(object sender, EventArgs e)
        {
            var frmAluno = new LoginAluno();
            frmAluno.ShowDialog();
        }
    }
}
