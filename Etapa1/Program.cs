using System;
using System.Collections.Generic;
using CoreEscuela.Entidades;
using static System.Console;
using CoreEscuela.Util;

namespace CoreEscuela
{
    class Program
    {
        static void Main(string[] args)
        {
            var engine = new EscuelaEngine();
            engine.Inicializar();
            Printer.WriteTittle("Bienvenidos a la Escuela");
            Printer.Beep(10000,cantidad:5);
            ImprimirCursosEscuela(engine.Escuela);
           // var obj = new objetoEscuelaBase();
           Printer.DrawLine(20);
           Printer.DrawLine(20);
           Printer.DrawLine(20);
           Printer.DrawLine(20);

           Printer.WriteTittle("Pruebas de poliformismo");

            var alumnoTest = new Alumno{Nombre="Francisco ROjas"};
            

        }


        private static void ImprimirCursosEscuela(Escuela escuela)
        {
                Printer.WriteTittle("Cursos de la Escuela");
            // el interrogante evalua escuela y cursos
            // si escuela esta nulo no evaluara cursos
            if (escuela?.Cursos != null)
            {
                foreach (var curso in escuela.Cursos)
                {
                    WriteLine($"Nombre: {curso.Nombre}, Id: {curso.UniqueId}. jornada: {curso.Jornada}");
                }
            }


        }
    }
}
