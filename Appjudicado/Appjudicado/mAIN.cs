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
        public static Button botonActualizar;
        public static FlowLayoutPanel panel;

        /*  
         * LAS COMPROBACIONES QUE SE HAN DE HACER SON: CAMPOS VACIOS, CAMPOS QUE SEAN FLOAT, 
         * QUE LA FECHA DE INICIO NO VAYA MAS TARDE QUE LA FINAL, QUE LA IMAGEN SE PUEDE COLOCAR, 
         * EN VEZ DE INPUT QUE SE PUEDA SELECCIONAR IMAGEN O SUBIR UNA FOTO
         */

        public Main()
        {
            InitializeComponent();
            ConexionApi.start();
            botonAdm = bAdmin;
            panel = panelDeControl;
            botonActualizar = bActualizar;
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

        private void bCrear_Click(object sender, EventArgs e)       // Mostrará "PanelSubasta" vacío y permitirá la introducción de los datos para añadir una subasta
        {
            Sesion.crearSubasta();  
        }

        private void bPerfil_Click(object sender, EventArgs e)      // La funcionalidad mostrará los datos en el PanelUsuario - Permitiendo modificar la contraseña y modificar el user
        {
            Sesion.mostrarPerfil(); 
        }

        private void bListar_Click(object sender, EventArgs e)      // La funcionalidad 1 servirá para que puje y la 2 para eliminar la subasta - En este caso es la 1
        {
            Sesion.verSubastas();   
        }

        private void bMisSubastas_Click(object sender, EventArgs e) // La funcionalidad 1 servirá para que puje y la 2 para eliminar la subasta - En este caso es la 2
        {
            Sesion.misSubastas();
        }

        private void bAdmin_Click(object sender, EventArgs e)       // Muestra un listado en el que podremos modificar y eliminar usuarios
        {
            Sesion.administrarUsers();  
        }

        private void bMisPujas_Click(object sender, EventArgs e)    // Muestra un listado en el que podremos ver las subastas en las que hemos pujado
        {
            Sesion.misPujas();  
        }

        private void bActualizar_Click(object sender, EventArgs e)
        {
            // EL BOTON ACTUALIZAR - Comprueba si una subasta ya ha pasado de plazo - Trocea la fecha actual y comprueba si el año, el mes y el dia
            //Sesion.actualizarSubastas();
        }
    }
}
