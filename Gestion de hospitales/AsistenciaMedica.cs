using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Web.WebView2.Core;
using Microsoft.Web.WebView2.WinForms;

namespace Gestion_de_hospitales
{
    public partial class Asistencia : Form
    {
        public Asistencia()
        {
            InitializeComponent();
        }
      


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private async void Asistencia_Load(object sender, EventArgs e)
        {
            try
            {
                await webView21.EnsureCoreWebView2Async(null);
                webView21.Source = new Uri("https://chatgpt.com");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al inicializar WebView2: {ex.Message}");
            }
        }
    }
}
