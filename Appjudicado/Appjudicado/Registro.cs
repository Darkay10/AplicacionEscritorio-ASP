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
    public partial class Registro : Form
    {
        public Registro()
        {
            InitializeComponent();
        }

        private void bRegistro_Click(object sender, EventArgs e)
        {
            int t = Sesion.registro(textbox_user.Text, textbox_pass.Text, textbox_email.Text, textbox_direccion.Text, textbox_localidad.Text, textbox_pais.Text, textbox_codigo_postal.Text);
            if (t == 1)         // 1 El usuario existe
            {
                MessageBox.Show("Error, el usuario existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (t == 2)    // 2 error al introducir datos
            {
                MessageBox.Show("Error al introducir datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else                // 0 todo ha ido bien
            {
                this.Close();
            }
        }
    }
}
