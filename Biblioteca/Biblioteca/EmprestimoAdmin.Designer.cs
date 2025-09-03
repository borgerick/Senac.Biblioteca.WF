namespace Biblioteca
{
    partial class EmprestimoAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmprestimoAdmin));
            btnLivro = new Button();
            btnAluno = new Button();
            btnReserva = new Button();
            btnAdicionar = new Button();
            btnEditar = new Button();
            btnExcluir = new Button();
            dataGridView1 = new DataGridView();
            txtBuscar = new TextBox();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnLivro
            // 
            btnLivro.BackColor = Color.Transparent;
            btnLivro.FlatAppearance.BorderSize = 0;
            btnLivro.FlatStyle = FlatStyle.Flat;
            btnLivro.Font = new Font("Arial", 14F);
            btnLivro.ForeColor = Color.White;
            btnLivro.Location = new Point(1, 25);
            btnLivro.Name = "btnLivro";
            btnLivro.Size = new Size(191, 49);
            btnLivro.TabIndex = 2;
            btnLivro.Text = "Livro";
            btnLivro.UseVisualStyleBackColor = false;
            btnLivro.Click += btnLivro_Click;
            // 
            // btnAluno
            // 
            btnAluno.BackColor = Color.Transparent;
            btnAluno.FlatAppearance.BorderSize = 0;
            btnAluno.FlatStyle = FlatStyle.Flat;
            btnAluno.Font = new Font("Arial", 14F);
            btnAluno.ForeColor = Color.White;
            btnAluno.Location = new Point(197, 25);
            btnAluno.Name = "btnAluno";
            btnAluno.Size = new Size(191, 49);
            btnAluno.TabIndex = 3;
            btnAluno.Text = "Aluno";
            btnAluno.UseVisualStyleBackColor = false;
            btnAluno.Click += btnAluno_Click;
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
            btnReserva.TabIndex = 4;
            btnReserva.Text = "Reservas";
            btnReserva.UseVisualStyleBackColor = false;
            btnReserva.Click += btnReserva_Click;
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
            btnAdicionar.TabIndex = 5;
            btnAdicionar.Text = "Adicionar";
            btnAdicionar.UseVisualStyleBackColor = false;
            btnAdicionar.Click += btnAdicionar_Click;
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
            btnEditar.TabIndex = 6;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = false;
            btnEditar.Click += btnEditar_Click;
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
            btnExcluir.TabIndex = 7;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = false;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 90);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(556, 477);
            dataGridView1.TabIndex = 8;
            dataGridView1.CellContentClick += dataGridView1_CellClick;
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(12, 592);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(556, 31);
            txtBuscar.TabIndex = 9;
            txtBuscar.TextChanged += txtPesquisar_TextChanged;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = ImageLayout.Zoom;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(516, 680);
            button1.Name = "button1";
            button1.Size = new Size(51, 49);
            button1.TabIndex = 12;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // EmprestimoAdmin
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(580, 738);
            Controls.Add(button1);
            Controls.Add(txtBuscar);
            Controls.Add(dataGridView1);
            Controls.Add(btnExcluir);
            Controls.Add(btnEditar);
            Controls.Add(btnAdicionar);
            Controls.Add(btnReserva);
            Controls.Add(btnAluno);
            Controls.Add(btnLivro);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "EmprestimoAdmin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EmprestimoAdmin";
            Load += EmprestimoAdmin_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLivro;
        private Button btnAluno;
        private Button btnReserva;
        private Button btnAdicionar;
        private Button btnEditar;
        private Button btnExcluir;
        private DataGridView dataGridView1;
        private TextBox txtBuscar;
        private Button button1;
    }
}