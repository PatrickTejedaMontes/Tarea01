using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Probema_06
{
    internal class Paciente
    {

        private int edad;
        private string nombre, apellido;
        private double talla, peso;

        public Paciente(int edad, string nombre, string apellido, double talla, double peso)
        {
            this.Edad = edad;
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Talla = talla;
            this.Peso = peso;
        }

        public int Edad { get => edad; set => edad = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public double Talla { get => talla; set => talla = value; }
        public double Peso { get => peso; set => peso = value; }

        public string verificarEdad() {
            if (edad >= 18)
                return "Mayor de edad";
            else
                return "Menor de edad";
        }


    }
}
