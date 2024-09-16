using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Probema_06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Paciente paciente = new Paciente(18,"Juan","Perez",1.75,70);

            Listado(paciente);

            paciente.Edad = 16;

            Listado(paciente);

            Console.ReadKey();
        }

        public static void Listado(Paciente paciente) {
            Console.WriteLine($"Nombre y Apellido: {paciente.Nombre} {paciente.Apellido}");
            Console.WriteLine("Edad: " + paciente.Edad);
            Console.WriteLine("Talla: " + paciente.Talla);
            Console.WriteLine("Peso: " + paciente.Peso);
            Console.WriteLine("Verificacion de edad: " + paciente.verificarEdad());

        }
    }
}
