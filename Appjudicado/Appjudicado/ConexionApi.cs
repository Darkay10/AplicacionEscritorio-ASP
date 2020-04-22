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
                client.BaseAddress = new Uri("http://25.132.197.74:44444/api/Usuario");
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
                client.BaseAddress = new Uri("http://25.132.197.74:44444/api/Usuario");
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
    }
}
