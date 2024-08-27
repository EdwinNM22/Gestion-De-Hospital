using System;
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
    public partial class InicioDeSesion : Form
    {
        public InicioDeSesion()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void InicioDeSesion_Load(object sender, EventArgs e)
        {

        }



        private void BotonCancelar_Click(object sender, EventArgs e)
        {
            textBoxContra.Clear();
            textBoxUsuario.Clear();
        }

        private void BotonIngresar_Click(object sender, EventArgs e)
        {
            if (textBoxUsuario.Text == "Admin" && textBoxContra.Text == "Admin123")
            {
                Home formHome = new Home();
                this.Hide();
                formHome.Show();
            }
            else
            {
                MessageBox.Show("Nombre de Usuario o contraseña incorrectos");
                textBoxContra.Clear();
                textBoxUsuario.Clear();
            }

        }

        private void textBoxContra_TextChanged(object sender, EventArgs e)
        {

            textBoxContra.UseSystemPasswordChar = true;

        }

        private void iconPictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
