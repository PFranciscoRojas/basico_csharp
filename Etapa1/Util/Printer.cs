using System;
using static System.Console;

namespace CoreEscuela.Util
{
    public static class Printer
    {
        public static void DibujarLinea(int tamaño = 10)
        {
            var linea = "".PadLeft(tamaño,'=');
            WriteLine(linea);
        }
        public static void WriteTittle(string titulo)
        {
            var sizeLine= titulo.Length+4;
            DibujarLinea(sizeLine);
            WriteLine($"|  {titulo}   | ");
            DibujarLinea(sizeLine);
        }
     public static void Beep (int hz = 2000,int tiempo=500, int cantidad=1)
     {
         while (cantidad-- >0)
         {
             Console.Beep(hz,tiempo);
         }
     }
    }
}
