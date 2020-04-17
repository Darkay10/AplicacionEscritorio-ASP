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

        public static List<Usuario> users = new List<Usuario>();

        public static async void GetUsersAsync()
        {
            
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://192.168.0.21:45081/api/%22");
                var respuesta = client.GetAsync("Product");
                respuesta.Wait();

                var response = respuesta.Result;
                if (response.IsSuccessStatusCode)
                {
                    var lectura = response.Content.ReadAsAsync<Usuario[]>();
                    lectura.Wait();

                    var usuarios = lectura.Result;
                    users = new List<Usuario>();
                    foreach (var usuario in usuarios)
                    {
                        users.Add(usuario);
                    }
                }
            }
        }
    }
}
