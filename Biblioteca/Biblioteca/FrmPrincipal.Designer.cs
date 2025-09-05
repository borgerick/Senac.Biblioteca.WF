namespace Biblioteca
{
    partial class FrmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            btnAdmin = new Button();
            btnAluno = new Button();
            btnfechar = new Button();
            SuspendLayout();
            // 
            // btnAdmin
            // 
            btnAdmin.BackColor = Color.Transparent;
            btnAdmin.FlatAppearance.BorderSize = 0;
            btnAdmin.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnAdmin.FlatAppearance.MouseOverBackColor = Color.Orange;
            btnAdmin.FlatStyle = FlatStyle.Flat;
            btnAdmin.Font = new Font("Arial", 28F);
            btnAdmin.ForeColor = Color.White;
            btnAdmin.Location = new Point(2, 277);
            btnAdmin.Name = "btnAdmin";
            btnAdmin.Size = new Size(347, 133);
            btnAdmin.TabIndex = 3;
            btnAdmin.Text = "Admin";
            btnAdmin.UseVisualStyleBackColor = false;
            btnAdmin.Click += btnAdmin_Click;
            // 
            // btnAluno
            // 
            btnAluno.BackColor = Color.Transparent;
            btnAluno.FlatAppearance.BorderSize = 0;
            btnAluno.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnAluno.FlatAppearance.MouseOverBackColor = Color.Blue;
            btnAluno.FlatStyle = FlatStyle.Flat;
            btnAluno.Font = new Font("Arial", 28F);
            btnAluno.ForeColor = Color.White;
            btnAluno.Location = new Point(186, 454);
            btnAluno.Name = "btnAluno";
            btnAluno.Size = new Size(394, 130);
            btnAluno.TabIndex = 5;
            btnAluno.Text = "Aluno";
            btnAluno.UseVisualStyleBackColor = false;
            btnAluno.Click += btnAlun_Click;
            // 
            // btnfechar
            // 
            btnfechar.BackColor = Color.White;
            btnfechar.FlatAppearance.BorderSize = 0;
            btnfechar.FlatStyle = FlatStyle.Flat;
            btnfechar.ForeColor = Color.White;
            btnfechar.Location = new Point(511, 754);
            btnfechar.Name = "btnfechar";
            btnfechar.Size = new Size(69, 27);
            btnfechar.TabIndex = 6;
            btnfechar.Text = "fechar";
            btnfechar.UseVisualStyleBackColor = false;
            btnfechar.Click += btnfechar_Click;
            // 
            // FrmPrincipal
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(580, 774);
            Controls.Add(btnfechar);
            Controls.Add(btnAluno);
            Controls.Add(btnAdmin);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2);
            Name = "FrmPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmPrincipal";
            ResumeLayout(false);
        }

        #endregion

        private Button btnAdmin;
        private Button btnAluno;
        private Button btnfechar;
    }
}