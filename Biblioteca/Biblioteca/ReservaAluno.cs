using System;
using System.Linq;
using System.Windows.Forms;

namespace Biblioteca
{
    public partial class ReservaAluno : Form
    {
        private readonly string _cpfAluno;
        private readonly string _nomeAluno;

        public ReservaAluno(string cpfDigitado, string nome)
        {
            InitializeComponent();
            _cpfAluno = cpfDigitado;   
            _nomeAluno = nome;

            lblMensagem.Text = "Oii " + nome;
        }

        private void ReservaAluno_Load(object sender, EventArgs e)
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
                    // Localiza aluno
                    var aluno = bd.Alunos.FirstOrDefault(e => e.CPF == _cpfAluno);
                    if (aluno == null)
                    {
                        MessageBox.Show("Aluno não encontrado.", "Erro",
                                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // Localiza livro
                    var livro = bd.Livros.FirstOrDefault(l => l.Codigo == codigoLivro);
                    if (livro == null)
                    {
                        MessageBox.Show("Livro não encontrado.", "Erro",
                                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // Verifica se já existe reserva ativa
                    bool jaReservado = bd.Emprestimos
                                         .Any(e => e.AlunoId == aluno.Id &&
                                                   e.LivroId == livro.Id &&
                                                   e.SituacaoLivro == 1); // 1 = Reservado

                    if (jaReservado)
                    {
                        MessageBox.Show("Este aluno já possui uma reserva ativa para este livro.",
                                        "Reserva duplicada",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Warning);
                        return;
                    }

                    // Cria reserva
                    var emprestimo = new Emprestimo
                    {
                        LivroId = livro.Id,
                        AlunoId = aluno.Id,
                        SituacaoLivro = 1,                 // 1 = Reservado
                        DataRetirada = DateTime.Now,
                        DataDevolucao = DateTime.Now.AddDays(7)
                    };

                    bd.Emprestimos.Add(emprestimo);
                    bd.SaveChanges();

                    // Mostra resumo
                    var resumo = new ResumoEmprestimoAluno(emprestimo.Id);
                    resumo.ShowDialog(this);

                    // Limpa campo
                    txtBipeLivro.Clear();
                    txtBipeLivro.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao registrar o empréstimo:\n" + ex.Message,
                                "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }





        //AJUSTES PARA TEXTO SUMIR E APARECER DE NOVO QUANDO CLICAR FORA DO CAMPO
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
