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
    public partial class PanelSubasta : UserControl
    {
        private int funcionalidad = 0;
        private Subasta sub;
        private bool editando = false;

        public PanelSubasta(int fun)    // (1) Crear
        {
            InitializeComponent();
            funcionalidad = fun;
        }

        public PanelSubasta(int fun, Subasta s)    // (2) Otras Subastas - (3) Tus subastas
        {
            InitializeComponent();
            funcionalidad = fun;
            sub = s;
        }

        private void PanelSubasta_Load(object sender, EventArgs e)
        {
            if (funcionalidad == 1) // CREAR SUBASTA
            {
                modoEditar();
                bAdd.Text = "Añadir";
                bEliminar.Text = "Cancelar";
            }
            else if (funcionalidad == 2)   // VER SUBASTAS 
            {
                datosSubasta();
                modoLectura();
                bAdd.Text = "Pujar";
                bEliminar.Text = "Cancelar";
            }
            else if (funcionalidad == 3)    // MIS SUBASTAS
            {
                datosSubasta();
                modoLectura();
                bAdd.Text = "Modificar";
                bEliminar.Text = "Eliminar";
            }
        }

        private void bEliminar_Click(object sender, EventArgs e)
        {
            if (funcionalidad == 1) // CREAR SUBASTA
            {
               // CANCELAR QUE DEBERIA CERRAR EL PANEL Y YA
            }
            else if (funcionalidad == 2)   // VER SUBASTAS 
            {
                // CANCELAR QUE DEBERIA CERRAR EL PANEL Y YA
            }
            else if (funcionalidad == 3)    // MIS SUBASTAS
            {
                // FUNCION EN LA QUE SALE UN PANEL Y DICE SI QUIERE QUE LO ELIMINEMOS
                if (editando == false)
                {
                    // FUNCION ELIMINAR
                }
                else
                {
                    editando = false;
                    datosSubasta();
                    modoLectura();
                    bAdd.Text = "Modificar";
                    bEliminar.Text = "Eliminar";
                }
            }
        }

        private void bAdd_Click(object sender, EventArgs e)
        {
            if (funcionalidad == 1) // CREAR SUBASTA
            {
                // SE COMPRUEBA QUE TODOS LOS DATOS SEAN CORRECTOS Y DESPUES SE INTRODUCE
            }
            else if (funcionalidad == 2)   // VER SUBASTAS 
            {
                // SE MUESTRA UN CARTEL PARA PUJAR LO QUE EL USUARIO QUIERA
            }
            else if (funcionalidad == 3)    // MIS SUBASTAS
            {
                if (editando == false)
                {
                    editando = true;
                    modoEditar();
                    bAdd.Text = "Guardar";
                    bEliminar.Text = "Cancelar";
                }
                else
                {
                    // FUNCION EDITAR SUBASTA
                }
            }
        }
        
        private void datosSubasta()
        {
            textbox_articulo.Text = sub.Articulo;
            textbox_categoria.Text = sub.Categoria;
            textbox_descripcion.Text = sub.Descripcion;
            textbox_precio.Text = sub.Precio.ToString();
            textbox_imagen.Text = sub.Imagen;
            textbox_fechainicio.Text = sub.Comienzo.ToString();
            textbox_fechafin.Text = sub.Fin.ToString();
        }

        private void modoLectura()
        {
            textbox_articulo.ReadOnly = true;
            textbox_categoria.ReadOnly = true;
            textbox_descripcion.ReadOnly = true;
            textbox_precio.ReadOnly = true;
            textbox_imagen.ReadOnly = true;
            textbox_fechainicio.ReadOnly = true;
            textbox_fechafin.ReadOnly = true;
        }

        private void modoEditar()
        {
            textbox_articulo.ReadOnly = false;
            textbox_categoria.ReadOnly = false;
            textbox_descripcion.ReadOnly = false;
            textbox_precio.ReadOnly = false;
            textbox_imagen.ReadOnly = false;
            textbox_fechainicio.ReadOnly = false;
            textbox_fechafin.ReadOnly = false;
        }
    }
}
