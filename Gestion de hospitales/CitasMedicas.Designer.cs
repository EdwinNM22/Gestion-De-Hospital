namespace Gestion_de_hospitales
{
    partial class CitasMedicas
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
            dataGridView1 = new DataGridView();
            panel2 = new Panel();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            textBox7 = new TextBox();
            buttonAgregar = new Button();
            ColumnIDCita = new DataGridViewTextBoxColumn();
            ColumnFechacita = new DataGridViewTextBoxColumn();
            ColumnHoracita = new DataGridViewTextBoxColumn();
            ColumnMotivocita = new DataGridViewTextBoxColumn();
            ColumnIDpaciente = new DataGridViewTextBoxColumn();
            ColumnEstadocita = new DataGridViewTextBoxColumn();
            ColumnDoctorcita = new DataGridViewTextBoxColumn();
            panel3 = new Panel();
            textBox8 = new TextBox();
            label8 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
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
            panel1.Size = new Size(1200, 621);
            panel1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ColumnIDCita, ColumnFechacita, ColumnHoracita, ColumnMotivocita, ColumnIDpaciente, ColumnEstadocita, ColumnDoctorcita });
            dataGridView1.Dock = DockStyle.Bottom;
            dataGridView1.Location = new Point(0, 344);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(1200, 277);
            dataGridView1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(36, 37, 38);
            panel2.Controls.Add(buttonAgregar);
            panel2.Controls.Add(textBox7);
            panel2.Controls.Add(textBox6);
            panel2.Controls.Add(textBox5);
            panel2.Controls.Add(textBox4);
            panel2.Controls.Add(textBox3);
            panel2.Controls.Add(textBox2);
            panel2.Controls.Add(textBox1);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(41, 37);
            panel2.Name = "panel2";
            panel2.Size = new Size(490, 233);
            panel2.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(27, 32);
            label1.Name = "label1";
            label1.Size = new Size(56, 15);
            label1.TabIndex = 0;
            label1.Text = "ID de cita";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(27, 66);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 1;
            label2.Text = "Fecha";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(27, 101);
            label3.Name = "label3";
            label3.Size = new Size(33, 15);
            label3.TabIndex = 2;
            label3.Text = "Hora";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = SystemColors.ControlLightLight;
            label4.Location = new Point(27, 134);
            label4.Name = "label4";
            label4.Size = new Size(45, 15);
            label4.TabIndex = 3;
            label4.Text = "Motivo";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = SystemColors.ControlLightLight;
            label5.Location = new Point(241, 32);
            label5.Name = "label5";
            label5.Size = new Size(82, 15);
            label5.TabIndex = 4;
            label5.Text = "ID de paciente";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = SystemColors.ControlLightLight;
            label6.Location = new Point(241, 106);
            label6.Name = "label6";
            label6.Size = new Size(42, 15);
            label6.TabIndex = 5;
            label6.Text = "Estado";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = SystemColors.ControlLightLight;
            label7.Location = new Point(241, 72);
            label7.Name = "label7";
            label7.Size = new Size(85, 15);
            label7.TabIndex = 6;
            label7.Text = "Doctor a cargo";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(89, 29);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(117, 23);
            textBox1.TabIndex = 7;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(89, 98);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(117, 23);
            textBox2.TabIndex = 8;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(89, 63);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(117, 23);
            textBox3.TabIndex = 9;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(89, 126);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(117, 23);
            textBox4.TabIndex = 10;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(329, 29);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(117, 23);
            textBox5.TabIndex = 11;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(329, 66);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(117, 23);
            textBox6.TabIndex = 12;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(329, 103);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(117, 23);
            textBox7.TabIndex = 13;
            // 
            // buttonAgregar
            // 
            buttonAgregar.FlatAppearance.BorderColor = Color.White;
            buttonAgregar.FlatStyle = FlatStyle.Flat;
            buttonAgregar.ForeColor = SystemColors.ControlLightLight;
            buttonAgregar.Location = new Point(298, 146);
            buttonAgregar.Name = "buttonAgregar";
            buttonAgregar.Size = new Size(148, 57);
            buttonAgregar.TabIndex = 14;
            buttonAgregar.Text = "AGREGAR";
            buttonAgregar.UseVisualStyleBackColor = true;
            // 
            // ColumnIDCita
            // 
            ColumnIDCita.HeaderText = "ID de cita";
            ColumnIDCita.Name = "ColumnIDCita";
            ColumnIDCita.Width = 75;
            // 
            // ColumnFechacita
            // 
            ColumnFechacita.HeaderText = "Fecha";
            ColumnFechacita.Name = "ColumnFechacita";
            ColumnFechacita.Width = 75;
            // 
            // ColumnHoracita
            // 
            ColumnHoracita.HeaderText = "Hora";
            ColumnHoracita.Name = "ColumnHoracita";
            // 
            // ColumnMotivocita
            // 
            ColumnMotivocita.HeaderText = "Motivo";
            ColumnMotivocita.Name = "ColumnMotivocita";
            // 
            // ColumnIDpaciente
            // 
            ColumnIDpaciente.HeaderText = "ID de paciente";
            ColumnIDpaciente.Name = "ColumnIDpaciente";
            // 
            // ColumnEstadocita
            // 
            ColumnEstadocita.HeaderText = "Estado";
            ColumnEstadocita.Name = "ColumnEstadocita";
            // 
            // ColumnDoctorcita
            // 
            ColumnDoctorcita.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ColumnDoctorcita.HeaderText = "Doctor a cargo";
            ColumnDoctorcita.Name = "ColumnDoctorcita";
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(36, 37, 38);
            panel3.Controls.Add(label8);
            panel3.Controls.Add(textBox8);
            panel3.Location = new Point(568, 37);
            panel3.Name = "panel3";
            panel3.Size = new Size(336, 233);
            panel3.TabIndex = 2;
            // 
            // textBox8
            // 
            textBox8.Location = new Point(51, 72);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(229, 23);
            textBox8.TabIndex = 14;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 11F);
            label8.ForeColor = SystemColors.ControlLightLight;
            label8.Location = new Point(51, 32);
            label8.Name = "label8";
            label8.Size = new Size(171, 20);
            label8.TabIndex = 18;
            label8.Text = "Busqueda personalizada";
            // 
            // Contactos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1200, 621);
            Controls.Add(panel1);
            Name = "Contactos";
            Text = "sd";
            Load += Contactos_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private DataGridView dataGridView1;
        private Panel panel2;
        private TextBox textBox7;
        private TextBox textBox6;
        private TextBox textBox5;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button buttonAgregar;
        private DataGridViewTextBoxColumn ColumnIDCita;
        private DataGridViewTextBoxColumn ColumnFechacita;
        private DataGridViewTextBoxColumn ColumnHoracita;
        private DataGridViewTextBoxColumn ColumnMotivocita;
        private DataGridViewTextBoxColumn ColumnIDpaciente;
        private DataGridViewTextBoxColumn ColumnEstadocita;
        private DataGridViewTextBoxColumn ColumnDoctorcita;
        private Panel panel3;
        private TextBox textBox8;
        private Label label8;
    }
}