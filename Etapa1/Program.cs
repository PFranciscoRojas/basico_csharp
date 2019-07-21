using System;
using System.Collections.Generic;
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

            // así funcionan las colecciones, en las nuevas versiones 
            // se pueden agregar valores igual que un arreglo
            escuela.Cursos = new List<Curso>(){
                new Curso(){ Nombre = "101" },
                new Curso(){ Nombre = "201" },
                new Curso(){ Nombre = "301"}
            };

            escuela.Cursos.Add(new Curso(){Nombre = "102", Jornada = TiposJornada.Tarde});
            escuela.Cursos.Add(new Curso(){Nombre = "202", Jornada = TiposJornada.Tarde});

            var nuevosCursos = new List<Curso>(){
                new Curso(){ Nombre = "401" },
                new Curso(){ Nombre = "501" },
                new Curso(){ Nombre = "601"}
            }; 
           // Curso tmp = new Curso(){Nombre = "vacacional", Jornada = TiposJornada.Noche};

           // nuevosCursos.Clear(); // se encarga de eliminar todos los items de la lista
            
            escuela.Cursos.AddRange(nuevosCursos);
            //escuela.Cursos.Add(tmp);
            ImprimirCursosEscuela(escuela);
            //WriteLine("Curso.Hash"+tmp.GetHashCode());
           // escuela.Cursos.Remove(tmp);

           Predicate<Curso> MiAlgoritmo = predicado;
            escuela.Cursos.RemoveAll(MiAlgoritmo);
            ImprimirCursosEscuela(escuela);

        }

        private static bool predicado(Curso curobj)
        {
            return curobj.Nombre == "301";
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
                    WriteLine($"Nombre: {curso.Nombre}, Id: {curso.UniqueId}. jornada: {curso.Jornada}");
                }
            }


        }
    }
}
