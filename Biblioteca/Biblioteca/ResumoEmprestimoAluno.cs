namespace Biblioteca
{
    public partial class ResumoEmprestimoAluno : Form
    {
        private readonly int _emprestimoId;

        public ResumoEmprestimoAluno(int emprestimoId)
        {
            InitializeComponent();
            _emprestimoId = emprestimoId;
        }

        private void ResumoEmprestimoAluno_Load(object sender, EventArgs e)
        {
            using (var bd = new BibliotecaDbContext())
            {
                var emprestimo = bd.Emprestimos
                                   .Where(e => e.Id == _emprestimoId)
                                   .Select(e => new
                                   {
                                       NumeroReserva = e.Id,
                                       NomeAluno = e.Aluno.Nome,
                                       DataRetirada = e.DataRetirada,
                                       DataDevolucao = e.DataDevolucao
                                   })
                                   .FirstOrDefault();

                if (emprestimo != null)
                {
                    lblNumeroReserva.Text = emprestimo.NumeroReserva.ToString();
                    lblAluno.Text = emprestimo.NomeAluno;
                    lblRetirada.Text = emprestimo.DataRetirada.ToString("dd/MM/yyyy");
                    lblDevolucao.Text = emprestimo.DataDevolucao.ToString("dd/MM/yyyy");
                }
                else
                {
                    MessageBox.Show("Não foi possível carregar o resumo da reserva.",
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
