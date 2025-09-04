using System;
using System.Linq;
using System.Windows.Forms;

namespace Biblioteca
{
    public partial class ResumoDevolucaoAluno : Form
    {
        private readonly int _emprestimoId;

        public ResumoDevolucaoAluno(int emprestimoId)
        {
            InitializeComponent();
            _emprestimoId = emprestimoId;
        }

        private void ResumoDevolucaoAluno_Load(object sender, EventArgs e)
        {
            using (var bd = new BibliotecaDbContext())
            {
                var emprestimo = bd.Emprestimos
                                   .Where(e => e.Id == _emprestimoId)
                                   .Select(e => new
                                   {
                                       NumeroReserva = e.Id,
                                       NomeAluno = e.Aluno.Nome,
                                       NomeLivro = e.Livro.Titulo,
                                       DataDevolucao = e.DataDevolucao
                                   })
                                   .FirstOrDefault();

                if (emprestimo != null)
                {
                    lblNumeroReserva.Text = emprestimo.NumeroReserva.ToString();
                    lblAluno.Text = emprestimo.NomeAluno;
                    lblLivro.Text = emprestimo.NomeLivro;
                    lblDevolucao.Text = emprestimo.DataDevolucao.ToString("dd/MM/yyyy");
                    //lblDiasReserva = emprestimo.DataDevolucao
                }
                else
                {
                    MessageBox.Show("Não foi possível carregar o resumo da devolução.",
                                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                }
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            var frmPrincipal = new FrmPrincipal();
            frmPrincipal.Show();
        }
    }
}
