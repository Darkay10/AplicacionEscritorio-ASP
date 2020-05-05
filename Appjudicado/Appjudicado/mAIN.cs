using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Appjudicado
{
    public partial class Main : Form
    {
        public static Button botonAdm;
        public static FlowLayoutPanel panel;
        public Main()
        {
            InitializeComponent();
            ConexionApi.start();
            botonAdm = bAdmin;
            panel = panelDeControl;
        }

        private void Main_Load(object sender, EventArgs e)
        {
            if (Sesion.logged == null)
            {
                Login r = new Login(this);
                this.Hide();
                r.ShowDialog();
            }
        }

        private void bCrear_Click(object sender, EventArgs e)
        {
            Sesion.crearSubasta();
        }

        private void bPerfil_Click(object sender, EventArgs e)
        {
            Sesion.mostrarPerfil(); // La funcionalidad mostrará los datos en el PanelUsuario - Permitiendo modificar la contraseña y modificar el user
        }

        private void bListar_Click(object sender, EventArgs e)
        {
            Sesion.verSubastas();   // La funcionalidad 1 servirá para que puje y la 2 para eliminar la subasta - En este caso es la 1
        }

        private void bMisSubastas_Click(object sender, EventArgs e)
        {
            Sesion.misSubastas();   // La funcionalidad 1 servirá para que puje y la 2 para eliminar la subasta - En este caso es la 2
        }

        private void bAdmin_Click(object sender, EventArgs e)
        {
            // Sesion.administrarUsers();  // EXPLICAR QUE HACE
        }
    }
}
