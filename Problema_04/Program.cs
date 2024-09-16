using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
                    Obrero obrero= new Obrero(1,10,"Juan",10);

                    Listado(obrero);

                    obrero.HorasTraba += 8;
                    obrero.Tarifa -= 0.015 * obrero.Tarifa;

                    Listado(obrero);
                    
            Console.ReadKey();
        }

        public static void Listado(Obrero obrero ) { 
                Console.WriteLine("Código : "+ obrero.Codigo);
            Console.WriteLine("Nombre : " + obrero.Nombre);
            Console.WriteLine("Horas Trabajadas: " + obrero.HorasTraba);
            Console.WriteLine("Tarifa : " + obrero.Tarifa);
            Console.WriteLine("Sueldo Bruto : " + obrero.SueldoBruto());
            Console.WriteLine("Descuento AFP: " + obrero.DescuentoAFP());
            Console.WriteLine("Descuento EPS: "+ obrero.DescuentoEPS());
            Console.WriteLine("Sueldo Neto: " + obrero.SueldoNeto());   
        }

    }
}
