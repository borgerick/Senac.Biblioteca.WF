namespace Biblioteca
{
    public partial class LoginAluno : Form
    {
        public LoginAluno()
        {
            InitializeComponent();
        }
        private void btnEntrar_Click(object sender, EventArgs e)
        {
            string cpfDigitado = txtCPF.Text.Trim();
                       
            if (string.IsNullOrWhiteSpace(cpfDigitado))
            {
                MessageBox.Show("Por favor, digite seu CPF.", "Atenção",
                                MessageBoxButtons.OK, 
                                MessageBoxIcon.Warning);
                return;
            }
                        
            if (cpfDigitado.Length > 11)
            {
                MessageBox.Show("CPF inválido. Digite novamente.", "Erro",
                                MessageBoxButtons.OK, 
                                MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show("Login realizado com sucesso!", "Bem-vindo",
                            MessageBoxButtons.OK, 
                            MessageBoxIcon.Information);

            using (var frmReserva = new ReservaAluno(cpfDigitado))
            {
                frmReserva.ShowDialog();
            }

            this.Close();
        }
        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Close();
            var frmPrincipal = new FrmPrincipal();
            frmPrincipal.Show();
        }
    }
}
