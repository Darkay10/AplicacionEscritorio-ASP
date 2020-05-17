using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Appjudicado
{
    public class Usuario
    {
        private int id;
        private string user;
        private string pass;
        private string email;
        private string direccion;
        private string localidad;
        private string cp;
        private string pais;
        private int rol;
        private bool habilitado;

        public Usuario()
        {

        }

        public Usuario(int id, string nick, string p, string e, string d, string l, string pais, string cod, int rol, bool hab)
        {
            this.id = id;
            this.user = nick;
            this.pass = p;
            this.email = e;
            this.direccion = d;
            this.localidad = l;
            this.pais = pais;
            this.cp = cod;
            this.rol = rol;
            this.habilitado = hab;
        }

        public int Id { get => id; set => id = value; }
        public string User { get => user; set => user = value; }
        public string Pass { get => pass; set => pass = value; }
        public string Email { get => email; set => email = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public string Localidad { get => localidad; set => localidad = value; }
        public string Cp { get => cp; set => cp = value; }
        public string Pais { get => pais; set => pais = value; }
        public int Rol { get => rol; set => rol = value; }
        public bool Habilitado { get => habilitado; set => habilitado = value; }
    }
}
