namespace Biblioteca
{
    partial class LoginAluno
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginAluno));
            txtCPF = new TextBox();
            btnEntrar = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btnVoltar = new Button();
            SuspendLayout();
            // 
            // txtCPF
            // 
            txtCPF.BackColor = Color.Gainsboro;
            txtCPF.BorderStyle = BorderStyle.None;
            txtCPF.Font = new Font("Arial", 14F);
            txtCPF.ForeColor = SystemColors.ControlDark;
            txtCPF.Location = new Point(147, 317);
            txtCPF.Name = "txtCPF";
            txtCPF.Size = new Size(287, 33);
            txtCPF.TabIndex = 5;
            txtCPF.Text = "Digite seu CPF";
            txtCPF.TextAlign = HorizontalAlignment.Center;
            // 
            // btnEntrar
            // 
            btnEntrar.BackColor = Color.Transparent;
            btnEntrar.FlatAppearance.BorderSize = 0;
            btnEntrar.FlatStyle = FlatStyle.Flat;
            btnEntrar.Font = new Font("Arial", 16F);
            btnEntrar.ForeColor = Color.White;
            btnEntrar.Location = new Point(213, 442);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.Size = new Size(159, 49);
            btnEntrar.TabIndex = 6;
            btnEntrar.Text = "Entrar";
            btnEntrar.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Segoe UI", 8F);
            label1.ForeColor = SystemColors.ControlDarkDark;
            label1.Location = new Point(125, 378);
            label1.Name = "label1";
            label1.Size = new Size(321, 21);
            label1.TabIndex = 7;
            label1.Text = "Não utilize pontos e hifen conforme exemplo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 8F);
            label2.ForeColor = SystemColors.ControlDarkDark;
            label2.Location = new Point(152, 396);
            label2.Name = "label2";
            label2.Size = new Size(257, 21);
            label2.TabIndex = 8;
            label2.Text = "123.456.789-10 ---> 12345678910";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Arial", 22F);
            label3.ForeColor = Color.White;
            label3.Location = new Point(171, 227);
            label3.Name = "label3";
            label3.Size = new Size(250, 50);
            label3.TabIndex = 9;
            label3.Text = "Login Aluno";
            // 
            // btnVoltar
            // 
            btnVoltar.BackColor = SystemColors.ButtonHighlight;
            btnVoltar.FlatAppearance.BorderSize = 0;
            btnVoltar.FlatStyle = FlatStyle.Flat;
            btnVoltar.Location = new Point(456, 659);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(112, 34);
            btnVoltar.TabIndex = 10;
            btnVoltar.Text = "Voltar";
            btnVoltar.UseVisualStyleBackColor = false;
            btnVoltar.Click += btnVoltar_Click;
            // 
            // LoginAluno
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(580, 738);
            Controls.Add(btnVoltar);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnEntrar);
            Controls.Add(txtCPF);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "LoginAluno";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CpfAluno";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtCPF;
        private Button btnEntrar;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnVoltar;
    }
}