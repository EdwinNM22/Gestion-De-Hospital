namespace Gestion_de_hospitales
{
    partial class HistorialMedico
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
            panel3 = new Panel();
            button2 = new Button();
            button1 = new Button();
            buttonAgregar = new Button();
            panel2 = new Panel();
            textBox5 = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label2 = new Label();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            ColumnIDhistorial = new DataGridViewTextBoxColumn();
            ColumnIDPaciente = new DataGridViewTextBoxColumn();
            ColumnDiagnostico = new DataGridViewTextBoxColumn();
            ColumnTratamiento = new DataGridViewTextBoxColumn();
            ColumnFechahistorial = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(24, 25, 26);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(dataGridView1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1272, 693);
            panel1.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(36, 37, 38);
            panel3.Controls.Add(button2);
            panel3.Controls.Add(button1);
            panel3.Controls.Add(buttonAgregar);
            panel3.Location = new Point(517, 36);
            panel3.Name = "panel3";
            panel3.Size = new Size(200, 241);
            panel3.TabIndex = 2;
            // 
            // button2
            // 
            button2.FlatAppearance.BorderColor = Color.White;
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = SystemColors.ControlLightLight;
            button2.Location = new Point(23, 163);
            button2.Name = "button2";
            button2.Size = new Size(148, 57);
            button2.TabIndex = 14;
            button2.Text = "BORRAR";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.FlatAppearance.BorderColor = Color.White;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = SystemColors.ControlLightLight;
            button1.Location = new Point(23, 98);
            button1.Name = "button1";
            button1.Size = new Size(148, 57);
            button1.TabIndex = 13;
            button1.Text = "EDITAR";
            button1.UseVisualStyleBackColor = true;
            // 
            // buttonAgregar
            // 
            buttonAgregar.FlatAppearance.BorderColor = Color.White;
            buttonAgregar.FlatStyle = FlatStyle.Flat;
            buttonAgregar.ForeColor = SystemColors.ControlLightLight;
            buttonAgregar.Location = new Point(23, 26);
            buttonAgregar.Name = "buttonAgregar";
            buttonAgregar.Size = new Size(148, 57);
            buttonAgregar.TabIndex = 12;
            buttonAgregar.Text = "AGREGAR";
            buttonAgregar.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(36, 37, 38);
            panel2.Controls.Add(textBox5);
            panel2.Controls.Add(textBox3);
            panel2.Controls.Add(textBox2);
            panel2.Controls.Add(textBox1);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(43, 36);
            panel2.Name = "panel2";
            panel2.Size = new Size(405, 204);
            panel2.TabIndex = 1;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(112, 60);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(100, 23);
            textBox5.TabIndex = 9;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(112, 20);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 7;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(100, 132);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(269, 23);
            textBox2.TabIndex = 6;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(100, 163);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(269, 23);
            textBox1.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = SystemColors.ControlLightLight;
            label5.Location = new Point(24, 135);
            label5.Name = "label5";
            label5.Size = new Size(70, 15);
            label5.TabIndex = 4;
            label5.Text = "Tratamiento";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = SystemColors.ControlLightLight;
            label4.Location = new Point(24, 166);
            label4.Name = "label4";
            label4.Size = new Size(70, 15);
            label4.TabIndex = 3;
            label4.Text = "Diagnostico";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(21, 60);
            label2.Name = "label2";
            label2.Size = new Size(82, 15);
            label2.TabIndex = 1;
            label2.Text = "ID de paciente";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(24, 28);
            label1.Name = "label1";
            label1.Size = new Size(79, 15);
            label1.TabIndex = 0;
            label1.Text = "ID de historial";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ColumnIDhistorial, ColumnIDPaciente, ColumnDiagnostico, ColumnTratamiento, ColumnFechahistorial });
            dataGridView1.Dock = DockStyle.Bottom;
            dataGridView1.Location = new Point(0, 444);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(1272, 249);
            dataGridView1.TabIndex = 0;
            // 
            // ColumnIDhistorial
            // 
            ColumnIDhistorial.HeaderText = "ID de historial";
            ColumnIDhistorial.Name = "ColumnIDhistorial";
            ColumnIDhistorial.Width = 70;
            // 
            // ColumnIDPaciente
            // 
            ColumnIDPaciente.HeaderText = "ID de paciente";
            ColumnIDPaciente.Name = "ColumnIDPaciente";
            ColumnIDPaciente.Width = 70;
            // 
            // ColumnDiagnostico
            // 
            ColumnDiagnostico.HeaderText = "Diagnostico";
            ColumnDiagnostico.Name = "ColumnDiagnostico";
            ColumnDiagnostico.Width = 425;
            // 
            // ColumnTratamiento
            // 
            ColumnTratamiento.HeaderText = "Tratamiento";
            ColumnTratamiento.Name = "ColumnTratamiento";
            ColumnTratamiento.Width = 425;
            // 
            // ColumnFechahistorial
            // 
            ColumnFechahistorial.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ColumnFechahistorial.HeaderText = "Fecha ";
            ColumnFechahistorial.Name = "ColumnFechahistorial";
            // 
            // HistorialMedico
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1272, 693);
            Controls.Add(panel1);
            Name = "HistorialMedico";
            Text = "Configuracion";
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private DataGridView dataGridView1;
        private Panel panel2;
        private DataGridViewTextBoxColumn ColumnIDhistorial;
        private DataGridViewTextBoxColumn ColumnIDPaciente;
        private DataGridViewTextBoxColumn ColumnDiagnostico;
        private DataGridViewTextBoxColumn ColumnTratamiento;
        private DataGridViewTextBoxColumn ColumnFechahistorial;
        private Label label4;
        private Label label2;
        private Label label1;
        private Panel panel3;
        private TextBox textBox5;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label5;
        private Button button2;
        private Button button1;
        private Button buttonAgregar;
    }
}