using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Asesor asesor = new Asesor(1,10,"Patrick Jam" ,20);

            Listado(asesor);

            asesor.HorasTra += 10;
            asesor.TarifaHora -= 0.15 * asesor.TarifaHora;

            Listado(asesor);

            Console.ReadKey();

        }

        public static void Listado(Asesor asesor) { 
                Console.WriteLine("Codigo: "+ asesor.Codigo);
            Console.WriteLine("Nombre: " + asesor.Nombre);
            Console.WriteLine("Horas trabajadas: " + asesor.HorasTra);
            Console.WriteLine("Tarifa por hora: " + asesor.TarifaHora);
            Console.WriteLine("Sueldo bruto: " + asesor.SueldoBruto());
            Console.WriteLine("Descuento: " + asesor.Descuento());
            Console.WriteLine("Sueldo Neto: " + asesor.SueldoNeto());
        
        }
    }
}
