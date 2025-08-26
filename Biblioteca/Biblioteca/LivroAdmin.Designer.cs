namespace Biblioteca
{
    partial class LivroAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LivroAdmin));
            btnAluno = new Button();
            btnLivro = new Button();
            btnReserva = new Button();
            btnAdicionar = new Button();
            btnExcluir = new Button();
            btnEditar = new Button();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnAluno
            // 
            btnAluno.BackColor = Color.Transparent;
            btnAluno.FlatAppearance.BorderSize = 0;
            btnAluno.FlatStyle = FlatStyle.Flat;
            btnAluno.Font = new Font("Arial", 14F);
            btnAluno.ForeColor = Color.White;
            btnAluno.Location = new Point(1, 25);
            btnAluno.Name = "btnAluno";
            btnAluno.Size = new Size(191, 49);
            btnAluno.TabIndex = 0;
            btnAluno.Text = "Aluno";
            btnAluno.UseVisualStyleBackColor = false;
            // 
            // btnLivro
            // 
            btnLivro.BackColor = Color.Transparent;
            btnLivro.FlatAppearance.BorderSize = 0;
            btnLivro.FlatStyle = FlatStyle.Flat;
            btnLivro.Font = new Font("Arial", 14F);
            btnLivro.ForeColor = Color.White;
            btnLivro.Location = new Point(196, 25);
            btnLivro.Name = "btnLivro";
            btnLivro.Size = new Size(191, 49);
            btnLivro.TabIndex = 1;
            btnLivro.Text = "Livro";
            btnLivro.UseVisualStyleBackColor = false;
            // 
            // btnReserva
            // 
            btnReserva.BackColor = Color.Transparent;
            btnReserva.FlatAppearance.BorderSize = 0;
            btnReserva.FlatStyle = FlatStyle.Flat;
            btnReserva.Font = new Font("Arial", 14F);
            btnReserva.ForeColor = Color.White;
            btnReserva.Location = new Point(390, 25);
            btnReserva.Name = "btnReserva";
            btnReserva.Size = new Size(191, 49);
            btnReserva.TabIndex = 2;
            btnReserva.Text = "Reservas";
            btnReserva.UseVisualStyleBackColor = false;
            // 
            // btnAdicionar
            // 
            btnAdicionar.BackColor = Color.Transparent;
            btnAdicionar.FlatAppearance.BorderSize = 0;
            btnAdicionar.FlatStyle = FlatStyle.Flat;
            btnAdicionar.Font = new Font("Arial", 12F);
            btnAdicionar.ForeColor = Color.White;
            btnAdicionar.Location = new Point(103, 641);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(378, 36);
            btnAdicionar.TabIndex = 3;
            btnAdicionar.Text = "Adicionar";
            btnAdicionar.UseVisualStyleBackColor = false;
            // 
            // btnExcluir
            // 
            btnExcluir.BackColor = Color.Transparent;
            btnExcluir.FlatAppearance.BorderSize = 0;
            btnExcluir.FlatStyle = FlatStyle.Flat;
            btnExcluir.Font = new Font("Arial", 12F);
            btnExcluir.ForeColor = Color.White;
            btnExcluir.ImageAlign = ContentAlignment.TopCenter;
            btnExcluir.Location = new Point(103, 683);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(187, 36);
            btnExcluir.TabIndex = 4;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = false;
            // 
            // btnEditar
            // 
            btnEditar.BackColor = Color.Transparent;
            btnEditar.FlatAppearance.BorderSize = 0;
            btnEditar.FlatStyle = FlatStyle.Flat;
            btnEditar.Font = new Font("Arial", 12F);
            btnEditar.ForeColor = Color.White;
            btnEditar.ImageAlign = ContentAlignment.TopCenter;
            btnEditar.Location = new Point(293, 682);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(187, 36);
            btnEditar.TabIndex = 5;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 91);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(556, 544);
            dataGridView1.TabIndex = 6;
            // 
            // LivroAdmin
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(580, 738);
            Controls.Add(dataGridView1);
            Controls.Add(btnEditar);
            Controls.Add(btnExcluir);
            Controls.Add(btnAdicionar);
            Controls.Add(btnReserva);
            Controls.Add(btnLivro);
            Controls.Add(btnAluno);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "LivroAdmin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LivroAdmin";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnAluno;
        private Button btnLivro;
        private Button btnReserva;
        private Button btnAdicionar;
        private Button btnExcluir;
        private Button btnEditar;
        private DataGridView dataGridView1;
    }
}