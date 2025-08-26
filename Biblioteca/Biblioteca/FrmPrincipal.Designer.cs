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
            btnDevolver = new Button();
            btnAlun = new Button();
            SuspendLayout();
            // 
            // btnAdmin
            // 
            btnAdmin.BackColor = Color.Transparent;
            btnAdmin.FlatAppearance.BorderSize = 0;
            btnAdmin.FlatStyle = FlatStyle.Flat;
            btnAdmin.Font = new Font("Arial", 22F);
            btnAdmin.ForeColor = Color.White;
            btnAdmin.Location = new Point(2, 203);
            btnAdmin.Name = "btnAdmin";
            btnAdmin.Size = new Size(211, 133);
            btnAdmin.TabIndex = 3;
            btnAdmin.Text = "Admin";
            btnAdmin.TextAlign = ContentAlignment.MiddleLeft;
            btnAdmin.UseVisualStyleBackColor = false;
            btnAdmin.Click += btnAdmin_Click;
            // 
            // btnDevolver
            // 
            btnDevolver.BackColor = Color.Transparent;
            btnDevolver.FlatAppearance.BorderSize = 0;
            btnDevolver.FlatStyle = FlatStyle.Flat;
            btnDevolver.Font = new Font("Arial", 22F);
            btnDevolver.ForeColor = Color.White;
            btnDevolver.Location = new Point(2, 374);
            btnDevolver.Name = "btnDevolver";
            btnDevolver.Size = new Size(349, 133);
            btnDevolver.TabIndex = 4;
            btnDevolver.Text = "Devolver";
            btnDevolver.TextAlign = ContentAlignment.MiddleLeft;
            btnDevolver.UseVisualStyleBackColor = false;
            btnDevolver.Click += btnDevolver_Click;
            // 
            // btnAlun
            // 
            btnAlun.BackColor = Color.Transparent;
            btnAlun.FlatAppearance.BorderSize = 0;
            btnAlun.FlatStyle = FlatStyle.Flat;
            btnAlun.Font = new Font("Arial", 22F);
            btnAlun.ForeColor = Color.White;
            btnAlun.Location = new Point(2, 547);
            btnAlun.Name = "btnAlun";
            btnAlun.Size = new Size(511, 133);
            btnAlun.TabIndex = 5;
            btnAlun.Text = "Aluno";
            btnAlun.TextAlign = ContentAlignment.MiddleLeft;
            btnAlun.UseVisualStyleBackColor = false;
            btnAlun.Click += btnAlun_Click;
            // 
            // FrmPrincipal
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(580, 738);
            Controls.Add(btnAlun);
            Controls.Add(btnDevolver);
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
        private Button btnDevolver;
        private Button btnAlun;
    }
}