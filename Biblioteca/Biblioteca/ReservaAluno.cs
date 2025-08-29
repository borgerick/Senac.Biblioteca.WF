namespace Biblioteca
{
    public partial class ReservaAluno : Form
    {
        public ReservaAluno(string cpfDigitado)
        {
            InitializeComponent();
        }

        private void ReservaAluno_Load(object sender, EventArgs e)
        {

        }
        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Close();
            var frmPrincipal = new FrmPrincipal();
            frmPrincipal.Show();
        }
    }
}
