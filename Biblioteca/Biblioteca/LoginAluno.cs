using System.Runtime.CompilerServices;

namespace Biblioteca
{
    public partial class LoginAluno : Form
    {
        string _CPFValido;
        public LoginAluno()
        {
            InitializeComponent();
        }
        private void btnEntrar_Click(object sender, EventArgs e)
        {
            bool loginValido = ValidadarLogin(txtCPF.Text);
            if (loginValido)
            {
                var reservaAluno = new ReservaAluno(_CPFValido, txtCPF.Text);
                this.Hide();
                reservaAluno.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("CPF inválido. Tente novamente.", "Erro de Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDevolver_Click(object sender, EventArgs e)
        {
            bool loginValido = ValidadarLogin(txtCPF.Text);
            if (loginValido)
            {
                var devolucaoaluno = new DevolucaoAluno(_CPFValido, txtCPF.Text);
                this.Hide();
                devolucaoaluno.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("CPF inválido. Tente novamente.", "Erro de Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidadarLogin(string cpf)
        {
            using (var bd = new BibliotecaDbContext())
            {
                var aluno = bd.Alunos.FirstOrDefault(u => u.CPF == cpf);
                if (aluno is not null)
                {
                    _CPFValido = aluno.CPF;
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Close();
            var frmPrincipal = new FrmPrincipal();
            frmPrincipal.Show();
        }

        private void txtCPF_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCPF.Text))
            {
                txtCPF.Text = "Digite seu CPF";
                txtCPF.ForeColor = Color.Black;
            }
        }

        private void txtCPF_Enter(object sender, EventArgs e)
        {
            if (txtCPF.Text == "Digite seu CPF")
            {
                txtCPF.Text = string.Empty;
                txtCPF.ForeColor = Color.Black;
            }
        }


    }
}
