using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;

namespace Biblioteca
{
    public partial class AlunoAdmin : Form
    {
        Aluno? alunoSelecionado;
        public AlunoAdmin(string usuario)
        {
            InitializeComponent();
        }

        private void AlunoAdmin_Load(object sender, EventArgs e)
        {
            BuscarAlunos();
        }
        private void BuscarAlunos()
        {
            using (var bd = new BibliotecaDbContext())
            {
                var alunos = bd.Alunos.AsQueryable();
                if (!string.IsNullOrEmpty(txtBuscar.Text))
                {
                    alunos = alunos.Where(e => e.Nome.Contains(txtBuscar.Text) ||
                                               e.SobreNome.Contains(txtBuscar.Text) ||
                                               e.CPF.Contains(txtBuscar.Text)).AsQueryable();
                }
                dataGridView1.DataSource = alunos.ToList();
            }
        }      
        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            new AlunoAdminCad().ShowDialog();
            BuscarAlunos();
        }
        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            BuscarAlunos();
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var alunoSelecionado = dataGridView1.Rows[e.RowIndex].DataBoundItem as Aluno;
                btnEditar.Enabled = true;
                btnExcluir.Enabled = true;
            }
        }
        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (alunoSelecionado != null)
            {
                var alunoform = new AlunoAdminCad(alunoSelecionado);
                alunoform.ShowDialog();
                BuscarAlunos();
                alunoSelecionado = null;
            }
        }
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (alunoSelecionado != null)
                using (var bd = new BibliotecaDbContext())

                {
                    bd.Alunos.Remove(alunoSelecionado);
                    bd.SaveChanges();
                }
            MessageBox.Show("Aluno excluído com sucesso!",
                "Sucesso",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            BuscarAlunos();
            alunoSelecionado = null;
        }

        private void btnLivro_Click(object sender, EventArgs e)
        {
            this.Hide();
            var frmLivro = new LivroAdmin("");
            frmLivro.ShowDialog();
        }

        private void btnReserva_Click(object sender, EventArgs e)
        {
            this.Hide();
            var frmReserva = new EmprestimoAdmin("");
            frmReserva.ShowDialog();
        }
    }
}
