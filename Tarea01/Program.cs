using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Tarea01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Celular celular = new Celular(904363595,20,100,"Juanito");

            Listado(celular);

            celular.SegundosConsu += 20;
            celular.PrecioporSeg -= 0.05 * celular.PrecioporSeg;

            Listado(celular);



            Console.ReadKey();  


        }
        public static void Listado(Celular celular)
        {
            Console.WriteLine("Usuario:  " + celular.Usuario);
            Console.WriteLine("Número: {0} " + celular.Numero);
            Console.WriteLine("Segundos de Consumo :  " +  celular.SegundosConsu);
            Console.WriteLine("Precio por consumo:  " +  celular.PrecioporSeg);
            Console.WriteLine("Costo por consumo : " +  celular.CostoPorConsumo());
            Console.WriteLine("Impuesto IGV " + celular.ImpuestoIgv());
            Console.WriteLine("Total a Pagar " + celular.TotalPagar());

        }
    }
}