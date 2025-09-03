using System;
using System.Linq;           
using System.Windows.Forms;

namespace Biblioteca
{
    public partial class ReservaAluno : Form
    {
        private readonly string _cpfAluno;
        private string cPFValido;

        public ReservaAluno(string cpfDigitado, string nome)
        {
            InitializeComponent();
            lblMensagem.Text = "Oii " + nome;
        }

        //public ReservaAluno(string cPFValido)
        //{
        //    this.cPFValido = cPFValido;
        //}

        //private void ReservaAluno_Load(object sender, EventArgs e)
        //{
        //    txtBipeLivro.Focus();
        //}

        //private void btnLocalizar_Click(object sender, EventArgs e)
        //{
        //    string codigoLivro = txtBipeLivro.Text?.Trim();

        //    if (string.IsNullOrWhiteSpace(codigoLivro))
        //    {
        //        MessageBox.Show("Digite o código do livro.", "Atenção",
        //                        MessageBoxButtons.OK, 
        //                        MessageBoxIcon.Warning);
        //        return;
        //    }

        //    try
        //    {
        //        using (var bd = new BibliotecaDbContext())
        //        {
        //            var aluno = bd.Alunos.FirstOrDefault(a => a.CPF == _cpfAluno);
        //            if (aluno == null)
        //            {
        //                MessageBox.Show("Livro encontrado.", "Erro",
        //                                MessageBoxButtons.OK, MessageBoxIcon.Error);
        //                return;
        //            }

        //            var livro = bd.Livros.FirstOrDefault(l => l.Codigo == codigoLivro); // ajuste o nome do campo se for diferente
        //            if (livro == null)
        //            {
        //                MessageBox.Show("Livro não encontrado.", "Erro",
        //                                MessageBoxButtons.OK, MessageBoxIcon.Error);
        //                return;
        //            }

        //            var emprestimo = new Emprestimo
        //            {
        //                LivroId = livro.Id,
        //                AlunoId = aluno.Id,
        //                SituacaoLivro = 1,                 // 1 = Locado
        //                DataRetirada = DateTime.Now,
        //                DataDevolucao = DateTime.Now.AddDays(7)
        //            };

        //            bd.Emprestimos.Add(emprestimo);
        //            bd.SaveChanges();

        //            using (var resumo = new ResumoEmprestimoAluno(emprestimo.Id))
        //            {
        //                resumo.ShowDialog(this);
        //            }

        //            // Se for continuar na mesma tela para novo empréstimo:
        //            txtBipeLivro.Clear();
        //            txtBipeLivro.Focus();
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Ocorreu um erro ao registrar o empréstimo:\n" + ex.Message,
        //                        "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}

        private void btnVoltar_Click_1(object sender, EventArgs e)
        {
            Close();
            var frmPrincipal = new FrmPrincipal();
            frmPrincipal.Show();
        }

        private void txtBipeLivro_Enter(object sender, EventArgs e)
        {
            if (txtBipeLivro.Text == "Bipe seu livro aqui")
            {
                txtBipeLivro.Text = string.Empty;
                txtBipeLivro.ForeColor = Color.Black;
            }
        }

        private void txtBipeLivro_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBipeLivro.Text))
            {
                txtBipeLivro.Text = "Bipe seu livro aqui";
                txtBipeLivro.ForeColor = Color.Black;
            }
        }
    }
}
