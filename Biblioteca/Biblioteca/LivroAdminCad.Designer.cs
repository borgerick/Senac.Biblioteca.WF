namespace Biblioteca
{
    partial class LivroAdminCad
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
            txtTitulo = new TextBox();
            txtAutor = new TextBox();
            txtCategoria = new TextBox();
            btnAdicionar = new Button();
            button1 = new Button();
            label1 = new Label();
            txtCodigo = new TextBox();
            SuspendLayout();
            // 
            // txtTitulo
            // 
            txtTitulo.BackColor = Color.Gainsboro;
            txtTitulo.BorderStyle = BorderStyle.None;
            txtTitulo.Font = new Font("Arial", 14F);
            txtTitulo.ForeColor = Color.Black;
            txtTitulo.Location = new Point(58, 138);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(361, 33);
            txtTitulo.TabIndex = 5;
            txtTitulo.Text = "Titulo";
            txtTitulo.Enter += txtTitulo_Enter;
            txtTitulo.Leave += txtTitulo_Leave;
            // 
            // txtAutor
            // 
            txtAutor.BackColor = Color.Gainsboro;
            txtAutor.BorderStyle = BorderStyle.None;
            txtAutor.Font = new Font("Arial", 14F);
            txtAutor.ForeColor = Color.Black;
            txtAutor.Location = new Point(58, 190);
            txtAutor.Name = "txtAutor";
            txtAutor.Size = new Size(361, 33);
            txtAutor.TabIndex = 6;
            txtAutor.Text = "Autor";
            txtAutor.Enter += txtAutor_Enter;
            txtAutor.Leave += txtAutor_Leave;
            // 
            // txtCategoria
            // 
            txtCategoria.BackColor = Color.Gainsboro;
            txtCategoria.BorderStyle = BorderStyle.None;
            txtCategoria.Font = new Font("Arial", 14F);
            txtCategoria.ForeColor = Color.Black;
            txtCategoria.Location = new Point(58, 244);
            txtCategoria.Name = "txtCategoria";
            txtCategoria.Size = new Size(361, 33);
            txtCategoria.TabIndex = 7;
            txtCategoria.Text = "Categoria";
            txtCategoria.Enter += txtCategoria_Enter;
            txtCategoria.Leave += txtCategoria_Leave;
            // 
            // btnAdicionar
            // 
            btnAdicionar.BackColor = Color.ForestGreen;
            btnAdicionar.FlatAppearance.BorderSize = 0;
            btnAdicionar.FlatStyle = FlatStyle.Flat;
            btnAdicionar.Font = new Font("Arial", 12F);
            btnAdicionar.ForeColor = Color.White;
            btnAdicionar.Location = new Point(58, 301);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(154, 36);
            btnAdicionar.TabIndex = 8;
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
            button1.Location = new Point(265, 301);
            button1.Name = "button1";
            button1.Size = new Size(154, 36);
            button1.TabIndex = 9;
            button1.Text = "Cancelar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.SteelBlue;
            label1.Font = new Font("Segoe UI", 14F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(45, 32);
            label1.Name = "label1";
            label1.Size = new Size(378, 38);
            label1.TabIndex = 10;
            label1.Text = "Insira as informações do livro";
            // 
            // txtCodigo
            // 
            txtCodigo.BackColor = Color.Gainsboro;
            txtCodigo.BorderStyle = BorderStyle.None;
            txtCodigo.Font = new Font("Arial", 14F);
            txtCodigo.ForeColor = Color.Black;
            txtCodigo.Location = new Point(58, 90);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(361, 33);
            txtCodigo.TabIndex = 11;
            txtCodigo.Text = "Codigo";
            txtCodigo.Enter += txtCodigo_Enter;
            txtCodigo.Leave += txtCodigo_Leave;
            // 
            // LivroAdminCad
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(470, 367);
            Controls.Add(txtCodigo);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(btnAdicionar);
            Controls.Add(txtCategoria);
            Controls.Add(txtAutor);
            Controls.Add(txtTitulo);
            FormBorderStyle = FormBorderStyle.None;
            Name = "LivroAdminCad";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LivroAdminCad";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtTitulo;
        private TextBox txtAutor;
        private TextBox txtCategoria;
        private Button btnAdicionar;
        private Button button1;
        private Label label1;
        private TextBox txtCodigo;
    }
}