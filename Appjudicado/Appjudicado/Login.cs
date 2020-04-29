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
    public partial class Login : Form
    {
        public Main principal;

        public Login(Main m)
        {
            InitializeComponent();
            principal = m;
            Sesion.blank();
        }

        private void button_login_Click(object sender, EventArgs e)     // Login - Comprueba que exista, sino lanza un mensaje de error
        {
            bool t = Sesion.login(user_tb.Text, pass_tb.Text);
            if (t)
            {
                this.Close();
                principal.Show();
            }
            else { MessageBox.Show("Error, no existe el usuario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void button_registro_Click(object sender, EventArgs e)  // Abrir pestaña de registro
        {
            Registro r = new Registro();
            r.Show();
        }
    }
}
