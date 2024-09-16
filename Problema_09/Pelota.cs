using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_09
{
    internal class Pelota
    {
        private string marca;
        private double precio;
        private double pesoGramos;
        private double presionLib;
        private double diamCenti;

        public string Marca { get => marca; set => marca = value; }
        public double PesoGramos { get => pesoGramos; set => pesoGramos = value; }
        public double PresionLib { get => presionLib; set => presionLib = value; }
        public double DiamCenti { get => diamCenti; set => diamCenti = value; }
        public double Precio { get => precio; set => precio = value; }

        public Pelota(string marca, double pesoGramos, double presionLib, double diamCenti, double precio)
        {
            this.Marca = marca;
            this.PesoGramos = pesoGramos;
            this.PresionLib = presionLib;
            this.DiamCenti = diamCenti;
            this.Precio = precio;
        }

        public double Radio() {
            return diamCenti / 2;
        }

        public double Volumen() {
            return 4 * 3.1416 * Radio() * Radio() * Radio() / 3 ;
        }
        public double Descuento() {
            return 0.10 * precio;
        }

        public double PrecioPagar() { 
            return precio - Descuento();
        }

    }
}
