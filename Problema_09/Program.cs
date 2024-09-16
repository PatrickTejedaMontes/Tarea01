using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_09
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Pelota pelota = new Pelota("Walon" , 10 ,10,10,10);

            Listado(pelota);

            pelota.Precio -= 0.25* pelota.Precio;
            pelota.DiamCenti += 1;

            Listado(pelota);

            Console.ReadKey();
        }

        public static void Listado(Pelota pelota)
        {
            Console.WriteLine("Marca: " + pelota.Marca);
            Console.WriteLine("Peso en gramos: " + pelota.PesoGramos);
            Console.WriteLine("Presion en libras: " + pelota.PresionLib);
            Console.WriteLine("Diametro en Centimetros: " + pelota.DiamCenti);
            Console.WriteLine("Precio: " + pelota.Precio);
            Console.WriteLine("Radio: " + pelota.Radio());
            Console.WriteLine("Volumen: " + pelota.Volumen());
            Console.WriteLine("Descuento: " + pelota.Descuento());
            Console.WriteLine("Precio a pagar: " + pelota.PrecioPagar());
        }
    }
}
