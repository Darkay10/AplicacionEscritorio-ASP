﻿using System;
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
           if (funcionalidad == 1)    //  EDITAR USUARIO
            {
                datosUser();
                modoLectura();
                bAcepMod.Text = "Modificar";
                bChangeDel.Text = "Eliminar";
            }
            else if (funcionalidad == 2)    // PERFIL
            {
                datosUser();
                modoLectura();
                bAcepMod.Text = "Modificar";
                bChangeDel.Text = "Cambiar contraseña";
            }
        }

        private void bAcepMod_Click(object sender, EventArgs e)
        {
            if (funcionalidad == 1)    //  EDITAR USUARIO - Modificar y guardar
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
                    // Sesion.modificando(textbox_user.Text, textbox_email.Text, textbox_direccion.Text, textbox_codigo_postal.Text, textbox_localidad.Text,textbox_pais.Text);
                }
            }
            else if (funcionalidad == 2)    // PERFIL - Modificar y guardar
            {
                if (editando == false)
                {
                    modoLectura();
                    modoEditar();
                    bAcepMod.Text = "Guardar";
                    bChangeDel.Text = "Cancelar";
                }
                else
                {
                    bAcepMod.Text = "Modificar";
                    bChangeDel.Text = "Cambiar contraseña";
                }
            }
        }

        private void bChangeDel_Click(object sender, EventArgs e)
        {
            if (funcionalidad == 1)    //  EDITAR USUARIO - Eliminar y Cancelar
            {
                if (editando == false)
                {
                    editando = true;
                    //Sesion.eliminarUsuario(user);
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
                    editando = true;
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
            textbox_pass.Text = user.Pass;
            textbox_email.Text = user.Email;
            textbox_direccion.Text = user.Direccion;
            textbox_codigo_postal.Text = user.Cp;
            textbox_localidad.Text = user.Localidad;
            textbox_pais.Text = user.Pais;
        }

        private void modoLectura()
        {
            textbox_user.ReadOnly = true;
            textbox_pass.ReadOnly = true;
            textbox_email.ReadOnly = true;
            textbox_direccion.ReadOnly = true;
            textbox_codigo_postal.ReadOnly = true;
            textbox_localidad.ReadOnly = true;
            textbox_pais.ReadOnly = true;
        }

        private void modoEditar()
        {
            textbox_user.ReadOnly = false;
            textbox_pass.ReadOnly = false;
            textbox_email.ReadOnly = false;
            textbox_direccion.ReadOnly = false;
            textbox_codigo_postal.ReadOnly = false;
            textbox_localidad.ReadOnly = false;
            textbox_pais.ReadOnly = false;
        }
    }
}
