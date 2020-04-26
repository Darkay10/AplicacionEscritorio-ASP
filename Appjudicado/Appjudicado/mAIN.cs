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
        public static Label text;
        public static Button botonAdm;
        public Main()
        {
            InitializeComponent();
            ConexionApi.start();
            text = lTexto;
            botonAdm = bAdmin;
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
    }
}
