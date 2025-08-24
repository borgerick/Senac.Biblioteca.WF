namespace Biblioteca
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            Reservar = new Button();
            button2 = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // Reservar
            // 
            Reservar.BackColor = Color.Transparent;
            Reservar.Cursor = Cursors.IBeam;
            Reservar.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 0, 0);
            Reservar.FlatAppearance.BorderSize = 0;
            Reservar.FlatAppearance.MouseDownBackColor = Color.Transparent;
            Reservar.FlatAppearance.MouseOverBackColor = Color.Transparent;
            Reservar.FlatStyle = FlatStyle.Flat;
            Reservar.Font = new Font("Myanmar Text", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Reservar.ForeColor = Color.White;
            Reservar.Location = new Point(-1, 207);
            Reservar.Name = "Reservar";
            Reservar.Size = new Size(215, 125);
            Reservar.TabIndex = 1;
            Reservar.Text = "Reservar";
            Reservar.TextAlign = ContentAlignment.MiddleLeft;
            Reservar.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.Transparent;
            button2.Cursor = Cursors.IBeam;
            button2.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 0, 0);
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button2.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Myanmar Text", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(-1, 376);
            button2.Name = "button2";
            button2.Size = new Size(346, 125);
            button2.TabIndex = 2;
            button2.Text = "Devolver";
            button2.TextAlign = ContentAlignment.MiddleLeft;
            button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.Transparent;
            button3.Cursor = Cursors.IBeam;
            button3.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 0, 0);
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button3.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Myanmar Text", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.White;
            button3.Location = new Point(-1, 551);
            button3.Name = "button3";
            button3.Size = new Size(512, 125);
            button3.TabIndex = 3;
            button3.Text = "Administrador";
            button3.TextAlign = ContentAlignment.MiddleLeft;
            button3.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(577, 738);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(Reservar);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion
        private Button Reservar;
        private Button button2;
        private Button button3;
    }
}
