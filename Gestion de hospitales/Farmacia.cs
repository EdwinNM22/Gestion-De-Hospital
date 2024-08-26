using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prueba_De_DataGridView
{
    public partial class Farmacia : Form
    {
        public Farmacia()
        {
            InitializeComponent();
        }

        private void Farmacia_Load(object sender, EventArgs e)
        {
            string filePath = @"C:\Users\Alexx\Documents\Visual Studio 2022\Proyectosxd\Gestion de hospital\Base de datos local\Base_De_Datos_Farmacia.tsv"; // las base de datos estan guardadas dentro de la carpeta del proyecto
            LoadDataFromTSV(filePath);
        }

        // Cargar base de datos
        private void LoadDataFromTSV(string filePath)
        {
            try
            {
                // Limpiar cualquier dato previo en el DataGridView
                DataGridFarmacia.Rows.Clear();

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
                            row.CreateCells(DataGridFarmacia);

                            // Asignar valores a cada celda según el nombre de la columna en el código
                            row.Cells[DataGridFarmacia.Columns["ColumnIDMedicamento"].Index].Value = values[0];
                            row.Cells[DataGridFarmacia.Columns["ColumnMedicamento"].Index].Value = values[1];
                            row.Cells[DataGridFarmacia.Columns["ColumnStock"].Index].Value = values[2];
                            row.Cells[DataGridFarmacia.Columns["ColumnFechaDeIngreso"].Index].Value = values[3];


                            // Agregar la fila al DataGridView
                            DataGridFarmacia.Rows.Add(row);
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




        //Ignorar esto xd
        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
