using System;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using FontAwesome.Sharp;
using System.Runtime.InteropServices;
using Prueba_De_DataGridView;
namespace Gestion_de_hospitales
{
    public partial class Form1 : Form
    {
        // Font Awesome code

        private IconButton currenttBtn;
        private Panel leftBorderBtn;
        private Form FormSecundario;
        public Form1()
        {
            InitializeComponent();

            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 101);
            PanelMenuLateral.Controls.Add(leftBorderBtn);

        }
        //estructura para almacenar colores RGB
        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(172, 126, 241);
            public static Color color2 = Color.FromArgb(249, 118, 176);
            public static Color color3 = Color.FromArgb(253, 138, 114);
            public static Color color4 = Color.FromArgb(95, 77, 221);
            public static Color color5 = Color.FromArgb(249, 88, 155);
            public static Color color6 = Color.FromArgb(24, 161, 251);
        }
        //Metodos
        private void ActiveButton(Object senderBtn, Color color)
        {
            DisableButton();

            if (senderBtn is IconButton currentBtn)
            {   //Animacion de botones
                currenttBtn = (IconButton)senderBtn;
                currenttBtn.BackColor = Color.FromArgb(37, 36, 81);
                currenttBtn.ForeColor = color;
                currenttBtn.TextAlign = ContentAlignment.MiddleCenter;
                currenttBtn.IconColor = color;
                currenttBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currenttBtn.ImageAlign = ContentAlignment.MiddleRight;
                //borde izquierdo del boton
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currenttBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();

                // Animacion de Boton de titulo

                IconoTitulo.IconChar = currentBtn.IconChar;
                IconoTitulo.IconColor = color;

            }
        }
        //desactivar animaciones de botones

        private void DisableButton()
        {
            if (currenttBtn != null)
            {
                currenttBtn.BackColor = Color.FromArgb(36, 37, 38);
                currenttBtn.ForeColor = Color.Gainsboro;
                currenttBtn.TextAlign = ContentAlignment.MiddleLeft;
                currenttBtn.IconColor = Color.Gainsboro;
                currenttBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currenttBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        //eventos click, incluye funcion para cambiar a form secundario
        private void BotonHome_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, RGBColors.color1);

            //Boton home deshabilitado
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ActiveButton(sender, RGBColors.color5);
        }

        private void BotonBaseDeDatos_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, RGBColors.color4);
            Formularios_Secundarios(new GestionDePacientes());
        }

        private void BotonConfiguracion_Click(object sender, EventArgs e)
        {
            //Contactos
            ActiveButton(sender, RGBColors.color1);
            Formularios_Secundarios(new CitasMedicas());

        }


        private void BotonCerrarSesion_Click_1(object sender, EventArgs e)
        {
            ActiveButton(sender, RGBColors.color2);
            Application.Exit();
        }

        private void AsistenciaMedica_Click(object sender, EventArgs e)
        {
            Formularios_Secundarios(new Asistencia());
            ActiveButton(sender, RGBColors.color5);
        }

        private void BotonFarmacia_Click(object sender, EventArgs e)
        {
            Formularios_Secundarios(new Farmacia());
            ActiveButton(sender, RGBColors.color6);
        }
        private void BotonLogo_Click(object sender, EventArgs e)
        {
            Reset();
            FormSecundario.Close();
        }
        private void Reset()
        {
            DisableButton();
            leftBorderBtn.Visible = false;
            IconoTitulo.IconChar = IconChar.Home;
            IconoTitulo.IconColor = Color.MediumPurple;
            Titulo.Text = "Home";
        }

        // Arrastrar ventana con mouse (incompleto)
        private void PanelSuperior_MouseDown(object sender, MouseEventArgs e)
        {

        }


        //Abrir Ventanas secundarias

        private void Formularios_Secundarios(Form FormularioSecundario)
        {
            if (FormSecundario != null)
            {   //solo se mantiene un formulario abierto
                FormSecundario.Close();
            }
            FormSecundario = FormularioSecundario;
            FormularioSecundario.TopLevel = false;
            FormSecundario.FormBorderStyle = FormBorderStyle.None;
            FormularioSecundario.Dock = DockStyle.Fill;
            MainPanel.Controls.Add(FormularioSecundario);
            MainPanel.Tag = FormularioSecundario;
            FormularioSecundario.BringToFront();
            FormularioSecundario.Show();
            Titulo.Text = FormSecundario.Text;

        }
        ///----------Final de Font Awesome code--------------//

        private void Form1_Click(object sender, EventArgs e)
        {

        }

        //Menu desplegable Imcompleto
        private void MenuDesplegable_Click(object sender, EventArgs e)
        {
            DesplegarMenu();
        }

        private void DesplegarMenu()
        {
            throw new NotImplementedException();
        }

        //Mostar fecha y hora en tiempo real
        private void HoraFecha_Tick(object sender, EventArgs e)
        {
            labelHora.Text = DateTime.Now.ToLongTimeString();
            labelFecha.Text = DateTime.Now.ToShortDateString();
        }

        private void labelHora_Click(object sender, EventArgs e)
        {

        }

        private void MainPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

