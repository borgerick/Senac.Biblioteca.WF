namespace Biblioteca
{
    partial class DevolucaoAluno
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
            label3 = new Label();
            txtBipeLivro = new TextBox();
            btnLocalizar = new Button();
            btnVoltar = new Button();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Arial", 22F);
            label3.ForeColor = Color.DimGray;
            label3.Location = new Point(129, 235);
            label3.Name = "label3";
            label3.Size = new Size(329, 50);
            label3.TabIndex = 11;
            label3.Text = "Código do Livro";
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
            txtBipeLivro.TabIndex = 12;
            txtBipeLivro.Text = "Bipe seu livro aqui";
            txtBipeLivro.TextAlign = HorizontalAlignment.Center;
            txtBipeLivro.Enter += txtBipeLivro_Enter;
            txtBipeLivro.Leave += txtBipeLivro_Leave;
            // 
            // btnLocalizar
            // 
            btnLocalizar.BackColor = Color.Transparent;
            btnLocalizar.FlatAppearance.BorderSize = 0;
            btnLocalizar.FlatStyle = FlatStyle.Flat;
            btnLocalizar.Font = new Font("Arial", 16F);
            btnLocalizar.ForeColor = Color.White;
            btnLocalizar.Location = new Point(216, 443);
            btnLocalizar.Name = "btnLocalizar";
            btnLocalizar.Size = new Size(159, 49);
            btnLocalizar.TabIndex = 13;
            btnLocalizar.Text = "Localizar";
            btnLocalizar.UseVisualStyleBackColor = false;
            btnLocalizar.Click += btnLocalizar_Click;
            // 
            // btnVoltar
            // 
            btnVoltar.BackColor = SystemColors.ButtonHighlight;
            btnVoltar.FlatAppearance.BorderSize = 0;
            btnVoltar.FlatStyle = FlatStyle.Flat;
            btnVoltar.Location = new Point(498, 660);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(70, 34);
            btnVoltar.TabIndex = 14;
            btnVoltar.Text = "Voltar";
            btnVoltar.UseVisualStyleBackColor = false;
            btnVoltar.Click += btnVoltar_Click;
            // 
            // DevolucaoAluno
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources._5;
            ClientSize = new Size(580, 738);
            Controls.Add(btnVoltar);
            Controls.Add(btnLocalizar);
            Controls.Add(txtBipeLivro);
            Controls.Add(label3);
            FormBorderStyle = FormBorderStyle.None;
            Name = "DevolucaoAluno";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DevolucaoAluno";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private TextBox txtBipeLivro;
        private Button btnLocalizar;
        private Button btnVoltar;
    }
}