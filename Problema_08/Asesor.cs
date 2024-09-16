using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_08
{
    internal class Asesor
    {
        private int horasTra;
        private string nombre;
        private double tarifaHora;
        private int codigo;

        public Asesor(int codigo, int horasTra, string nombre, double tarifaHora)
        {
            this.Codigo = codigo;
            this.HorasTra = horasTra;
            this.Nombre = nombre;
            this.TarifaHora = tarifaHora;
        }

        public int Codigo { get => codigo; set => codigo = value; }
        public int HorasTra { get => horasTra; set => horasTra = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public double TarifaHora { get => tarifaHora; set => tarifaHora = value; }

        public double SueldoBruto() {
            return horasTra*tarifaHora;
        }

        public double Descuento() { 
            return 0.15 * SueldoBruto();
        }

        public double SueldoNeto() {
            return SueldoBruto() - Descuento();
        }




    }


}
