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
        public Login()
        {
            InitializeComponent();
            Sesion.blank();
        }

        private void button_login_Click(object sender, EventArgs e)
        {
            //login
            bool t = Sesion.login(user_tb.Text, pass_tb.Text);
            if (t)
            {
                this.Close();
            }
            else
            {
                MessageBox.Show("Error", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_registro_Click(object sender, EventArgs e)
        {
            //open registro
            Application.Run(new Registro());
        }
    }
}
