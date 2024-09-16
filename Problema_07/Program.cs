using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Empleado empleado = new Empleado(1,904363595,"Patrick",3500);

            Listado(empleado);

            empleado.NumeroCel = 999888777;

            empleado.SueldoSole += 200;

            Listado(empleado);

            Console.ReadKey();

        }

        public static void Listado(Empleado empleado) {
            Console.WriteLine("Codigo : " + empleado.Codigo);
            Console.WriteLine("Nombre: " + empleado.Nombre);
            Console.WriteLine("Número de cel : " + empleado.NumeroCel);
            Console.WriteLine("Sueldo : " + empleado.SueldoSole);
            Console.WriteLine("Validacion de sueldo: " + empleado.TextoIndicado());
        }
    }
}
