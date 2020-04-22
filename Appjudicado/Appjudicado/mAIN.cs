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
        ConexionApi cap;

        public Main()
        {
            InitializeComponent();
            ConexionApi.start();
            if (Sesion.logged == null)
            {
                Application.Run(new Login());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ConexionApi.GetUsersAsync();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = ConexionApi.users[0].User;
        }
    }
}
