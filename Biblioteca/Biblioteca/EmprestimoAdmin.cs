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
    public partial class EmprestimoAdmin : Form
    {
        Emprestimo? emprestimoSelecionado;
        public EmprestimoAdmin()
        {
            InitializeComponent();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Close();
            var frmPrincipal = new FrmPrincipal("");
            frmPrincipal.Show();
        }
        private void EmprestimoAdmin_Load(object sender, EventArgs e)
        {
            BuscarEmprestimos();
        }
        private void BuscarEmprestimos()
        {
            using (var context = new BibliotecaDbContext())
            {
                var emprestimos = context.Emprestimos.AsQueryable().Include(e=> e.Aluno).Include(e=> e.Livro).AsQueryable();
                if (!string.IsNullOrEmpty(txtBuscar.Text))
                {
                    emprestimos = emprestimos.Where(e => e.Aluno.Nome.Contains(txtBuscar.Text) ||
                                                       e.Livro.Titulo.Contains(txtBuscar.Text));
                }
                dataGridView1.DataSource = emprestimos.ToList();
            }
        }
        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            new EmprestimoAdminCad().ShowDialog();
            BuscarEmprestimos();
        }
        private void txtPesquisar_TextChanged(object sender, EventArgs e)
        {
            BuscarEmprestimos();
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                emprestimoSelecionado = dataGridView1.Rows[e.RowIndex].DataBoundItem as Emprestimo;
                btnEditar.Enabled = true;
            }
        }
        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (emprestimoSelecionado != null)
            {
                var formEmprestimo = new EmprestimoAdminCad(emprestimoSelecionado);
                formEmprestimo.ShowDialog();
                BuscarEmprestimos();
                emprestimoSelecionado = null;
            }
        }
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (emprestimoSelecionado != null)
                using (var bd = new BibliotecaDbContext())

                {
                    bd.Emprestimos.Remove(emprestimoSelecionado);
                    bd.SaveChanges();
                }
            MessageBox.Show("Livro excluído com sucesso!",
                            "Sucesso",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
            BuscarEmprestimos();
            emprestimoSelecionado = null;
        }

        private void btnLivro_Click(object sender, EventArgs e)
        {
            Close();
            var frmLivro = new LivroAdmin("");
            frmLivro.Show();
        }

        private void btnAluno_Click(object sender, EventArgs e)
        {
            Close();
            var frmAluno = new AlunoAdmin("");
            frmAluno.Show();
        }
    }

}
