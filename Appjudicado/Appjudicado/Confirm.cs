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
    public partial class Confirm : Form
    {
        private Usuario user;
        public Confirm(Usuario u)
        {
            InitializeComponent();
            user = u;
        }

        private void bAceptar_Click(object sender, EventArgs e)
        {
            if (!tbPass1.Text.Equals("") && !tbPass2.Text.Equals(""))
            {
                if (tbPass1.Text.Equals(tbPass2.Text))
                {
                    if (!tbPass1.Equals(user.Pass))
                    {
                        Sesion.cambiarContra(user, tbPass1.Text);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Has introducido la misma contraseña");
                    }
                }
                else
                {
                    MessageBox.Show("Las contraseñas no son iguales");
                }
            }
            else
            {
                MessageBox.Show("Campos vacíos");
            }
        }

        private void bCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
