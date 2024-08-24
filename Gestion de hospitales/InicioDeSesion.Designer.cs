namespace Gestion_de_hospitales
{
    partial class InicioDeSesion
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
            panel1 = new Panel();
            label5 = new Label();
            button1 = new Button();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            textBox2 = new TextBox();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Control;
            panel1.Controls.Add(label5);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(299, 68);
            panel1.Name = "panel1";
            panel1.Size = new Size(413, 403);
            panel1.TabIndex = 0;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(147, 313);
            label5.Name = "label5";
            label5.Size = new Size(128, 15);
            label5.TabIndex = 7;
            label5.Text = "Crea una nueva cuenta";
            // 
            // button1
            // 
            button1.Location = new Point(107, 242);
            button1.Name = "button1";
            button1.Size = new Size(204, 59);
            button1.TabIndex = 6;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(134, 196);
            label4.Name = "label4";
            label4.Size = new Size(141, 15);
            label4.TabIndex = 5;
            label4.Text = "¿Olvidaste tu contraseña?";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(107, 143);
            label3.Name = "label3";
            label3.Size = new Size(67, 15);
            label3.TabIndex = 4;
            label3.Text = "Contraseña";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(107, 84);
            label2.Name = "label2";
            label2.Size = new Size(109, 15);
            label2.TabIndex = 3;
            label2.Text = "Nombre de usuario";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(107, 161);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(204, 23);
            textBox2.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(161, 19);
            label1.Name = "label1";
            label1.Size = new Size(69, 15);
            label1.TabIndex = 0;
            label1.Text = "Bienvenido!";
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1066, 597);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // InicioDeSesion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1066, 597);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Name = "InicioDeSesion";
            Text = "InicioDeSesion";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label5;
        private Button button1;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox textBox2;
        private Label label1;
        private PictureBox pictureBox1;
    }
}