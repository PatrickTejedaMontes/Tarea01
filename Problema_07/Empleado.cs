using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_07
{
    internal class Empleado
    {
        private int numeroCel;
        private string nombre;
        private double sueldoSole;
        private int codigo;

        public Empleado(int codigo, int numeroCel, string nombre, double sueldoSole)
        {
            this.Codigo = codigo;
            this.NumeroCel = numeroCel;
            this.Nombre = nombre;
            this.SueldoSole = sueldoSole;
        }

        public int Codigo { get => codigo; set => codigo = value; }
        public int NumeroCel { get => numeroCel; set => numeroCel = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public double SueldoSole { get => sueldoSole; set => sueldoSole = value; }

        public string TextoIndicado()
        {
            if (sueldoSole > 3500)
                return "Mayor a 3500";
            else if (sueldoSole < 3500)
                return "Menor a 3500";
            else
                return "Igual a 3500";
        }


    }
}
