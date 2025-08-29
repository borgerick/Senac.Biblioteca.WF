namespace Biblioteca
{
    partial class LivroAdminCad
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
            txtLogin = new TextBox();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            btnAdicionar = new Button();
            button1 = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // txtLogin
            // 
            txtLogin.BackColor = Color.Gainsboro;
            txtLogin.BorderStyle = BorderStyle.None;
            txtLogin.Font = new Font("Arial", 14F);
            txtLogin.ForeColor = Color.Black;
            txtLogin.Location = new Point(58, 105);
            txtLogin.Name = "txtLogin";
            txtLogin.Size = new Size(361, 33);
            txtLogin.TabIndex = 5;
            txtLogin.Text = "Titulo";
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.Gainsboro;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Arial", 14F);
            textBox1.ForeColor = Color.Black;
            textBox1.Location = new Point(58, 168);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(361, 33);
            textBox1.TabIndex = 6;
            textBox1.Text = "Autor";
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.Gainsboro;
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Font = new Font("Arial", 14F);
            textBox2.ForeColor = Color.Black;
            textBox2.Location = new Point(58, 233);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(361, 33);
            textBox2.TabIndex = 7;
            textBox2.Text = "Categoria";
            // 
            // btnAdicionar
            // 
            btnAdicionar.BackColor = Color.ForestGreen;
            btnAdicionar.FlatAppearance.BorderSize = 0;
            btnAdicionar.FlatStyle = FlatStyle.Flat;
            btnAdicionar.Font = new Font("Arial", 12F);
            btnAdicionar.ForeColor = Color.White;
            btnAdicionar.Location = new Point(58, 301);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(154, 36);
            btnAdicionar.TabIndex = 8;
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
            button1.Location = new Point(265, 301);
            button1.Name = "button1";
            button1.Size = new Size(154, 36);
            button1.TabIndex = 9;
            button1.Text = "Cancelar";
            button1.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.SteelBlue;
            label1.Font = new Font("Segoe UI", 14F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(45, 32);
            label1.Name = "label1";
            label1.Size = new Size(378, 38);
            label1.TabIndex = 10;
            label1.Text = "Insira as informações do livro";
            // 
            // LivroAdminCad
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(470, 367);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(btnAdicionar);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(txtLogin);
            FormBorderStyle = FormBorderStyle.None;
            Name = "LivroAdminCad";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LivroAdminCad";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtLogin;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button btnAdicionar;
        private Button button1;
        private Label label1;
    }
}