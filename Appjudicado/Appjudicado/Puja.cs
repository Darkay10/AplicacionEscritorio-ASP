﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Appjudicado
{
    public class Puja
    {
        private int subasta;
        private int pujador;
        private float cantidad;
        private DateTime tiempo;

        public Puja(int subasta, int pujador, float cantidad, DateTime tiempo)
        {
            this.subasta = subasta;
            this.pujador = pujador;
            this.cantidad = cantidad;
            this.tiempo = tiempo;
        }
    }
}
