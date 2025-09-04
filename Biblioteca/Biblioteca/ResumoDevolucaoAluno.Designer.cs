namespace Biblioteca
{
    partial class ResumoDevolucaoAluno
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ResumoDevolucaoAluno));
            label3 = new Label();
            lblNumeroReserva = new Label();
            lblAluno = new Label();
            lblLivro = new Label();
            lblDevolucao = new Label();
            btnVoltar = new Button();
            lblDiasReserva = new Label();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Arial", 22F);
            label3.ForeColor = Color.White;
            label3.Location = new Point(5, 89);
            label3.Name = "label3";
            label3.Size = new Size(465, 50);
            label3.TabIndex = 11;
            label3.Text = "Resumo da Devolução";
            // 
            // lblNumeroReserva
            // 
            lblNumeroReserva.AutoSize = true;
            lblNumeroReserva.BackColor = Color.Transparent;
            lblNumeroReserva.Font = new Font("Arial", 12F);
            lblNumeroReserva.ForeColor = Color.White;
            lblNumeroReserva.Location = new Point(32, 233);
            lblNumeroReserva.Name = "lblNumeroReserva";
            lblNumeroReserva.Size = new Size(210, 27);
            lblNumeroReserva.TabIndex = 14;
            lblNumeroReserva.Text = "lblNumeroReserva";
            // 
            // lblAluno
            // 
            lblAluno.AutoSize = true;
            lblAluno.BackColor = Color.Transparent;
            lblAluno.Font = new Font("Arial", 12F);
            lblAluno.ForeColor = Color.White;
            lblAluno.Location = new Point(32, 290);
            lblAluno.Name = "lblAluno";
            lblAluno.Size = new Size(100, 27);
            lblAluno.TabIndex = 15;
            lblAluno.Text = "lblAluno";
            // 
            // lblLivro
            // 
            lblLivro.AutoSize = true;
            lblLivro.BackColor = Color.Transparent;
            lblLivro.Font = new Font("Arial", 12F);
            lblLivro.ForeColor = Color.White;
            lblLivro.Location = new Point(32, 345);
            lblLivro.Name = "lblLivro";
            lblLivro.Size = new Size(88, 27);
            lblLivro.TabIndex = 16;
            lblLivro.Text = "lblLivro";
            // 
            // lblDevolucao
            // 
            lblDevolucao.AutoSize = true;
            lblDevolucao.BackColor = Color.Transparent;
            lblDevolucao.Font = new Font("Arial", 12F);
            lblDevolucao.ForeColor = Color.White;
            lblDevolucao.Location = new Point(32, 393);
            lblDevolucao.Name = "lblDevolucao";
            lblDevolucao.Size = new Size(150, 27);
            lblDevolucao.TabIndex = 17;
            lblDevolucao.Text = "lblDevolucao";
            // 
            // btnVoltar
            // 
            btnVoltar.BackColor = SystemColors.ButtonHighlight;
            btnVoltar.FlatAppearance.BorderSize = 0;
            btnVoltar.FlatStyle = FlatStyle.Flat;
            btnVoltar.Location = new Point(498, 660);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(70, 34);
            btnVoltar.TabIndex = 18;
            btnVoltar.Text = "Voltar";
            btnVoltar.UseVisualStyleBackColor = false;
            btnVoltar.Click += btnVoltar_Click;
            // 
            // lblDiasReserva
            // 
            lblDiasReserva.AutoSize = true;
            lblDiasReserva.BackColor = Color.Transparent;
            lblDiasReserva.Font = new Font("Arial", 12F);
            lblDiasReserva.ForeColor = Color.White;
            lblDiasReserva.Location = new Point(32, 439);
            lblDiasReserva.Name = "lblDiasReserva";
            lblDiasReserva.Size = new Size(172, 27);
            lblDiasReserva.TabIndex = 19;
            lblDiasReserva.Text = "lblDiasReserva";
            // 
            // ResumoDevolucaoAluno
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(580, 738);
            Controls.Add(lblDiasReserva);
            Controls.Add(btnVoltar);
            Controls.Add(lblDevolucao);
            Controls.Add(lblLivro);
            Controls.Add(lblAluno);
            Controls.Add(lblNumeroReserva);
            Controls.Add(label3);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ResumoDevolucaoAluno";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ResumoDevolucaoAluno";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private Label lblNumeroReserva;
        private Label lblAluno;
        private Label lblLivro;
        private Label lblDevolucao;
        private Button btnVoltar;
        private Label lblDiasReserva;
    }
}