using System;
using CoreEscuela.Entidades;
using static System.Console;

namespace Etapa1
{
    class Program
    {
        static void Main(string[] args)
        {
            var escuela = new Escuela("Platzi academy", 2017, TiposEscuela.Primaria,
                pais: "Colombia", ciudad: "Pasto");

            escuela.Cursos = new Curso[]{
                new Curso(){ Nombre = "101" },
                new Curso(){ Nombre = "201" },
                new Curso(){ Nombre = "301"}
            };
            escuela = null;
            ImprimirCursosEscuela(escuela);


        }

        private static void ImprimirCursosEscuela(Escuela escuela)
        {
            WriteLine("===================");
            WriteLine("Cursos de la Escuela");
            WriteLine("====================");
            // el interrogante evalua escuela y cursos
            // si escuela esta nulo no evaluara cursos
            if (escuela?.Cursos != null)
            {
                foreach (var curso in escuela.Cursos)
                {
                    WriteLine($"Nombre: {curso.Nombre}, Id: {curso.UniqueId}");
                }
            }


        }
    }
}
