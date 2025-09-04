using System;
using System.Linq;
using System.Windows.Forms;

namespace Biblioteca
{
    public partial class DevolucaoAluno : Form
    {
        private readonly string _cpfAluno;
        private readonly string _nomeAluno;

        public DevolucaoAluno(string cpfDigitado, string nome)
        {
            InitializeComponent();
            _cpfAluno = cpfDigitado;
            _nomeAluno = nome;
        }

        private void DevolucaoAluno_Load(object sender, EventArgs e)
        {
            txtBipeLivro.Focus();
        }

        private void btnLocalizar_Click(object sender, EventArgs e)
        {
            string codigoLivro = txtBipeLivro.Text?.Trim();

            if (string.IsNullOrWhiteSpace(codigoLivro))
            {
                MessageBox.Show("Digite o código do livro.", "Atenção",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (var bd = new BibliotecaDbContext())
                {
                    // Localiza o aluno
                    var aluno = bd.Alunos.FirstOrDefault(a => a.CPF == _cpfAluno);
                    if (aluno == null)
                    {
                        MessageBox.Show("Aluno não encontrado.", "Erro",
                                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // Localiza o livro
                    var livro = bd.Livros.FirstOrDefault(l => l.Codigo == codigoLivro);
                    if (livro == null)
                    {
                        MessageBox.Show("Livro não encontrado.", "Erro",
                                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // Localiza o empréstimo ativo (reservado/emprestado)
                    var emprestimo = bd.Emprestimos
                                       .FirstOrDefault(e => e.AlunoId == aluno.Id &&
                                                            e.LivroId == livro.Id &&
                                                            e.SituacaoLivro == 1); // 1 = Reservado/Emprestado

                    if (emprestimo == null)
                    {
                        MessageBox.Show("Nenhum empréstimo ativo encontrado para este livro/aluno.",
                                        "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // Atualiza devolução
                    emprestimo.SituacaoLivro = 2; // 2 = Livre
                    emprestimo.DataDevolucao = DateTime.Now;

                    bd.SaveChanges();

                    // Abre tela de resumo
                    var resumo = new ResumoDevolucaoAluno(emprestimo.Id);
                    resumo.ShowDialog(this);

                    // Limpa campo para próxima devolução
                    txtBipeLivro.Clear();
                    txtBipeLivro.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao registrar a devolução:\n" + ex.Message,
                                "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
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
    

