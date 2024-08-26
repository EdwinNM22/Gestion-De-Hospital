namespace Gestion_de_hospitales
{
    partial class GestionDePacientes
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewMain = new DataGridView();
            ColumnID = new DataGridViewTextBoxColumn();
            ColumnProducto = new DataGridViewTextBoxColumn();
            ColumnCantidadDeProducto = new DataGridViewTextBoxColumn();
            ColumnFormasDePago = new DataGridViewTextBoxColumn();
            ColumnPrecio = new DataGridViewTextBoxColumn();
            ColumnEmail = new DataGridViewTextBoxColumn();
            ColumnHistorialmedico = new DataGridViewTextBoxColumn();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            BoxProducto = new TextBox();
            BoxID = new TextBox();
            BoxPrecio = new TextBox();
            BoxFormasdepago = new TextBox();
            BoxCantidad = new TextBox();
            buttonAgregar = new Button();
            panel1 = new Panel();
            panel4 = new Panel();
            TextBoxBusqueda = new TextBox();
            ComboOrdenar = new ComboBox();
            label6 = new Label();
            label7 = new Label();
            panel2 = new Panel();
            button1 = new Button();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label10 = new Label();
            label9 = new Label();
            ((System.ComponentModel.ISupportInitialize)DataGridViewMain).BeginInit();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // DataGridViewMain
            // 
            DataGridViewMain.BackgroundColor = Color.FromArgb(36, 37, 38);
            DataGridViewMain.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(36, 37, 38);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.ControlDark;
            dataGridViewCellStyle1.SelectionForeColor = Color.RosyBrown;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            DataGridViewMain.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            DataGridViewMain.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridViewMain.Columns.AddRange(new DataGridViewColumn[] { ColumnID, ColumnProducto, ColumnCantidadDeProducto, ColumnFormasDePago, ColumnPrecio, ColumnEmail, ColumnHistorialmedico });
            DataGridViewMain.Dock = DockStyle.Bottom;
            DataGridViewMain.EnableHeadersVisualStyles = false;
            DataGridViewMain.Location = new Point(0, 422);
            DataGridViewMain.Name = "DataGridViewMain";
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(36, 37, 38);
            dataGridViewCellStyle2.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.Window;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.ControlDark;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            DataGridViewMain.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            DataGridViewMain.Size = new Size(1261, 289);
            DataGridViewMain.TabIndex = 0;
            DataGridViewMain.CellContentClick += DataGridViewMain_CellContentClick;
            // 
            // ColumnID
            // 
            ColumnID.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            ColumnID.HeaderText = "ID de paciente";
            ColumnID.Name = "ColumnID";
            ColumnID.Width = 75;
            // 
            // ColumnProducto
            // 
            ColumnProducto.HeaderText = "Nombre, apellido";
            ColumnProducto.Name = "ColumnProducto";
            ColumnProducto.Width = 250;
            // 
            // ColumnCantidadDeProducto
            // 
            ColumnCantidadDeProducto.HeaderText = "fecha de nacimiento";
            ColumnCantidadDeProducto.Name = "ColumnCantidadDeProducto";
            ColumnCantidadDeProducto.Width = 75;
            // 
            // ColumnFormasDePago
            // 
            ColumnFormasDePago.HeaderText = "Genero";
            ColumnFormasDePago.Name = "ColumnFormasDePago";
            ColumnFormasDePago.Width = 45;
            // 
            // ColumnPrecio
            // 
            ColumnPrecio.HeaderText = "telefono";
            ColumnPrecio.Name = "ColumnPrecio";
            ColumnPrecio.Width = 75;
            // 
            // ColumnEmail
            // 
            ColumnEmail.HeaderText = "Email";
            ColumnEmail.Name = "ColumnEmail";
            ColumnEmail.Width = 150;
            // 
            // ColumnHistorialmedico
            // 
            ColumnHistorialmedico.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ColumnHistorialmedico.HeaderText = "Historial Medico";
            ColumnHistorialmedico.Name = "ColumnHistorialmedico";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(15, 25);
            label1.Name = "label1";
            label1.Size = new Size(82, 15);
            label1.TabIndex = 1;
            label1.Text = "ID de paciente";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(13, 88);
            label2.Name = "label2";
            label2.Size = new Size(117, 15);
            label2.TabIndex = 2;
            label2.Text = "Fecha de nacimiento";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(15, 59);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 3;
            label3.Text = "Nombre";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = SystemColors.ControlLightLight;
            label4.Location = new Point(314, 24);
            label4.Name = "label4";
            label4.Size = new Size(52, 15);
            label4.TabIndex = 4;
            label4.Text = "Telefono";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = SystemColors.ControlLightLight;
            label5.Location = new Point(15, 117);
            label5.Name = "label5";
            label5.Size = new Size(45, 15);
            label5.TabIndex = 5;
            label5.Text = "Genero";
            // 
            // BoxProducto
            // 
            BoxProducto.Location = new Point(136, 51);
            BoxProducto.Name = "BoxProducto";
            BoxProducto.Size = new Size(160, 23);
            BoxProducto.TabIndex = 6;
            BoxProducto.TextChanged += BoxProducto_TextChanged;
            BoxProducto.KeyPress += BoxProducto_KeyPress;
            // 
            // BoxID
            // 
            BoxID.Location = new Point(136, 22);
            BoxID.Name = "BoxID";
            BoxID.Size = new Size(160, 23);
            BoxID.TabIndex = 7;
            BoxID.KeyPress += BoxId_KeyPress;
            // 
            // BoxPrecio
            // 
            BoxPrecio.Location = new Point(414, 22);
            BoxPrecio.Name = "BoxPrecio";
            BoxPrecio.Size = new Size(160, 23);
            BoxPrecio.TabIndex = 8;
            BoxPrecio.KeyPress += BoxPrecio_KeyPress;
            // 
            // BoxFormasdepago
            // 
            BoxFormasdepago.Location = new Point(136, 109);
            BoxFormasdepago.Name = "BoxFormasdepago";
            BoxFormasdepago.Size = new Size(160, 23);
            BoxFormasdepago.TabIndex = 9;
            BoxFormasdepago.TextChanged += BoxFormasdepago_TextChanged;
            BoxFormasdepago.KeyPress += BoxFormasdepago_Keypress;
            // 
            // BoxCantidad
            // 
            BoxCantidad.Location = new Point(136, 80);
            BoxCantidad.Name = "BoxCantidad";
            BoxCantidad.Size = new Size(160, 23);
            BoxCantidad.TabIndex = 10;
            BoxCantidad.KeyPress += BoxCantidad_KeyPress;
            // 
            // buttonAgregar
            // 
            buttonAgregar.FlatAppearance.BorderColor = Color.White;
            buttonAgregar.FlatStyle = FlatStyle.Flat;
            buttonAgregar.Location = new Point(27, 177);
            buttonAgregar.Name = "buttonAgregar";
            buttonAgregar.Size = new Size(148, 57);
            buttonAgregar.TabIndex = 11;
            buttonAgregar.Text = "AGREGAR";
            buttonAgregar.UseVisualStyleBackColor = true;
            buttonAgregar.Click += buttonAgregar_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(24, 25, 26);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(DataGridViewMain);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1261, 711);
            panel1.TabIndex = 12;
            panel1.Paint += panel1_Paint;
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.None;
            panel4.BackColor = Color.FromArgb(36, 37, 38);
            panel4.Controls.Add(TextBoxBusqueda);
            panel4.Controls.Add(ComboOrdenar);
            panel4.Controls.Add(label6);
            panel4.Controls.Add(label7);
            panel4.Location = new Point(733, 28);
            panel4.Name = "panel4";
            panel4.Size = new Size(359, 278);
            panel4.TabIndex = 18;
            // 
            // TextBoxBusqueda
            // 
            TextBoxBusqueda.Location = new Point(22, 43);
            TextBoxBusqueda.Name = "TextBoxBusqueda";
            TextBoxBusqueda.Size = new Size(212, 23);
            TextBoxBusqueda.TabIndex = 18;
            TextBoxBusqueda.TextChanged += TextBoxBusqueda_TextChanged;
            // 
            // ComboOrdenar
            // 
            ComboOrdenar.FormattingEnabled = true;
            ComboOrdenar.Items.AddRange(new object[] { "Ascendente", "Descendente" });
            ComboOrdenar.Location = new Point(133, 88);
            ComboOrdenar.Name = "ComboOrdenar";
            ComboOrdenar.Size = new Size(138, 23);
            ComboOrdenar.TabIndex = 13;
            ComboOrdenar.Text = "Ordenar";
            ComboOrdenar.SelectedIndexChanged += ComboOrdenar_SelectedIndexChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.ControlLightLight;
            label6.Location = new Point(3, 88);
            label6.Name = "label6";
            label6.Size = new Size(124, 15);
            label6.TabIndex = 16;
            label6.Text = "Ordenar columna \"ID\"";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 11F);
            label7.ForeColor = SystemColors.ControlLightLight;
            label7.Location = new Point(22, 19);
            label7.Name = "label7";
            label7.Size = new Size(171, 20);
            label7.TabIndex = 17;
            label7.Text = "Busqueda personalizada";
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.None;
            panel2.BackColor = Color.FromArgb(36, 37, 38);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(textBox2);
            panel2.Controls.Add(textBox1);
            panel2.Controls.Add(label10);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(BoxID);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(BoxProducto);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(buttonAgregar);
            panel2.Controls.Add(BoxPrecio);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(BoxFormasdepago);
            panel2.Controls.Add(BoxCantidad);
            panel2.Controls.Add(label1);
            panel2.ForeColor = SystemColors.ControlLightLight;
            panel2.Location = new Point(59, 28);
            panel2.Name = "panel2";
            panel2.Size = new Size(624, 278);
            panel2.TabIndex = 16;
            panel2.Paint += panel2_Paint;
            // 
            // button1
            // 
            button1.FlatAppearance.BorderColor = Color.White;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(414, 177);
            button1.Name = "button1";
            button1.Size = new Size(172, 57);
            button1.TabIndex = 17;
            button1.Text = "Eliminar";
            button1.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(414, 88);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(160, 23);
            textBox2.TabIndex = 16;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(414, 56);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(160, 23);
            textBox1.TabIndex = 15;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.ForeColor = SystemColors.ControlLightLight;
            label10.Location = new Point(314, 91);
            label10.Name = "label10";
            label10.Size = new Size(94, 15);
            label10.TabIndex = 13;
            label10.Text = "Historial medico";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.ForeColor = SystemColors.ControlLightLight;
            label9.Location = new Point(314, 59);
            label9.Name = "label9";
            label9.Size = new Size(36, 15);
            label9.TabIndex = 12;
            label9.Text = "Email";
            // 
            // GestionDePacientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1261, 711);
            Controls.Add(panel1);
            Name = "GestionDePacientes";
            Text = "Gestion De Pacientes";
            Load += BaseDeDatos_Load;
            ((System.ComponentModel.ISupportInitialize)DataGridViewMain).EndInit();
            panel1.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView DataGridViewMain;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox BoxProducto;
        private TextBox BoxID;
        private TextBox BoxPrecio;
        private TextBox BoxFormasdepago;
        private TextBox BoxCantidad;
        private Button buttonAgregar;
        private Panel panel1;
        private Panel panel2;
        private ComboBox ComboOrdenar;
        private Panel panel4;
        private Label label6;
        private TextBox TextBoxBusqueda;
        private Label label7;
        private DataGridViewTextBoxColumn ColumnID;
        private DataGridViewTextBoxColumn ColumnProducto;
        private DataGridViewTextBoxColumn ColumnCantidadDeProducto;
        private DataGridViewTextBoxColumn ColumnFormasDePago;
        private DataGridViewTextBoxColumn ColumnPrecio;
        private DataGridViewTextBoxColumn ColumnEmail;
        private DataGridViewTextBoxColumn ColumnHistorialmedico;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label10;
        private Label label9;
        private Button button1;
    }
}