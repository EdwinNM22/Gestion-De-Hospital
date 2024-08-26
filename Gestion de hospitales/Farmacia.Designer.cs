namespace Prueba_De_DataGridView
{
    partial class Farmacia
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
            panel2 = new Panel();
            textBox1 = new TextBox();
            label2 = new Label();
            button1 = new Button();
            label1 = new Label();
            BotonOrdenPorPrecio = new Button();
            DataGridFarmacia = new DataGridView();
            ColumnIDMedicamento = new DataGridViewTextBoxColumn();
            ColumnMedicamento = new DataGridViewTextBoxColumn();
            ColumnStock = new DataGridViewTextBoxColumn();
            ColumnFechaDeIngreso = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DataGridFarmacia).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(24, 25, 26);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(DataGridFarmacia);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1152, 543);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(36, 37, 38);
            panel2.Controls.Add(textBox1);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(BotonOrdenPorPrecio);
            panel2.Location = new Point(44, 47);
            panel2.Name = "panel2";
            panel2.Size = new Size(631, 306);
            panel2.TabIndex = 22;
            panel2.Paint += panel2_Paint;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(415, 62);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(193, 23);
            textBox1.TabIndex = 25;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(451, 30);
            label2.Name = "label2";
            label2.Size = new Size(134, 15);
            label2.TabIndex = 24;
            label2.Text = "Busqueda personalizada";
            // 
            // button1
            // 
            button1.FlatAppearance.BorderColor = Color.White;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = SystemColors.ControlLightLight;
            button1.Location = new Point(250, 220);
            button1.Name = "button1";
            button1.Size = new Size(191, 60);
            button1.TabIndex = 23;
            button1.Text = "Eliminar";
            button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(19, 30);
            label1.Name = "label1";
            label1.Size = new Size(111, 15);
            label1.TabIndex = 22;
            label1.Text = "ID de medicamento";
            // 
            // BotonOrdenPorPrecio
            // 
            BotonOrdenPorPrecio.FlatAppearance.BorderColor = Color.White;
            BotonOrdenPorPrecio.FlatStyle = FlatStyle.Flat;
            BotonOrdenPorPrecio.ForeColor = SystemColors.ControlLightLight;
            BotonOrdenPorPrecio.Location = new Point(19, 220);
            BotonOrdenPorPrecio.Name = "BotonOrdenPorPrecio";
            BotonOrdenPorPrecio.Size = new Size(191, 60);
            BotonOrdenPorPrecio.TabIndex = 21;
            BotonOrdenPorPrecio.Text = "agregar";
            BotonOrdenPorPrecio.UseVisualStyleBackColor = true;
            // 
            // DataGridFarmacia
            // 
            DataGridFarmacia.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridFarmacia.Columns.AddRange(new DataGridViewColumn[] { ColumnIDMedicamento, ColumnMedicamento, ColumnStock, ColumnFechaDeIngreso });
            DataGridFarmacia.Location = new Point(681, 252);
            DataGridFarmacia.Name = "DataGridFarmacia";
            DataGridFarmacia.Size = new Size(469, 291);
            DataGridFarmacia.TabIndex = 0;
            // 
            // ColumnIDMedicamento
            // 
            ColumnIDMedicamento.HeaderText = "ID de medicamento";
            ColumnIDMedicamento.Name = "ColumnIDMedicamento";
            // 
            // ColumnMedicamento
            // 
            ColumnMedicamento.HeaderText = "Medicamento";
            ColumnMedicamento.Name = "ColumnMedicamento";
            // 
            // ColumnStock
            // 
            ColumnStock.HeaderText = "Stock De Medicamento";
            ColumnStock.Name = "ColumnStock";
            // 
            // ColumnFechaDeIngreso
            // 
            ColumnFechaDeIngreso.HeaderText = "Fecha de ingreso";
            ColumnFechaDeIngreso.Name = "ColumnFechaDeIngreso";
            // 
            // Farmacia
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1152, 543);
            Controls.Add(panel1);
            Name = "Farmacia";
            Text = "Farmacia";
            Load += Farmacia_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DataGridFarmacia).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private DataGridView DataGridFarmacia;
        private DataGridViewTextBoxColumn ColumnIDMedicamento;
        private DataGridViewTextBoxColumn ColumnMedicamento;
        private DataGridViewTextBoxColumn ColumnStock;
        private DataGridViewTextBoxColumn ColumnFechaDeIngreso;
        private Panel panel2;
        private Button BotonOrdenPorPrecio;
        private Label label1;
        private Button button1;
        private TextBox textBox1;
        private Label label2;
    }
}