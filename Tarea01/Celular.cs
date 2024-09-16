using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea01
{
    internal class Celular
    {
        private int numero, segundosConsu;
        private double precioporSeg;
        private string usuario;

        public int Numero { get => numero; set => numero = value; }
        public int SegundosConsu { get => segundosConsu; set => segundosConsu = value; }
        public double PrecioporSeg { get => precioporSeg; set => precioporSeg = value; }
        public string Usuario { get => usuario; set => usuario = value; }

        public Celular(int numero, int segundosConsu, double precioporSeg, string usuario)
        {
            this.numero = numero;
            this.segundosConsu = segundosConsu;
            this.precioporSeg = precioporSeg;
            this.usuario = usuario;
        }

        public double CostoPorConsumo() {
            return segundosConsu * precioporSeg;
        }

        public double ImpuestoIgv() {
            return CostoPorConsumo() * 0.18;
        }

        public double TotalPagar() {
            return CostoPorConsumo() + ImpuestoIgv();

        }







    }
}

