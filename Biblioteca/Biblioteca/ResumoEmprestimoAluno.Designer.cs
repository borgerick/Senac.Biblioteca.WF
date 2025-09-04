namespace Biblioteca
{
    partial class ResumoEmprestimoAluno
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
            btnVoltar = new Button();
            lblNumeroReserva = new Label();
            lblAluno = new Label();
            lblRetirada = new Label();
            lblDevolucao = new Label();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Arial", 22F);
            label3.ForeColor = Color.White;
            label3.Location = new Point(24, 90);
            label3.Name = "label3";
            label3.Size = new Size(422, 50);
            label3.TabIndex = 10;
            label3.Text = "Resumo da Reserva";
            // 
            // btnVoltar
            // 
            btnVoltar.BackColor = SystemColors.ButtonHighlight;
            btnVoltar.FlatAppearance.BorderSize = 0;
            btnVoltar.FlatStyle = FlatStyle.Flat;
            btnVoltar.Location = new Point(498, 660);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(70, 34);
            btnVoltar.TabIndex = 12;
            btnVoltar.Text = "Voltar";
            btnVoltar.UseVisualStyleBackColor = false;
            btnVoltar.Click += btnVoltar_Click;
            // 
            // lblNumeroReserva
            // 
            lblNumeroReserva.AutoSize = true;
            lblNumeroReserva.BackColor = Color.Transparent;
            lblNumeroReserva.Font = new Font("Arial", 12F);
            lblNumeroReserva.ForeColor = Color.White;
            lblNumeroReserva.Location = new Point(24, 284);
            lblNumeroReserva.Name = "lblNumeroReserva";
            lblNumeroReserva.Size = new Size(210, 27);
            lblNumeroReserva.TabIndex = 13;
            lblNumeroReserva.Text = "lblNumeroReserva";
            // 
            // lblAluno
            // 
            lblAluno.AutoSize = true;
            lblAluno.BackColor = Color.Transparent;
            lblAluno.Font = new Font("Arial", 12F);
            lblAluno.ForeColor = Color.White;
            lblAluno.Location = new Point(24, 333);
            lblAluno.Name = "lblAluno";
            lblAluno.Size = new Size(100, 27);
            lblAluno.TabIndex = 14;
            lblAluno.Text = "lblAluno";
            // 
            // lblRetirada
            // 
            lblRetirada.AutoSize = true;
            lblRetirada.BackColor = Color.Transparent;
            lblRetirada.Font = new Font("Arial", 12F);
            lblRetirada.ForeColor = Color.White;
            lblRetirada.Location = new Point(24, 381);
            lblRetirada.Name = "lblRetirada";
            lblRetirada.Size = new Size(128, 27);
            lblRetirada.TabIndex = 15;
            lblRetirada.Text = "lblRetirada";
            // 
            // lblDevolucao
            // 
            lblDevolucao.AutoSize = true;
            lblDevolucao.BackColor = Color.Transparent;
            lblDevolucao.Font = new Font("Arial", 12F);
            lblDevolucao.ForeColor = Color.White;
            lblDevolucao.Location = new Point(24, 431);
            lblDevolucao.Name = "lblDevolucao";
            lblDevolucao.Size = new Size(150, 27);
            lblDevolucao.TabIndex = 16;
            lblDevolucao.Text = "lblDevolucao";
            // 
            // ResumoEmprestimoAluno
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Resumo_Emprestimo;
            ClientSize = new Size(580, 738);
            Controls.Add(lblDevolucao);
            Controls.Add(lblRetirada);
            Controls.Add(lblAluno);
            Controls.Add(lblNumeroReserva);
            Controls.Add(btnVoltar);
            Controls.Add(label3);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "ResumoEmprestimoAluno";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ResumoEmprestimoAluno";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label3;
        private Button btnVoltar;
        private Label lblNumeroReserva;
        private Label lblAluno;
        private Label lblRetirada;
        private Label lblDevolucao;
    }
}