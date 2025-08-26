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
            btnInicio = new Button();
            label3 = new Label();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnInicio
            // 
            btnInicio.BackColor = Color.DarkOrange;
            btnInicio.FlatAppearance.BorderSize = 0;
            btnInicio.FlatStyle = FlatStyle.Flat;
            btnInicio.Font = new Font("Arial", 12F);
            btnInicio.ForeColor = Color.White;
            btnInicio.Location = new Point(491, 653);
            btnInicio.Name = "btnInicio";
            btnInicio.Size = new Size(90, 42);
            btnInicio.TabIndex = 8;
            btnInicio.Text = "Início";
            btnInicio.UseVisualStyleBackColor = false;
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
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(24, 192);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(422, 306);
            dataGridView1.TabIndex = 11;
            // 
            // ResumoEmprestimoAluno
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Resumo_Emprestimo;
            ClientSize = new Size(580, 738);
            Controls.Add(dataGridView1);
            Controls.Add(label3);
            Controls.Add(btnInicio);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "ResumoEmprestimoAluno";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ResumoEmprestimoAluno";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnInicio;
        private Label label3;
        private DataGridView dataGridView1;
    }
}