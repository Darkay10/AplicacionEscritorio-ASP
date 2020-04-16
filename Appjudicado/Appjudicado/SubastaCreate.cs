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
    public partial class SubastaCreate : Form
    {
        public SubastaCreate()
        {
            InitializeComponent();
        }

        private void SubastaCreate_Load(object sender, EventArgs e)
        {

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            textbox_imagen.Text = openimagen.FileName;
        }

        private void button_openfile_Click(object sender, EventArgs e)
        {
            openimagen.ShowDialog();
        }
    }
}
