using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Sello.Color = ConsoleColor.Blue;
            Sello.mensaje = "hola";
            Console.WriteLine(Sello.Imprimir());
            Sello.ImprimirenColor();
            Console.WriteLine(Sello.Imprimir());
            Console.ReadKey();
            Sello.Borrar();


        }
    }
}
