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
    }
}
