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
    public partial class AlunoAdminCad : Form
    {
        private Aluno _alunotem;
        public AlunoAdminCad()
        {
            InitializeComponent();
        }

        public AlunoAdminCad(Aluno aluno)
        {
            _alunotem = aluno;
            InitializeComponent();
            CarregarDadosDaTela();
        }
        private void CarregarDadosDaTela()
        {
            if (_alunotem != null)
            {
                txtNome.Text = _alunotem.Nome;
                txtSobrenome.Text = _alunotem.SobreNome;
                txtEmail.Text = _alunotem.Email;
                txtTelefone.Text = _alunotem.Telefone;
                txtMatricula.Text = _alunotem.Matricula;
                txtCpf.Text = _alunotem.CPF;
            }
        }
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (_alunotem == null)
            {
                SalvarAluno();
            }
            else
            {
                AtualizarAluno();
            }
        }

        private void AtualizarAluno()
        {
            using (var bd = new BibliotecaDbContext())
            {
                string nome = txtNome.Text;
                string sobrenome = txtSobrenome.Text;
                string email = txtEmail.Text;
                string telefone = txtTelefone.Text;
                string matricula = txtMatricula.Text;
                string cpf = txtCpf.Text;

                var alunos = bd.Alunos.First(e => e.Id != _alunotem.Id);

                alunos.Nome = nome;
                alunos.SobreNome = sobrenome;
                alunos.Email = email;
                alunos.Telefone = telefone;
                alunos.Matricula = matricula;
                alunos.CPF = cpf;

                bd.Alunos.Update(alunos);
                bd.SaveChanges();

                MessageBox.Show("Aluno atualizado com sucesso!",
                                        "Sucesso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                this.Close();

                CarregarDadosDaTela();
                this.Close();
            }
        }
        private void SalvarAluno()
        {
            using (var bd = new BibliotecaDbContext())
            {
                string nome = txtNome.Text;
                string sobrenome = txtSobrenome.Text;
                string email = txtEmail.Text;
                string telefone = txtTelefone.Text;
                string matricula = txtMatricula.Text;
                string cpf = txtCpf.Text;
                var aluno = new Aluno
                {
                    Nome = nome,
                    SobreNome = sobrenome,
                    Email = email,
                    Telefone = telefone,
                    Matricula = matricula,
                    CPF = cpf
                };
                bd.Alunos.Add(aluno);
                bd.SaveChanges();
                MessageBox.Show("Aluno cadastrado com sucesso!",
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
    }
}
