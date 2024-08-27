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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InicioDeSesion));
            panel1 = new Panel();
            BotonCancelar = new Button();
            BotonIngresar = new Button();
            textBoxContra = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            textBoxUsuario = new TextBox();
            pictureBox1 = new PictureBox();
            iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            label1 = new Label();
            label6 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(iconPictureBox1);
            panel1.Controls.Add(BotonCancelar);
            panel1.Controls.Add(BotonIngresar);
            panel1.Controls.Add(textBoxContra);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(textBoxUsuario);
            panel1.Location = new Point(53, 51);
            panel1.Name = "panel1";
            panel1.Size = new Size(401, 479);
            panel1.TabIndex = 0;
            // 
            // BotonCancelar
            // 
            BotonCancelar.BackColor = Color.Transparent;
            BotonCancelar.FlatAppearance.BorderColor = Color.White;
            BotonCancelar.FlatStyle = FlatStyle.Flat;
            BotonCancelar.ForeColor = SystemColors.ControlLightLight;
            BotonCancelar.Location = new Point(198, 340);
            BotonCancelar.Name = "BotonCancelar";
            BotonCancelar.Size = new Size(143, 60);
            BotonCancelar.TabIndex = 20;
            BotonCancelar.Text = "Cancelar";
            BotonCancelar.UseVisualStyleBackColor = false;
            BotonCancelar.Click += BotonCancelar_Click;
            // 
            // BotonIngresar
            // 
            BotonIngresar.BackColor = Color.Transparent;
            BotonIngresar.FlatAppearance.BorderColor = Color.White;
            BotonIngresar.FlatStyle = FlatStyle.Flat;
            BotonIngresar.ForeColor = SystemColors.ControlLightLight;
            BotonIngresar.Location = new Point(49, 340);
            BotonIngresar.Name = "BotonIngresar";
            BotonIngresar.Size = new Size(143, 60);
            BotonIngresar.TabIndex = 19;
            BotonIngresar.Text = "INGRESAR";
            BotonIngresar.UseVisualStyleBackColor = false;
            BotonIngresar.Click += BotonIngresar_Click;
            // 
            // textBoxContra
            // 
            textBoxContra.BackColor = Color.FromArgb(80, 96, 130);
            textBoxContra.ForeColor = SystemColors.Window;
            textBoxContra.Location = new Point(75, 296);
            textBoxContra.Name = "textBoxContra";
            textBoxContra.Size = new Size(240, 23);
            textBoxContra.TabIndex = 16;
            textBoxContra.TextChanged += textBoxContra_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = SystemColors.ButtonFace;
            label5.Location = new Point(123, 506);
            label5.Name = "label5";
            label5.Size = new Size(128, 15);
            label5.TabIndex = 7;
            label5.Text = "Crea una nueva cuenta";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = SystemColors.ButtonFace;
            label4.Location = new Point(123, 420);
            label4.Name = "label4";
            label4.Size = new Size(141, 15);
            label4.TabIndex = 5;
            label4.Text = "¿Olvidaste tu contraseña?";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.ButtonFace;
            label3.Location = new Point(75, 278);
            label3.Name = "label3";
            label3.Size = new Size(67, 15);
            label3.TabIndex = 4;
            label3.Text = "Contraseña";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(75, 218);
            label2.Name = "label2";
            label2.Size = new Size(109, 15);
            label2.TabIndex = 3;
            label2.Text = "Nombre de usuario";
            // 
            // textBoxUsuario
            // 
            textBoxUsuario.BackColor = Color.FromArgb(80, 96, 130);
            textBoxUsuario.ForeColor = SystemColors.Window;
            textBoxUsuario.Location = new Point(75, 236);
            textBoxUsuario.Name = "textBoxUsuario";
            textBoxUsuario.Size = new Size(240, 23);
            textBoxUsuario.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1093, 596);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // iconPictureBox1
            // 
            iconPictureBox1.BackColor = Color.Transparent;
            iconPictureBox1.ForeColor = SystemColors.ButtonFace;
            iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Hospital;
            iconPictureBox1.IconColor = SystemColors.ButtonFace;
            iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox1.IconSize = 138;
            iconPictureBox1.Location = new Point(123, 4);
            iconPictureBox1.Name = "iconPictureBox1";
            iconPictureBox1.Size = new Size(207, 138);
            iconPictureBox1.TabIndex = 21;
            iconPictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Unispace", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(43, 145);
            label1.Name = "label1";
            label1.Size = new Size(298, 29);
            label1.TabIndex = 22;
            label1.Text = "SISTEMA DE GESTION \r\n";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Unispace", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.Control;
            label6.Location = new Point(97, 174);
            label6.Name = "label6";
            label6.Size = new Size(178, 29);
            label6.TabIndex = 23;
            label6.Text = "DE HOSPITAL\r\n";
            // 
            // InicioDeSesion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(1093, 596);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "InicioDeSesion";
            Text = "InicioDeSesion";
            Load += InicioDeSesion_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox textBoxUsuario;
        private TextBox textBoxContra;
        private Button BotonIngresar;
        private Button BotonCancelar;
        private PictureBox pictureBox1;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private Label label1;
        private Label label6;
    }
}