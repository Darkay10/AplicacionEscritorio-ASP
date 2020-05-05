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
    public partial class ListadoSubastas : UserControl
    {
        private Subasta sub;
        private int funcionalidad;
        public ListadoSubastas(Subasta s, int fun)
        {
            InitializeComponent();
            sub = s;
            funcionalidad = fun;
        }

        private void ListadoSubastas_Load(object sender, EventArgs e)
        {
            // Asignamos correctamente los datos a los labels para mostrar la información y los botones se preparán para su futuro uso
            lArticulo.Text = "Artículo: " + sub.Articulo;
            lCategoria.Text = "Categoría: " + sub.Categoria;
            lFechaFin.Text = "Fecha final: " + sub.Fin;
            lDescripcion.Text = "Descripción: " + sub.Descripcion;
            lPrecio.Text = "Precio: " + sub.Precio;
            if (funcionalidad == 1)
            {
                bDelPuja.Text = "Pujar";
            }
            else if (funcionalidad == 2)
            {
                bDelPuja.Text = "Eliminar";
            }
        }

        private void bDelPuja_Click(object sender, EventArgs e)
        {
            if (funcionalidad == 1)
            {
                // FUNCION PUJAR - En esta abre una pestaña en la que se pide lo que quiere pujar el usuario
            }
            else if (funcionalidad == 2)
            {
                // FUNCION ELIMINAR - En esta abre una pestaña en la que se pide una confirmación para eliminar la subasta
            }
        }

        private void bVer_Click(object sender, EventArgs e)
        {
            // Esta funcion llamará al PanelSubasta con los datos de la subasta en cuestión
            if (funcionalidad == 1)
            {
                Sesion.mostrarSubasta(sub, 2);
            }
            else if (funcionalidad == 2)
            {
                Sesion.mostrarSubasta(sub, 3);
            }
        }
    }
}
