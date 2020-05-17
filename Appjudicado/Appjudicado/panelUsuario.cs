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
    public partial class PanelUsuario : UserControl
    {
        private int funcionalidad = 0;
        private Usuario user;
        private bool editando = false;
        public PanelUsuario(int fun, Usuario u)
        {
            InitializeComponent();
            funcionalidad = fun;
            user = u;
        }

        private void PanelUsuario_Load(object sender, EventArgs e)
        {
            datosUser();
            modoLectura();
            if (funcionalidad == 1)    //  EDITAR USUARIO
            {
                cbAdmin.Show();
                bAcepMod.Text = "Modificar";
                bChangeDel.Text = "Eliminar";
            }
            else if (funcionalidad == 2)    // PERFIL
            {
                bAcepMod.Text = "Modificar";
                bChangeDel.Text = "Cambiar contraseña";
            }
        }

        private void bAcepMod_Click(object sender, EventArgs e)
        {
            //  EDITAR USUARIO y PERFIL - Modificar y guardar - Los 2 hacen la misma funcion, entonces no hay porque usar la var "Funcionalidad"
            if (funcionalidad == 1)    //  EDITAR USUARIO
            {
                if (editando == false)
                {
                    editando = true;
                    modoEditar();
                    bAcepMod.Text = "Guardar";
                    bChangeDel.Text = "Cancelar";
                }
                else
                {
                    editando = false;
                    modoLectura();
                    bAcepMod.Text = "Modificar";
                    bChangeDel.Text = "Eliminar";
                    if (cbAdmin.Checked)
                    {
                        Sesion.guardarUsuario(user, textbox_user.Text, user.Pass, textbox_email.Text, textbox_direccion.Text, textbox_localidad.Text, textbox_pais.Text, textbox_codigo_postal.Text, 1, funcionalidad);
                    }
                    else
                    {
                        Sesion.guardarUsuario(user, textbox_user.Text, user.Pass, textbox_email.Text, textbox_direccion.Text, textbox_localidad.Text, textbox_pais.Text, textbox_codigo_postal.Text, 0, funcionalidad);
                    }
                }
            }
            else if (funcionalidad == 2)    // PERFIL
            {
                if (editando == false)
                {
                    editando = true;
                    modoEditar();
                    bAcepMod.Text = "Guardar";
                    bChangeDel.Text = "Cancelar";
                }
                else
                {
                    editando = false;
                    modoLectura();
                    bAcepMod.Text = "Modificar";
                    bChangeDel.Text = "Cambiar contraseña";
                    Sesion.guardarUsuario(user, textbox_user.Text, user.Pass, textbox_email.Text, textbox_direccion.Text, textbox_localidad.Text, textbox_pais.Text, textbox_codigo_postal.Text, user.Rol, funcionalidad);
                }
            }
        }

        private void bChangeDel_Click(object sender, EventArgs e)
        {
            if (funcionalidad == 1)    //  EDITAR USUARIO - Eliminar y Cancelar
            {
                if (editando == false)
                {
                    Sesion.eliminarUsuario(user);
                }
                else
                {
                    editando = false;
                    modoLectura();
                    bAcepMod.Text = "Modificar";
                    bChangeDel.Text = "Eliminar";
                }
            }
            else if (funcionalidad == 2)    // PERFIL - Cambiar contraseña y Cancelar
            {
                if (editando == false)
                {
                    // Sesion.cambiarContra(user);
                }
                else
                {
                    editando = false;
                    modoLectura();
                    bAcepMod.Text = "Modificar";
                    bChangeDel.Text = "Cambiar contraseña";
                }
            }
        }

        private void datosUser()
        {
            textbox_user.Text = user.User;
            textbox_email.Text = user.Email;
            textbox_direccion.Text = user.Direccion;
            textbox_codigo_postal.Text = user.Cp;
            textbox_localidad.Text = user.Localidad;
            textbox_pais.Text = user.Pais;
            //if (user.Rol == 1)
                //cbAdmin.
        }

        private void modoLectura()
        {
            textbox_user.ReadOnly = true;
            textbox_email.ReadOnly = true;
            textbox_direccion.ReadOnly = true;
            textbox_codigo_postal.ReadOnly = true;
            textbox_localidad.ReadOnly = true;
            textbox_pais.ReadOnly = true;
        }

        private void modoEditar()
        {
            textbox_user.ReadOnly = false;
            textbox_email.ReadOnly = false;
            textbox_direccion.ReadOnly = false;
            textbox_codigo_postal.ReadOnly = false;
            textbox_localidad.ReadOnly = false;
            textbox_pais.ReadOnly = false;
        }
    }
}
