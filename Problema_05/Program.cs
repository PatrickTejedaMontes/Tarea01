using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Video video = new Video(1,"50 sobras de Pat",2,20,3.77);

            Listado(video);

            video.PreSoles += 5.50;

            Listado(video);

            Console.ReadKey();

        }
        public static void Listado(Video video)
        {
            Console.WriteLine( "Código: "+ video.Codigo );
            Console.WriteLine("Nombre: " + video.NombreVideo );
            Console.WriteLine("Duración: " + video.Duracion );
            Console.WriteLine("Precio en soles: "+video.PreSoles );
            Console.WriteLine("Tipo de cambio: " + video.TipoCambio );
            Console.WriteLine("Precio en dolares: " + video.preDolares());

        }
    }
}
