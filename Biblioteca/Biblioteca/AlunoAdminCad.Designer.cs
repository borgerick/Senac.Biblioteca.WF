namespace Biblioteca
{
    partial class AlunoAdminCad
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
            label1 = new Label();
            txtLogin = new TextBox();
            btnAdicionar = new Button();
            button1 = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(255, 128, 0);
            label1.Font = new Font("Segoe UI", 14F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(16, 25);
            label1.Name = "label1";
            label1.Size = new Size(416, 38);
            label1.TabIndex = 11;
            label1.Text = "Insira as informações do ALUNO";
            // 
            // txtLogin
            // 
            txtLogin.BackColor = Color.Gainsboro;
            txtLogin.BorderStyle = BorderStyle.None;
            txtLogin.Font = new Font("Arial", 14F);
            txtLogin.ForeColor = Color.Black;
            txtLogin.Location = new Point(34, 112);
            txtLogin.Name = "txtLogin";
            txtLogin.Size = new Size(361, 33);
            txtLogin.TabIndex = 12;
            txtLogin.Text = "Nome";
            // 
            // btnAdicionar
            // 
            btnAdicionar.BackColor = Color.ForestGreen;
            btnAdicionar.FlatAppearance.BorderSize = 0;
            btnAdicionar.FlatStyle = FlatStyle.Flat;
            btnAdicionar.Font = new Font("Arial", 12F);
            btnAdicionar.ForeColor = Color.White;
            btnAdicionar.Location = new Point(34, 393);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(154, 36);
            btnAdicionar.TabIndex = 13;
            btnAdicionar.Text = "Adicionar";
            btnAdicionar.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.Red;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Arial", 12F);
            button1.ForeColor = Color.White;
            button1.Location = new Point(241, 393);
            button1.Name = "button1";
            button1.Size = new Size(154, 36);
            button1.TabIndex = 14;
            button1.Text = "Cancelar";
            button1.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.Gainsboro;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Arial", 14F);
            textBox1.ForeColor = Color.Black;
            textBox1.Location = new Point(34, 165);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(361, 33);
            textBox1.TabIndex = 15;
            textBox1.Text = "Sobrenome";
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.Gainsboro;
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Font = new Font("Arial", 14F);
            textBox2.ForeColor = Color.Black;
            textBox2.Location = new Point(34, 217);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(361, 33);
            textBox2.TabIndex = 16;
            textBox2.Text = "E-mail";
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.Gainsboro;
            textBox3.BorderStyle = BorderStyle.None;
            textBox3.Font = new Font("Arial", 14F);
            textBox3.ForeColor = Color.Black;
            textBox3.Location = new Point(34, 268);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(361, 33);
            textBox3.TabIndex = 17;
            textBox3.Text = "Telefone";
            // 
            // textBox4
            // 
            textBox4.BackColor = Color.Gainsboro;
            textBox4.BorderStyle = BorderStyle.None;
            textBox4.Font = new Font("Arial", 14F);
            textBox4.ForeColor = Color.Black;
            textBox4.Location = new Point(34, 317);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(361, 33);
            textBox4.TabIndex = 18;
            textBox4.Text = "Matricula";
            // 
            // AlunoAdminCad
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(448, 453);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Controls.Add(btnAdicionar);
            Controls.Add(txtLogin);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AlunoAdminCad";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AlunoAdminCad";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtLogin;
        private Button btnAdicionar;
        private Button button1;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
    }
}