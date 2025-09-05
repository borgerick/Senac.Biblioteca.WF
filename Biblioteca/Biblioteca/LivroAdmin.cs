using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;

namespace Biblioteca
{
    public partial class LivroAdmin : Form
    {
        Livro? livroSelecionado;
        public LivroAdmin(string usuario)
        {
            InitializeComponent();
        }
        private void LivroAdmin_Load(object sender, EventArgs e)
        {
            BuscarLivros();
        }
        private void BuscarLivros()
        {
            using (var bd = new BibliotecaDbContext())
            {
                var livros = bd.Livros.AsQueryable();
                if (!string.IsNullOrEmpty(txtBuscar.Text))
                {
                    livros = livros.Where(e => e.Codigo.Contains(txtBuscar.Text)|| 
                                               e.Titulo.Contains(txtBuscar.Text) ||
                                               e.Autor.Contains(txtBuscar.Text) ||
                                               e.Categoria.Contains(txtBuscar.Text));
                }
                dataGridViewLivro.DataSource = livros.ToList();
            }
        }
        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            new LivroAdminCad().ShowDialog();
            BuscarLivros();
        }
        private void txtPesquisar_TextChanged(object sender, EventArgs e)
        {
            BuscarLivros();
        }
        private void dataGridViewLivro_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                livroSelecionado = dataGridViewLivro.Rows[e.RowIndex].DataBoundItem as Livro;
                btnEditar.Enabled = true;
                btnExcluir.Enabled = true;//botei por ultimo
            }
        }
        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (livroSelecionado != null)
            {
                var resultado = new LivroAdminCad(livroSelecionado);
                resultado.ShowDialog();
                BuscarLivros();
                livroSelecionado = null;
            }else
            {
                MessageBox.Show("Selecione um livro", "Confirmação", MessageBoxButtons.YesNo);
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (livroSelecionado != null)
                using (var bd = new BibliotecaDbContext())

                {
                    bd.Livros.Remove(livroSelecionado);
                    bd.SaveChanges();
                }
            MessageBox.Show("Livro excluído com sucesso!",
                            "Sucesso",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
            BuscarLivros();
            livroSelecionado = null;
        }

        private void btnAluno_Click(object sender, EventArgs e)
        {
            this.Hide();
            var frmAluno = new AlunoAdmin("");
            frmAluno.ShowDialog();
        }

        private void btnReserva_Click(object sender, EventArgs e)
        {
            this.Hide();
            var frmReserva = new EmprestimoAdmin("");
            frmReserva.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
            var frmPrincipal = new FrmPrincipal("");
            frmPrincipal.Show();
        }
    }
}
