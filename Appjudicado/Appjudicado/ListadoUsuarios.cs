using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Appjudicado
{
    public partial class ListadoUsuarios : UserControl
    {
        public Usuario user;
        public ListadoUsuarios(Usuario u)
        {
            InitializeComponent();
            user = u;
        }

        private void ListadoUsuarios_Load(object sender, EventArgs e)
        {
            lUsuario.Text = user.User;
            lEmail.Text = user.Email;
            lDireccion.Text = user.Direccion;
            lCp.Text = user.Cp;
            lLocalidad.Text = user.Localidad;
            lPais.Text = user.Pais;
        }

        private void bEditar_Click(object sender, EventArgs e)
        {
            Sesion.mostrarUsuario(user, 1);
        }

        private void bEliminar_Click(object sender, EventArgs e)
        {
            // FUNCION QUE MUESTRA UN CARTEL Y ELIMINA EL USUARIO SI SE ACEPTA
            Sesion.eliminarUsuario(user);
        }
    }
}
