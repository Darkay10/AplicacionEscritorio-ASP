using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Appjudicado
{
    public class Sesion
    {
        public static Usuario logged;
        private static List<Subasta> listadoSubastas;
        private static List<Usuario> listadoUsuarios;

        public static void blank()  // INICIALIZAMOS LA VARIABLE LOGGED - Que es con la que trabajamos como el usuario conectado
        {
            logged = new Usuario();
        }

        public static bool login(string nick, string pass)  // Funcion que comprueba que el login exista
        {
            bool log = false;
            ConexionApi.start();
            ConexionApi.GetUsersAsync();
            foreach(Usuario u in ConexionApi.users)
            {
                if(u.User.Equals(nick) && u.Pass.Equals(pass))
                {
                    logged = u;
                    log = true;
                }
            }
            return log;
        }

        public static void guardarUsuario(string nick, string p, string e, string d, string l, string pais, string cod)
        {
            // POR AHORA NADA
        }

        public static int registro(string nick, string p, string e, string d, string l, string pais, string cod)    // Funcion que llama la pagina registro.cs
        {
            int reg = 0;
            ConexionApi.start();
            ConexionApi.GetUsersAsync();
            foreach (Usuario u in ConexionApi.users)
            {
                if (u.User.Equals(nick))    // ERROR SI EL NICK EXISTE
                {
                    logged = u;
                    reg = 1;
                }
            }
            if (reg == 0)
            {
                bool res = ConexionApi.RegistrarUser(nick, p, e, d, l, pais, cod);  // Se inserta el usuario
                if (res)    // SE HA INSERTADO CORRECTAMENTE
                    reg = 0;
                else        // HEMOS TENIDO UN ERROR AL INSERTAR
                    reg = 2;
            }
            return reg;
        }

        public static void cancelar()   // OCULTA EL PANEL
        {
            Main.panel.Hide();
        }

        public static void mostrarPerfil()  //FUNCION QUE LLAMA EL BOTON "VER PERFIL" del main.cs - BOTONES
        {
            if (Main.panel.Controls.Count > 0)
            {
                Main.panel.Controls.Clear();
            }
            PanelUsuario perfil = new PanelUsuario(2, Sesion.logged);
            Main.panel.Controls.Add(perfil);
            Main.panel.Show();
        }

        public static void crearSubasta()   // FUNCION QUE LLAMA EL BOTON "CREAR SUBASTA" del main.cs - FALTA TERMINAR
        {
            if (Main.panel.Controls.Count > 0)
            {
                Main.panel.Controls.Clear();
            }
            PanelSubasta perfil = new PanelSubasta(1);
            Main.panel.Controls.Add(perfil);
            Main.panel.Show();
        }
        
        public static void verSubastas()    // FUNCION QUE LLAMA EL BOTON "VER SUBASTAS" del main.cs - BOTONES
        {
            ConexionApi.start();
            ConexionApi.verSubastas(logged.Id);
            listadoSubastas = new List<Subasta>();
            foreach (Subasta s in ConexionApi.subastas)
            {
                listadoSubastas.Add(s);
            }
            if (Main.panel.Controls.Count > 0)
            {
                Main.panel.Controls.Clear();
            }
            for (int i = 0; i < listadoSubastas.Count(); i++)
            {
                ListadoSubastas userControl = new ListadoSubastas(listadoSubastas[i], 1);
                Main.panel.Controls.Add(userControl);
            }
            Main.panel.Show();
        }

        public static void misSubastas()    // FUNCION QUE LLAMA EL BOTON "MIS SUBASTAS" del main.cs - BOTONES
        {
            ConexionApi.start();
            ConexionApi.misSubastas(logged.Id);
            listadoSubastas = new List<Subasta>();
            foreach (Subasta s in ConexionApi.subastas)
            {
                listadoSubastas.Add(s);
            }
            if (Main.panel.Controls.Count > 0)
            {
                Main.panel.Controls.Clear();
            }
            for (int i = 0; i < listadoSubastas.Count(); i++)
            {
                ListadoSubastas userControl = new ListadoSubastas(listadoSubastas[i], 2);
                Main.panel.Controls.Add(userControl);
            }
            Main.panel.Show();
        }

        public static void administrarUsers()    // FUNCION QUE LLAMA EL BOTON "ADMINISTRAR USUARIOS" del main.cs - FALTA TERMINAR
        {
            ConexionApi.start();
            ConexionApi.administrarUsers(logged.Id);
            listadoUsuarios = new List<Usuario>();
            foreach (Usuario u in ConexionApi.users)
            {
                listadoUsuarios.Add(u);
            }
            if (Main.panel.Controls.Count > 0)
            {
                Main.panel.Controls.Clear();
            }
            for (int i = 0; i < listadoUsuarios.Count(); i++)
            {
                ListadoUsuarios userControl = new ListadoUsuarios(listadoUsuarios[i]);
                Main.panel.Controls.Add(userControl);
            }
            Main.panel.Show();
        }

        public static void mostrarUsuario(Usuario u, int fun)
        {
            if (Main.panel.Controls.Count > 0)
            {
                Main.panel.Controls.Clear();
            }
            PanelUsuario perfil = new PanelUsuario(fun, u);
            Main.panel.Controls.Add(perfil);
            Main.panel.Show();
        }

        public static void mostrarSubasta(Subasta s, int fun)
        {
            if (Main.panel.Controls.Count > 0)
            {
                Main.panel.Controls.Clear();
            }
            PanelSubasta perfil = new PanelSubasta(fun, s);
            Main.panel.Controls.Add(perfil);
            Main.panel.Show();
        }
    }
}
