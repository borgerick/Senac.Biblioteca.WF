namespace Biblioteca
{
    partial class ReservaAluno
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReservaAluno));
            btnLocalizar = new Button();
            txtBipeLivro = new TextBox();
            label3 = new Label();
            btnVoltar = new Button();
            lblMensagem = new Label();
            SuspendLayout();
            // 
            // btnLocalizar
            // 
            btnLocalizar.BackColor = Color.Transparent;
            btnLocalizar.FlatAppearance.BorderSize = 0;
            btnLocalizar.FlatStyle = FlatStyle.Flat;
            btnLocalizar.Font = new Font("Arial", 16F);
            btnLocalizar.ForeColor = Color.White;
            btnLocalizar.Location = new Point(211, 443);
            btnLocalizar.Name = "btnLocalizar";
            btnLocalizar.Size = new Size(159, 49);
            btnLocalizar.TabIndex = 7;
            btnLocalizar.Text = "Localizar";
            btnLocalizar.UseVisualStyleBackColor = false;
            btnLocalizar.Click += btnLocalizar_Click;
            // 
            // txtBipeLivro
            // 
            txtBipeLivro.BackColor = Color.DarkGray;
            txtBipeLivro.BorderStyle = BorderStyle.None;
            txtBipeLivro.Font = new Font("Arial", 12F);
            txtBipeLivro.ForeColor = Color.White;
            txtBipeLivro.Location = new Point(149, 332);
            txtBipeLivro.Name = "txtBipeLivro";
            txtBipeLivro.Size = new Size(287, 28);
            txtBipeLivro.TabIndex = 8;
            txtBipeLivro.Text = "Bipe seu livro aqui";
            txtBipeLivro.TextAlign = HorizontalAlignment.Center;
            txtBipeLivro.Enter += txtBipeLivro_Enter;
            txtBipeLivro.Leave += txtBipeLivro_Leave;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Arial", 22F);
            label3.ForeColor = Color.DimGray;
            label3.Location = new Point(123, 228);
            label3.Name = "label3";
            label3.Size = new Size(329, 50);
            label3.TabIndex = 10;
            label3.Text = "Código do Livro";
            // 
            // btnVoltar
            // 
            btnVoltar.BackColor = SystemColors.ButtonHighlight;
            btnVoltar.FlatAppearance.BorderSize = 0;
            btnVoltar.FlatStyle = FlatStyle.Flat;
            btnVoltar.Location = new Point(498, 660);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(70, 34);
            btnVoltar.TabIndex = 11;
            btnVoltar.Text = "Voltar";
            btnVoltar.UseVisualStyleBackColor = false;
            btnVoltar.Click += btnVoltar_Click_1;
            // 
            // lblMensagem
            // 
            lblMensagem.AutoSize = true;
            lblMensagem.BackColor = Color.Transparent;
            lblMensagem.Font = new Font("Arial", 22F);
            lblMensagem.ForeColor = Color.DimGray;
            lblMensagem.Location = new Point(123, 45);
            lblMensagem.Name = "lblMensagem";
            lblMensagem.Size = new Size(285, 50);
            lblMensagem.TabIndex = 13;
            lblMensagem.Text = "lblMensagem";
            // 
            // ReservaAluno
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(580, 738);
            Controls.Add(lblMensagem);
            Controls.Add(btnVoltar);
            Controls.Add(label3);
            Controls.Add(txtBipeLivro);
            Controls.Add(btnLocalizar);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "ReservaAluno";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ReservaAluno";
            Load += ReservaAluno_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLocalizar;
        private TextBox txtBipeLivro;
        private Label label3;
        private Button btnVoltar;
        private Label lblMensagem;
    }
}