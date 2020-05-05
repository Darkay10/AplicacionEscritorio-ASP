using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Appjudicado
{
    public class Subasta
    {
        private string id;
        private string articulo;
        private float precio;
        private bool finalizado;
        private Usuario vendedor;
        private Usuario comprador;
        private DateTime fin;
        private DateTime comienzo;
        private string imagen;
        private string descripcion;
        private string categoria;

        public string Id { get => id; set => id = value; }
        public string Articulo { get => articulo; set => articulo = value; }
        public float Precio { get => precio; set => precio = value; }
        public bool Finalizado { get => finalizado; set => finalizado = value; }
        public DateTime Fin { get => fin; set => fin = value; }
        public DateTime Comienzo { get => comienzo; set => comienzo = value; }
        public string Imagen { get => imagen; set => imagen = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public string Categoria { get => categoria; set => categoria = value; }
        internal Usuario Vendedor { get => vendedor; set => vendedor = value; }
        internal Usuario Comprador { get => comprador; set => comprador = value; }
    }
}
