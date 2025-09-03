using System;
using System.Windows.Forms;

namespace Biblioteca
{
    public partial class LoginAdmin : Form
    {
        private string _nomeUsuario;

        public LoginAdmin()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            string login = txtLogin.Text.Trim();
            string senha = txtSenha.Text.Trim();

            if (ValidarLogin(login, senha))
            {
                this.Hide();
                var livroAdmin = new LivroAdmin(_nomeUsuario);
                livroAdmin.ShowDialog();
                this.Show();
            }
        }

        private bool ValidarLogin(string login, string senha)
        {
            string usuarioPadrao = "admin";
            string senhaPadrao = "123";


            if (login.Equals(usuarioPadrao, StringComparison.OrdinalIgnoreCase) && senha == senhaPadrao)
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

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
            var frmPrincipal = new FrmPrincipal();
            frmPrincipal.Show();
        }

        private void txtLogin_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtLogin.Text))
            {
                txtLogin.Text = "Usuário";
                txtLogin.ForeColor = Color.Black;
            }
        }
        private void txtLogin_Enter(object sender, EventArgs e)
        {
            if (txtLogin.Text == "Usuário")
            {
                txtLogin.Text = string.Empty;
                txtLogin.ForeColor = Color.Black;
            }
        }

        private void txtSenha_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSenha.Text))
            {
                txtSenha.Text = "Senha";
                txtSenha.ForeColor = Color.Black;
            }
        }
        private void txtSenha_Enter(object sender, EventArgs e)
        {
            if (txtSenha.Text == "Senha")
            {
                txtSenha.Text = string.Empty;
                txtSenha.ForeColor = Color.Black;
            }
        }


    }
}
