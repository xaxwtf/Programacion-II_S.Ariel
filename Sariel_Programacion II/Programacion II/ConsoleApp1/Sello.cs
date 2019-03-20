using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public  static class Sello
    {
        public static string mensaje;
        public static ConsoleColor Color;
        public static string Imprimir()
        {
            return Sello.mensaje;
        }
        public static void Borrar()
        {
            Sello.mensaje = " ";
        }
        public static void ImprimirenColor()
        {
            Console.ForegroundColor = Sello.Color;
            Console.WriteLine(Sello.Imprimir());
            Console.ForegroundColor = ConsoleColor.Gray;
        }
        private static string ArmarformatodeMensaje()
        {
            string Techo =" ";
            int tam = Sello.mensaje.Length;
            for(int i=-2;i<=tam;i++)
            {
                Techo += "*";
            }
            return Techo + "\n*" + Sello.mensaje + "*\n"+ Techo;
        }


    }
}
