using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_de_hospitales
{
    public partial class BaseDeDatos : Form
    {
        public BaseDeDatos()
        {
            InitializeComponent();

        }

        private void BaseDeDatos_Load(object sender, EventArgs e)
        {

        }

        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            // guardar y leer los datos de los TextBox
            var idProducto = BoxID.Text;
            var producto = BoxProducto.Text;
            var cantidad = BoxCantidad.Text;
            var formaPago = BoxFormasdepago.Text;
            var precio = BoxPrecio.Text;


            // Validacion para campos vacios
            if (string.IsNullOrEmpty(idProducto) || string.IsNullOrEmpty(producto) ||
            string.IsNullOrEmpty(cantidad) || string.IsNullOrEmpty(formaPago) ||
            string.IsNullOrEmpty(precio))

            {
                MessageBox.Show("Todos los campos deben ser completados.");
                return;
            }

            // Agregar una nueva fila al DataGridView
            DataGridViewMain.Rows.Add(idProducto, producto, cantidad, formaPago, precio);

            // Limpiar los TextBox después de agregar
            BoxID.Clear();
            BoxProducto.Clear();
            BoxCantidad.Clear();
            BoxFormasdepago.Clear();
            BoxPrecio.Clear();


        }
        // Validacion para solo permitir int y strings
        private void BoxID_TextChanged(object sender, EventArgs e)
        {

        }

        private void BoxId_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir solo números
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Ignorar la tecla presionada
            }
        }


        private void BoxProducto_TextChanged(object sender, EventArgs e)
        {
            var textBox = sender as TextBox;
            string text = textBox.Text;

            if (!string.IsNullOrEmpty(text))
            {
                // Convertir la primera letra a mayúscula y el resto a minúsculas
                textBox.Text = char.ToUpper(text[0]) + text.Substring(1).ToLower();
                textBox.SelectionStart = textBox.Text.Length; // Evita que el texto se desordene
            }
        }

        private void BoxProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir solo letras
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void BoxCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir solo números
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void BoxFormasdepago_TextChanged(object sender, EventArgs e)
        {
            var textBox = sender as TextBox;
            string text = textBox.Text;

            if (!string.IsNullOrEmpty(text))
            {
                // Convertir la primera letra a mayúscula y el resto a minúsculas
                textBox.Text = char.ToUpper(text[0]) + text.Substring(1).ToLower();
                textBox.SelectionStart = textBox.Text.Length; // Evita que el texto se desordene
            }
        }
        private void BoxFormasdepago_Keypress(object sender, KeyPressEventArgs e)
        {
            // Permitir solo letras
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void BoxPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir solo números
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '.' && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;

            }

            // Permitir solo un punto decimal
            if (e.KeyChar == '.' && (sender as TextBox).Text.Contains("."))
            {
                e.Handled = true; // Ignorar el punto decimal adicional
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        //Funcion para eliminar fila de datos en la DataGridView
        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            if (DataGridViewMain.SelectedRows.Count > 0)
            {
                DataGridViewMain.Rows.RemoveAt(DataGridViewMain.SelectedRows[0].Index);
            }
            else
            {
                MessageBox.Show("Por favor, selecciona una fila para eliminar.");
            }
        }

        //Ordenar de forma Ascendente
        private void ComboOrdenar_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (ComboOrdenar.SelectedItem == null)
            {
                MessageBox.Show("Por favor, selecciona un orden válido.");
                return;
            }

            string ordenSeleccionado = ComboOrdenar.SelectedItem.ToString();
            if (ordenSeleccionado == "Ascendente")
            {
                OrdenarDataGridView(System.ComponentModel.ListSortDirection.Ascending);
            }
            else if (ordenSeleccionado == "Descendente")
            {
                OrdenarDataGridView(System.ComponentModel.ListSortDirection.Descending);
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un orden válido.");
            }
        }
        private void OrdenarDataGridView(System.ComponentModel.ListSortDirection direccion)
        {
            DataGridViewColumn column = DataGridViewMain.Columns["ColumnID"]; // Cambia esto si quieres ordenar por otra columna
            if (column != null)
            {
                DataGridViewMain.Sort(column, direccion);
            }
            else
            {
                MessageBox.Show("La columna 'Id de producto' no se encuentra.");
            }

            //Ordenar de forma Alfabetica
        }
        private void BotonOrdenAlfabetico_Click(object sender, EventArgs e)
        {
            //Si la columna producto existe entonces ordena la columna producto

            if (DataGridViewMain.Columns["ColumnProducto"] != null)
            {

                DataGridViewMain.Sort(DataGridViewMain.Columns["ColumnProducto"], System.ComponentModel.ListSortDirection.Ascending);
            }
            else
            {
                MessageBox.Show("La columna 'producto' no existe.");
            }
        }

        //Ordenar segun precio

        private void BotonOrdenPorPrecio_Click(object sender, EventArgs e)
        {
            // Verifica si la columna "precios" existe en el DataGridView
            if (DataGridViewMain.Columns["ColumnPrecio"] != null)
            {
                // Ordena la columna "precios" de mayor a menor
                DataGridViewMain.Sort(DataGridViewMain.Columns["ColumnPrecio"], System.ComponentModel.ListSortDirection.Descending);
            }
            else
            {
                MessageBox.Show("La columna 'precios' no existe.");
            }
        }

        //Busqueda personalizada

        private void TextBoxBusqueda_TextChanged(object sender, EventArgs e)
        {

            // Obtén el texto ingresado en el TextBox
            string buscarTexto = TextBoxBusqueda.Text.ToLower();

            // Filtra los datos en el DataGridView
            foreach (DataGridViewRow row in DataGridViewMain.Rows)
            {
                // Si la fila no es una fila de nuevo registro, verifica el contenido
                if (!row.IsNewRow)
                {
                    bool visible = false;

                    // Verifica cada celda en la fila para el texto ingresado
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        if (cell.Value != null && cell.Value.ToString().ToLower().Contains(buscarTexto))
                        {
                            visible = true;
                            break;
                        }
                    }

                    // Establece la visibilidad de la fila según si se encontró el texto
                    row.Visible = visible;
                }
            }
        }
        //Se agrego por error, no lo puedo eliminar
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        //suma de precios en datagrid

        private void BotonCalcular_Click(object sender, EventArgs e)
        {
            double total = 0;
            foreach (DataGridViewRow row in DataGridViewMain.Rows)
            {
                // Verifica que la fila no sea una fila nueva
                if (!row.IsNewRow)
                {
                    // Obtén los valores de las columnas "Cantidad" y "Precio"
                    var cantidadValue = row.Cells["ColumnCantidadDeProducto"].Value;
                    var precioValue = row.Cells["ColumnPrecio"].Value;

                    //En caso de querer operar otra columna:
                    //var IdProductovalue = row.Cells["ColumnID"].Value;

                    // Intenta convertir los valores a double y manejar posibles errores
                    if (double.TryParse(cantidadValue.ToString(), out double cantidad) &&
                        double.TryParse(precioValue.ToString(), out double precio))

                    {
                        total += (cantidad * precio);
                    }
                    else
                    {
                        return;
                    }

                }
            }

            // Muestra el total en el TextBox con formato de número con dos decimales
            TextBoxTotal.Text = total.ToString("N2");
        }

    }
}
