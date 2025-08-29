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
            btnInicio = new Button();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
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
            // btnInicio
            // 
            btnInicio.BackColor = Color.DarkOrange;
            btnInicio.FlatAppearance.BorderSize = 0;
            btnInicio.FlatStyle = FlatStyle.Flat;
            btnInicio.Font = new Font("Arial", 12F);
            btnInicio.ForeColor = Color.White;
            btnInicio.Location = new Point(489, 659);
            btnInicio.Name = "btnInicio";
            btnInicio.Size = new Size(90, 42);
            btnInicio.TabIndex = 12;
            btnInicio.Text = "Início";
            btnInicio.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(24, 157);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(422, 342);
            dataGridView1.TabIndex = 13;
            // 
            // ResumoDevolucaoAluno
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(580, 738);
            Controls.Add(dataGridView1);
            Controls.Add(btnInicio);
            Controls.Add(label3);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ResumoDevolucaoAluno";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ResumoDevolucaoAluno";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private Button btnInicio;
        private DataGridView dataGridView1;
    }
}