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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LivroAdmin));
            btnAluno = new Button();
            btnLivro = new Button();
            btnReserva = new Button();
            btnAdicionar = new Button();
            btnExcluir = new Button();
            btnEditar = new Button();
            dataGridViewLivro = new DataGridView();
            txtBuscar = new TextBox();
            button1 = new Button();
            livroBindingSource = new BindingSource(components);
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            codigoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            tituloDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            autorDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            categoriaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridViewLivro).BeginInit();
            ((System.ComponentModel.ISupportInitialize)livroBindingSource).BeginInit();
            SuspendLayout();
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
            btnAluno.TabIndex = 0;
            btnAluno.Text = "Aluno";
            btnAluno.UseVisualStyleBackColor = false;
            btnAluno.Click += btnAluno_Click;
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
            btnAdicionar.TabIndex = 3;
            btnAdicionar.Text = "Adicionar";
            btnAdicionar.UseVisualStyleBackColor = false;
            btnAdicionar.Click += btnAdicionar_Click;
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
            btnExcluir.Click += btnExcluir_Click;
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
            btnEditar.Click += btnEditar_Click;
            // 
            // dataGridViewLivro
            // 
            dataGridViewLivro.AllowUserToAddRows = false;
            dataGridViewLivro.AutoGenerateColumns = false;
            dataGridViewLivro.BackgroundColor = Color.White;
            dataGridViewLivro.BorderStyle = BorderStyle.None;
            dataGridViewLivro.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewLivro.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, codigoDataGridViewTextBoxColumn, tituloDataGridViewTextBoxColumn, autorDataGridViewTextBoxColumn, categoriaDataGridViewTextBoxColumn });
            dataGridViewLivro.DataSource = livroBindingSource;
            dataGridViewLivro.Location = new Point(12, 93);
            dataGridViewLivro.Name = "dataGridViewLivro";
            dataGridViewLivro.ReadOnly = true;
            dataGridViewLivro.RowHeadersWidth = 62;
            dataGridViewLivro.Size = new Size(556, 477);
            dataGridViewLivro.TabIndex = 6;
            dataGridViewLivro.CellContentClick += dataGridViewLivro_CellClick;
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(12, 592);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(556, 31);
            txtBuscar.TabIndex = 8;
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
            // livroBindingSource
            // 
            livroBindingSource.DataSource = typeof(Livro);
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.MinimumWidth = 8;
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.ReadOnly = true;
            idDataGridViewTextBoxColumn.Visible = false;
            idDataGridViewTextBoxColumn.Width = 150;
            // 
            // codigoDataGridViewTextBoxColumn
            // 
            codigoDataGridViewTextBoxColumn.DataPropertyName = "Codigo";
            codigoDataGridViewTextBoxColumn.HeaderText = "Codigo";
            codigoDataGridViewTextBoxColumn.MinimumWidth = 8;
            codigoDataGridViewTextBoxColumn.Name = "codigoDataGridViewTextBoxColumn";
            codigoDataGridViewTextBoxColumn.ReadOnly = true;
            codigoDataGridViewTextBoxColumn.Width = 150;
            // 
            // tituloDataGridViewTextBoxColumn
            // 
            tituloDataGridViewTextBoxColumn.DataPropertyName = "Titulo";
            tituloDataGridViewTextBoxColumn.HeaderText = "Titulo";
            tituloDataGridViewTextBoxColumn.MinimumWidth = 8;
            tituloDataGridViewTextBoxColumn.Name = "tituloDataGridViewTextBoxColumn";
            tituloDataGridViewTextBoxColumn.ReadOnly = true;
            tituloDataGridViewTextBoxColumn.Width = 150;
            // 
            // autorDataGridViewTextBoxColumn
            // 
            autorDataGridViewTextBoxColumn.DataPropertyName = "Autor";
            autorDataGridViewTextBoxColumn.HeaderText = "Autor";
            autorDataGridViewTextBoxColumn.MinimumWidth = 8;
            autorDataGridViewTextBoxColumn.Name = "autorDataGridViewTextBoxColumn";
            autorDataGridViewTextBoxColumn.ReadOnly = true;
            autorDataGridViewTextBoxColumn.Width = 150;
            // 
            // categoriaDataGridViewTextBoxColumn
            // 
            categoriaDataGridViewTextBoxColumn.DataPropertyName = "Categoria";
            categoriaDataGridViewTextBoxColumn.HeaderText = "Categoria";
            categoriaDataGridViewTextBoxColumn.MinimumWidth = 8;
            categoriaDataGridViewTextBoxColumn.Name = "categoriaDataGridViewTextBoxColumn";
            categoriaDataGridViewTextBoxColumn.ReadOnly = true;
            categoriaDataGridViewTextBoxColumn.Width = 150;
            // 
            // LivroAdmin
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(580, 738);
            Controls.Add(button1);
            Controls.Add(txtBuscar);
            Controls.Add(dataGridViewLivro);
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
            Load += LivroAdmin_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewLivro).EndInit();
            ((System.ComponentModel.ISupportInitialize)livroBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAluno;
        private Button btnLivro;
        private Button btnReserva;
        private Button btnAdicionar;
        private Button btnExcluir;
        private Button btnEditar;
        private DataGridView dataGridViewLivro;
        private TextBox txtBuscar;
        private Button button1;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn codigoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn tituloDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn autorDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn categoriaDataGridViewTextBoxColumn;
        private BindingSource livroBindingSource;
    }
}