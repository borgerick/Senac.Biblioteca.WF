namespace Biblioteca
{
    partial class LoginAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginAdmin));
            label2 = new Label();
            txtLogin = new TextBox();
            txtSenha = new TextBox();
            btnEntrar = new Button();
            btnVoltar = new Button();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Arial", 22F);
            label2.ForeColor = Color.DarkOrange;
            label2.Location = new Point(157, 237);
            label2.Name = "label2";
            label2.Size = new Size(264, 50);
            label2.TabIndex = 3;
            label2.Text = "Login Admin";
            // 
            // txtLogin
            // 
            txtLogin.BackColor = Color.Gainsboro;
            txtLogin.BorderStyle = BorderStyle.None;
            txtLogin.Font = new Font("Arial", 14F);
            txtLogin.ForeColor = SystemColors.ControlDark;
            txtLogin.Location = new Point(145, 319);
            txtLogin.Name = "txtLogin";
            txtLogin.Size = new Size(287, 33);
            txtLogin.TabIndex = 4;
            txtLogin.Text = "Usuário";
            txtLogin.Enter += txtLogin_Enter;
            txtLogin.Leave += txtLogin_Leave;
            // 
            // txtSenha
            // 
            txtSenha.BackColor = Color.Gainsboro;
            txtSenha.BorderStyle = BorderStyle.None;
            txtSenha.Font = new Font("Arial", 14F);
            txtSenha.ForeColor = SystemColors.ControlDark;
            txtSenha.Location = new Point(145, 384);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(287, 33);
            txtSenha.TabIndex = 5;
            txtSenha.Text = "Senha";
            txtSenha.Enter += txtSenha_Enter;
            txtSenha.Leave += txtSenha_Leave;
            // 
            // btnEntrar
            // 
            btnEntrar.BackColor = Color.Transparent;
            btnEntrar.FlatAppearance.BorderSize = 0;
            btnEntrar.FlatStyle = FlatStyle.Flat;
            btnEntrar.Font = new Font("Arial", 16F);
            btnEntrar.ForeColor = Color.White;
            btnEntrar.Location = new Point(213, 468);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.Size = new Size(159, 49);
            btnEntrar.TabIndex = 2;
            btnEntrar.Text = "Entrar";
            btnEntrar.UseVisualStyleBackColor = false;
            btnEntrar.Click += btnEntrar_Click;
            // 
            // btnVoltar
            // 
            btnVoltar.BackColor = SystemColors.ButtonHighlight;
            btnVoltar.FlatAppearance.BorderSize = 0;
            btnVoltar.FlatStyle = FlatStyle.Flat;
            btnVoltar.Location = new Point(498, 660);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(70, 34);
            btnVoltar.TabIndex = 6;
            btnVoltar.Text = "Voltar";
            btnVoltar.UseVisualStyleBackColor = false;
            btnVoltar.Click += btnVoltar_Click;
            // 
            // LoginAdmin
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(580, 738);
            Controls.Add(btnVoltar);
            Controls.Add(btnEntrar);
            Controls.Add(txtSenha);
            Controls.Add(txtLogin);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "LoginAdmin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LoginAdmin";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private TextBox txtLogin;
        private TextBox txtSenha;
        private Button btnEntrar;
        private Button btnVoltar;
    }
}