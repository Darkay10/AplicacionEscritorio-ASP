using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Appjudicado
{
    public class Sesion
    {
        public static Usuario logged;

        public static void blank()
        {
            logged = new Usuario();
        }

        public static bool login(string nick, string pass)
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

        public static int registro(string nick, string p, string e, string d, string l, string pais, string cod)
        {
            int reg = 0;
            ConexionApi.start();
            ConexionApi.GetUsersAsync();
            foreach (Usuario u in ConexionApi.users)
            {
                if (u.User.Equals(nick))
                {
                    logged = u;
                    reg = 1;
                }
            }
            if (reg == 0)
            {
                bool res = ConexionApi.RegistrarUser(nick, p, e, d, l, pais, cod);
            }
            return reg;
        }
    }
}
