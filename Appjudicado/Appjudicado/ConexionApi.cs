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
        public static List<Subasta> subastas;
        public static Subasta sub;
        public static float pujamax;
        public static void start()  // Funcion que inicializa todos los tipos de variables con los que podremos trabajar
        {
            users = new List<Usuario>();
            user = new Usuario();
            subastas = new List<Subasta>();
            sub = new Subasta();
        }

        public static async void GetUsersAsync()    // FUNCION QUE SE USA PARA RECOGER TODOS LOS USUARIOS (LOGIN, REGISTRO)
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

        public static async void verSubastas(int id)    // FUNCION QUE SE UTILIZA PARA EL BOTON "VER SUBASTAS"
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://25.132.197.74:44444/api/Subasta/GetAllSubastasMenosUno/");
                var respuesta = client.GetAsync(string.Format("?id={0}", id));
                respuesta.Wait();

                var response = respuesta.Result;
                if (response.IsSuccessStatusCode)
                {
                    var lectura = response.Content.ReadAsAsync<Subasta[]>();
                    lectura.Wait();

                    var listasubastas = lectura.Result;

                    foreach (var subas in listasubastas)
                    {
                        subastas.Add(subas);
                    }
                }
            }
        }

        public static async void misSubastas(int id)    // FUNCION QUE SE UTILIZA PARA EL BOTON "MIS SUBASTAS"
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://25.132.197.74:44444/api/Subasta/GetSubastaMias/");
                var respuesta = client.GetAsync(string.Format("?id={0}", id));
                respuesta.Wait();

                var response = respuesta.Result;
                if (response.IsSuccessStatusCode)
                {
                    var lectura = response.Content.ReadAsAsync<Subasta[]>();
                    lectura.Wait();

                    var listasubastas = lectura.Result;

                    foreach (var subas in listasubastas)
                    {
                        subastas.Add(subas);
                    }
                }
            }
        }

        public static async void pujaMaxima(int id)    // FUNCION QUE SE UTILIZA SACAR EL MAXIMO DE LA PUJA
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://25.132.197.74:44444/api/Subasta/GetSubastaMias/");
                var respuesta = client.GetAsync(string.Format("?id={0}", id));
                respuesta.Wait();

                var response = respuesta.Result;
                if (response.IsSuccessStatusCode)
                {
                    var lectura = response.Content.ReadAsAsync<Subasta[]>();
                    lectura.Wait();

                    var listasubastas = lectura.Result;

                    foreach (var subas in listasubastas)
                    {
                        subastas.Add(subas);
                    }
                }
            }
        }

        public static async void administrarUsers(int id) // FUNCION QUE SE UTILIZA PARA EL BOTON "ADMINISTRAR USUARIOS"
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://25.132.197.74:44444/api/Usuario/GetUsuariosMenosUno/");
                var respuesta = client.GetAsync(string.Format("?id={0}", id));
                respuesta.Wait();

                var response = respuesta.Result;
                if (response.IsSuccessStatusCode)
                {
                    var lectura = response.Content.ReadAsAsync<Usuario[]>();
                    lectura.Wait();

                    var listausuario = lectura.Result;

                    foreach (var user in listausuario)
                    {
                        users.Add(user);
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

        public static bool guardarUsuario(int id, string nick, string p, string e, string d, string l, string pais, string cod, int rol)
        {
            using (var client = new HttpClient())
            {
                bool res = false;
                client.BaseAddress = new Uri("http://25.132.197.74:44444/api/Usuario/UpdateUsuario/");
                var respuesta = client.GetAsync(string.Format("?id={0}&u={1}&p={2}&e={3}&d={4}&l={5}&pais={6}&cod={7}&rol={8}", id, nick, p, e, d, l, pais, cod, rol));
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

        public static bool eliminarUsuario(Usuario us)
        {
            using (var client = new HttpClient())
            {
                bool res = false;
                client.BaseAddress = new Uri("http://25.132.197.74:44444/api/Usuario/DeshabilitarUsuario/");
                var respuesta = client.GetAsync(string.Format("?id={0}", us.Id));
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

        public static bool cambiarContra(int id, string p)
        {
            using (var client = new HttpClient())
            {
                bool res = false;
                client.BaseAddress = new Uri("http://25.132.197.74:44444/api/Usuario/cambiarContra/");
                var respuesta = client.GetAsync(string.Format("?id={0}&pass={1}", id, p));
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
