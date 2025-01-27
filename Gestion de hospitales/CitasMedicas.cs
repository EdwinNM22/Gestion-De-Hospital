﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_de_hospitales
{
    public partial class CitasMedicas : Form
    {
        public CitasMedicas()
        {
            InitializeComponent();

        }

        private void Contactos_Load(object sender, EventArgs e)
        {
            string filePath = @"C:\Users\Alexx\Documents\Visual Studio 2022\Proyectosxd\Gestion de hospital\Base de datos local\Base_De_Datos_Citas_Medicas.tsv"; // las base de datos estan guardadas dentro de la carpeta del proyecto
            LoadDataFromTSV(filePath);
        }

        // Cargar base de datos
        private void LoadDataFromTSV(string filePath)
        {
            try
            {
                // Limpiar cualquier dato previo en el DataGridView
                dataGridView1.Rows.Clear();

                using (StreamReader sr = new StreamReader(filePath))
                {
                    string line;
                    bool isFirstLine = true;

                    while ((line = sr.ReadLine()) != null)
                    {
                        string[] values = line.Split('\t');

                        if (isFirstLine)
                        {
                            // Saltear la primera línea que contiene los encabezados
                            isFirstLine = false;
                        }
                        else
                        {
                            // Crear una nueva fila
                            DataGridViewRow row = new DataGridViewRow();
                            row.CreateCells(dataGridView1);

                            // Asignar valores a cada celda según el nombre de la columna en el código
                            row.Cells[dataGridView1.Columns["ColumnIDCita"].Index].Value = values[0];
                            row.Cells[dataGridView1.Columns["ColumnNombredepaciente"].Index].Value = values[1];
                            row.Cells[dataGridView1.Columns["ColumnFechacita"].Index].Value = values[2];
                            row.Cells[dataGridView1.Columns["ColumnHoracita"].Index].Value = values[3];
                            row.Cells[dataGridView1.Columns["ColumnMotivocita"].Index].Value = values[4];
                            row.Cells[dataGridView1.Columns["ColumnDoctorcita"].Index].Value = values[5];
                            

                            // Agregar la fila al DataGridView
                            dataGridView1.Rows.Add(row);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al leer el archivo TSV: " + ex.Message);
            }
        }

        //Fin de la carga de base de datos




        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

