using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Edificio edificio = new Edificio(1,20,100,100);

            Listado(edificio);

            edificio.PrecioDepa += 0.20 * edificio.PrecioDepa;

            Listado(edificio);

            Console.ReadKey();
        }

        public static void Listado(Edificio edificio) {
            Console.WriteLine("Codigo : " + edificio.Codigo);
            Console.WriteLine("Número de Departamento: " + edificio.NumDepa);
            Console.WriteLine("Cantidad de pisos: " + edificio.CantPisos);
            Console.WriteLine("Precio de departamento: " + edificio.PrecioDepa);
            Console.WriteLine("Precio del edificio: " + edificio.preciDolaresEdi());
        }



    }
}
