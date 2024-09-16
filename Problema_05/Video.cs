using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_05
{
    internal class Video
    {
        private int codigo;
        private string nombreVideo;
        private double duracion, preSoles, tipoCambio;

        public Video(int codigo, string nombreVideo, double duracion, double preSoles, double tipoCambio)
        {
            this.Codigo = codigo;
            this.NombreVideo = nombreVideo;
            this.Duracion = duracion;
            this.PreSoles = preSoles;
            this.TipoCambio = tipoCambio;
        }

        public int Codigo { get => codigo; set => codigo = value; }
        public string NombreVideo { get => nombreVideo; set => nombreVideo = value; }
        public double Duracion { get => duracion; set => duracion = value; }
        public double PreSoles { get => preSoles; set => preSoles = value; }
        public double TipoCambio { get => tipoCambio; set => tipoCambio = value; }


        public double preDolares(){
            return preSoles * 3.77;
        }



    }
}
