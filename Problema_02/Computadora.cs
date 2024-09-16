using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_02
{
    internal class Computadora
    {
        private int codigo;
        private string marca,color;
        private double precioDolare;

        public int Codigo { get => codigo; set => codigo = value; }
        public string Marca { get => marca; set => marca = value; }
        public string Color { get => color; set => color = value; }
        public double PrecioDolare { get => precioDolare; set => precioDolare = value; }

        public Computadora(int codigo, string marca, string color, double precioDolare)
        {
            this.codigo = codigo;
            this.marca = marca;
            this.color = color;
            this.precioDolare = precioDolare;
        }

        public double precioSoles() {
            return precioDolare * 3.35;
        }

        public double precioEuros() {
            return precioDolare * 1.20;
        }
    }
}
