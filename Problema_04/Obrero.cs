using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_04
{
    internal class Obrero
    {

        private int codigo, horasTraba;
        private string nombre;
        private double tarifa;

        public Obrero(int codigo, int horasTraba, string nombre, double tarifa)
        {
            this.Codigo = codigo;
            this.HorasTraba = horasTraba;
            this.Nombre = nombre;
            this.Tarifa = tarifa;
        }

        public int Codigo { get => codigo; set => codigo = value; }
        public int HorasTraba { get => horasTraba; set => horasTraba = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public double Tarifa { get => tarifa; set => tarifa = value; }


        public double SueldoBruto() {
            return horasTraba * tarifa;
        }

        public double DescuentoAFP() { 
            return 0.10* SueldoBruto();
        }
        public double DescuentoEPS() {
            return 0.05 * SueldoBruto();
        }

        public double SueldoNeto() { 
            return SueldoBruto()-DescuentoAFP()- DescuentoEPS();
        }



    }
}
