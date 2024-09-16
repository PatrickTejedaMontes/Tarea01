using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Computadora computadora = new Computadora(1,"Lenovo","black",500);

            Listado(computadora);

            computadora.PrecioDolare -= 0.10*computadora.PrecioDolare;

            Listado(computadora);




            Console.ReadKey(); 
        }

        public static void Listado(Computadora computadora) {
            Console.WriteLine("Código: " + computadora.Codigo);
            Console.WriteLine("Marca: " + computadora.Marca);
            Console.WriteLine("Color: " + computadora.Color);
            Console.WriteLine("Precio en dolares: " + computadora.PrecioDolare);
            Console.WriteLine("Precio en soles: " + computadora.precioSoles());
            Console.WriteLine("Precio en euros: " + computadora.precioEuros());
        
        }

    }
}
