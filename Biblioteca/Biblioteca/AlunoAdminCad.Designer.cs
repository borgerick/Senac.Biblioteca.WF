namespace Biblioteca
{
    partial class AlunoAdminCad
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            txtNome = new TextBox();
            btnAdicionar = new Button();
            button1 = new Button();
            txtSobrenome = new TextBox();
            txtEmail = new TextBox();
            txtTelefone = new TextBox();
            txtMatricula = new TextBox();
            txtCpf = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(255, 128, 0);
            label1.Font = new Font("Segoe UI", 14F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(16, 25);
            label1.Name = "label1";
            label1.Size = new Size(416, 38);
            label1.TabIndex = 11;
            label1.Text = "Insira as informações do ALUNO";
            // 
            // txtNome
            // 
            txtNome.BackColor = Color.Gainsboro;
            txtNome.BorderStyle = BorderStyle.None;
            txtNome.Font = new Font("Arial", 14F);
            txtNome.ForeColor = Color.Black;
            txtNome.Location = new Point(34, 79);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(361, 33);
            txtNome.TabIndex = 12;
            txtNome.Text = "Nome";
            // 
            // btnAdicionar
            // 
            btnAdicionar.BackColor = Color.ForestGreen;
            btnAdicionar.FlatAppearance.BorderSize = 0;
            btnAdicionar.FlatStyle = FlatStyle.Flat;
            btnAdicionar.Font = new Font("Arial", 12F);
            btnAdicionar.ForeColor = Color.White;
            btnAdicionar.Location = new Point(34, 393);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(154, 36);
            btnAdicionar.TabIndex = 13;
            btnAdicionar.Text = "Adicionar";
            btnAdicionar.UseVisualStyleBackColor = false;
            btnAdicionar.Click += btnSalvar_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Red;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Arial", 12F);
            button1.ForeColor = Color.White;
            button1.Location = new Point(241, 393);
            button1.Name = "button1";
            button1.Size = new Size(154, 36);
            button1.TabIndex = 14;
            button1.Text = "Cancelar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // txtSobrenome
            // 
            txtSobrenome.BackColor = Color.Gainsboro;
            txtSobrenome.BorderStyle = BorderStyle.None;
            txtSobrenome.Font = new Font("Arial", 14F);
            txtSobrenome.ForeColor = Color.Black;
            txtSobrenome.Location = new Point(34, 131);
            txtSobrenome.Name = "txtSobrenome";
            txtSobrenome.Size = new Size(361, 33);
            txtSobrenome.TabIndex = 15;
            txtSobrenome.Text = "Sobrenome";
            // 
            // txtEmail
            // 
            txtEmail.BackColor = Color.Gainsboro;
            txtEmail.BorderStyle = BorderStyle.None;
            txtEmail.Font = new Font("Arial", 14F);
            txtEmail.ForeColor = Color.Black;
            txtEmail.Location = new Point(32, 223);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(361, 33);
            txtEmail.TabIndex = 16;
            txtEmail.Text = "E-mail";
            // 
            // txtTelefone
            // 
            txtTelefone.BackColor = Color.Gainsboro;
            txtTelefone.BorderStyle = BorderStyle.None;
            txtTelefone.Font = new Font("Arial", 14F);
            txtTelefone.ForeColor = Color.Black;
            txtTelefone.Location = new Point(34, 268);
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(361, 33);
            txtTelefone.TabIndex = 17;
            txtTelefone.Text = "Telefone";
            // 
            // txtMatricula
            // 
            txtMatricula.BackColor = Color.Gainsboro;
            txtMatricula.BorderStyle = BorderStyle.None;
            txtMatricula.Font = new Font("Arial", 14F);
            txtMatricula.ForeColor = Color.Black;
            txtMatricula.Location = new Point(34, 317);
            txtMatricula.Name = "txtMatricula";
            txtMatricula.Size = new Size(361, 33);
            txtMatricula.TabIndex = 18;
            txtMatricula.Text = "Matricula";
            // 
            // txtCpf
            // 
            txtCpf.BackColor = Color.Gainsboro;
            txtCpf.BorderStyle = BorderStyle.None;
            txtCpf.Font = new Font("Arial", 14F);
            txtCpf.ForeColor = Color.Black;
            txtCpf.Location = new Point(34, 177);
            txtCpf.Name = "txtCpf";
            txtCpf.Size = new Size(361, 33);
            txtCpf.TabIndex = 19;
            txtCpf.Text = "CPF";
            // 
            // AlunoAdminCad
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(448, 453);
            Controls.Add(txtCpf);
            Controls.Add(txtMatricula);
            Controls.Add(txtTelefone);
            Controls.Add(txtEmail);
            Controls.Add(txtSobrenome);
            Controls.Add(button1);
            Controls.Add(btnAdicionar);
            Controls.Add(txtNome);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AlunoAdminCad";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AlunoAdminCad";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNome;
        private Button btnAdicionar;
        private Button button1;
        private TextBox txtSobrenome;
        private TextBox txtEmail;
        private TextBox txtTelefone;
        private TextBox txtMatricula;
        private TextBox txtCpf;
    }
}