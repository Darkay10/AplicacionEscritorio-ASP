using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Appjudicado
{
    public class ConexionApi
    {

        public static List<Usuario> users;
        public static Usuario user;

        public static void start()
        {
            users = new List<Usuario>();
            user = new Usuario();
        }

        public static async void GetUsersAsync()
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://25.132.197.74:44444/api/Usuario/GetAllUsuarios/");
                var respuesta = client.GetAsync("Usuario");
                respuesta.Wait();

                var response = respuesta.Result;
                if (response.IsSuccessStatusCode)
                {
                    var lectura = response.Content.ReadAsAsync<Usuario[]>();
                    lectura.Wait();

                    var usuarios = lectura.Result;
                    
                    foreach (var usuario in usuarios)
                    {
                        users.Add(usuario);
                    }
                }
            }
        }

        public static async void GetUserAsync(int id)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://25.132.197.74:44444/api/Usuario/GetUsuario/");
                var respuesta = client.GetAsync("Usuario/"+id);
                respuesta.Wait();

                var response = respuesta.Result;
                if (response.IsSuccessStatusCode)
                {
                    var lectura = response.Content.ReadAsAsync<Usuario[]>();
                    lectura.Wait();

                    var usuarios = lectura.Result;

                    foreach (var usuario in usuarios)
                    {
                        user=usuario;
                    }
                }
            }
        }
        public static bool RegistrarUser(string nick, string p, string e, string d, string l, string pais, string cod)
        {
            using (var client = new HttpClient())
            {
                bool res = false;
                client.BaseAddress = new Uri("http://25.132.197.74:44444/api/Usuario/InsertUsuario/");
                var respuesta = client.GetAsync(string.Format("?u={0}&p={1}&e={2}&d={3}&l={4}&pais={5}&cod={6}", nick, p, e, d, l, pais, cod));
                respuesta.Wait();

                var response = respuesta.Result;
                if (response.IsSuccessStatusCode)
                {
                    var lectura = response.Content.ReadAsAsync<Boolean>();
                    lectura.Wait();
                    res = lectura.Result;
                }
                return res;
            }
        }
    }
}
