using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_03
{
    internal class Edificio
    {

        private int codigo , numDepa,cantPisos;
        private double precioDepa;

        public Edificio(int codigo, int numDepa, int cantPisos, double precioDepa)
        {
            this.Codigo = codigo;
            this.NumDepa = numDepa;
            this.CantPisos = cantPisos;
            this.PrecioDepa = precioDepa;
        }

        public int Codigo { get => codigo; set => codigo = value; }
        public int NumDepa { get => numDepa; set => numDepa = value; }
        public int CantPisos { get => cantPisos; set => cantPisos = value; }
        public double PrecioDepa { get => precioDepa; set => precioDepa = value; }

        public double preciDolaresEdi() {
            return numDepa * precioDepa;    
        }



    }
}
