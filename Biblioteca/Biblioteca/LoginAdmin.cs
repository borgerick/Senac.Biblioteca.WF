namespace Biblioteca
{
    public partial class LoginAdmin : Form
    {
        string _nomeUsuario;

        public LoginAdmin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            bool loginValido = ValidarLogin(txtLogin.Text, txtSenha.Text);
            if (loginValido)
            {
                this.Hide();
                var frmPrincipal = new FrmPrincipal(_nomeUsuario, txtSenha.Text);
                frmPrincipal.Show();
            }
        }

        private bool ValidarLogin(string login, string senha)
        {
            // Usuário e senha fixos
            string usuarioPadrao = "admin";
            string senhaPadrao = "123";

            if (login.ToLower() == usuarioPadrao && senha == senhaPadrao)
            {
                _nomeUsuario = usuarioPadrao;
                return true;
            }
            else
            {
                MessageBox.Show("Login ou senha inválidos.",
                                "Erro de autenticação",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return false;
            }
        }
    }
}
