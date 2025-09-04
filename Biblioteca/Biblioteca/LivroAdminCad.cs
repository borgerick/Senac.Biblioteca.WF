using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biblioteca
{
    public partial class LivroAdminCad : Form
    {
        private Livro _livrotem;
        public LivroAdminCad()
        {
            InitializeComponent();
        }
        public LivroAdminCad(Livro livro)
        {
            _livrotem = livro;
            InitializeComponent();

            CarregarDadosDaTela();
        }
        private void CarregarDadosDaTela()
        {
            if (_livrotem != null)
            {
                txtCodigo.Text = _livrotem.Codigo.ToString();
                txtTitulo.Text = _livrotem.Titulo;
                txtAutor.Text = _livrotem.Autor;
                txtCategoria.Text = _livrotem.Categoria;
            }
        }
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (_livrotem == null)
            {
                SalvarLivro();
            }
            else
            {
                AtualizarLivro();
            }
        }
        private void AtualizarLivro()
        {
            using (var bd = new BibliotecaDbContext())
            {
                string codigo = txtCodigo.Text;
                string titulo = txtTitulo.Text;
                string autor = txtAutor.Text;
                string categoria = txtCategoria.Text;
                
                var livros = bd.Livros.First(e => e.Id != _livrotem.Id &&
                                        e.Codigo == codigo &&
                                        e.Titulo == titulo &&
                                        e.Autor == autor &&
                                        e.Categoria == categoria);
                livros.Titulo = titulo;

                bd.Livros.Update(livros);
                bd.SaveChanges();
                                
                MessageBox.Show("Livro atualizado com sucesso.",
                    "Sucesso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                this.Close();
            }
        }

        private void SalvarLivro()
        {
            using (var bd = new BibliotecaDbContext())
            {
                string codigo = txtCodigo.Text;
                string titulo = txtTitulo.Text;
                string autor = txtAutor.Text;
                string categoria = txtCategoria.Text;

                var livro = new Livro
                {
                    Codigo = codigo,
                    Titulo = titulo,
                    Autor = autor,
                    Categoria = categoria
                };

                bd.Livros.Add(livro);
                bd.SaveChanges();

                MessageBox.Show("Livro salvo com sucesso.",
                    "Sucesso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                this.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtTitulo_Enter(object sender, EventArgs e)
        {
            if (txtTitulo.Text == "Titulo")
            {
                txtTitulo.Text = string.Empty;
                txtTitulo.ForeColor = Color.Black;
            }
        }

        private void txtTitulo_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTitulo.Text))
            {
                txtTitulo.Text = "Digite seu CPF";
                txtTitulo.ForeColor = Color.Black;
            }
        }
        private void txtAutor_Enter(object sender, EventArgs e)
        {
            if (txtAutor.Text == "Autor")
            {
                txtAutor.Text = string.Empty;
                txtAutor.ForeColor = Color.Black;
            }
        }

        private void txtAutor_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtAutor.Text))
            {
                txtAutor.Text = "Autor";
                txtAutor.ForeColor = Color.Black;
            }
        }
        private void txtCategoria_Enter(object sender, EventArgs e)
        {
            if (txtCategoria.Text == "Categoria")
            {
                txtCategoria.Text = string.Empty;
                txtCategoria.ForeColor = Color.Black;
            }
        }

        private void txtCategoria_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCategoria.Text))
            {
                txtCategoria.Text = "Categoria";
                txtCategoria.ForeColor = Color.Black;
            }
        }
        private void txtCodigo_Enter(object sender, EventArgs e)
        {
            if (txtCodigo.Text == "Codigo")
            {
                txtCodigo.Text = string.Empty;
                txtCodigo.ForeColor = Color.Black;
            }
        }

        private void txtCodigo_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCodigo.Text))
            {
                txtCodigo.Text = "Codigo";
                txtCodigo.ForeColor = Color.Black;
            }
        }
    }
}

