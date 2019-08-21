using System;
using System.Collections.Generic;
using System.Linq;
using CoreEscuela.Entidades;

namespace CoreEscuela
{
    public sealed class EscuelaEngine
    {
        public Escuela Escuela { get; set; }

        public EscuelaEngine()
        {

        }

        public void Inicializar()
        {
            Escuela = new Escuela("Platzi academy", 2017, TiposEscuela.Primaria,
            pais: "Colombia", ciudad: "Pasto");

            CargarCursos();
            CargarAsignaturas();
            CargarEvaluaciones();
        }

        private float GenerarNotasAlAzar()
        {
            Random rnd = new Random();

            int ParteEntera = rnd.Next(0, 4);
            int ParteDecimal = rnd.Next(0, 9);

            float NumeroMaximo = 5;
            float Nota = float.Parse(ParteEntera + "." + ParteDecimal);

            if (Nota >= NumeroMaximo)
            {
                return 5;
            }

            return Nota;
        }
        private void CargarEvaluaciones()
        {
            foreach (var curso in Escuela.Cursos)
            {
                foreach (var asignatura in curso.Asignaturas)
                {
                    foreach (var alumno in curso.Alumnos)
                    {
                        var rnd = new Random(System.Environment.TickCount);
                        for (int i = 0; i < 5; i++)
                        {
                            var ev = new Evaluación
                            {
                            Nombre = $"{asignatura.Nombre} Ev {i + 1}",
                            Asignatura = asignatura,
                            Alumno = alumno,
                            Nota = (float)(5 * rnd.NextDouble()),
                            
                            };
                            alumno.Evaluaciones.Add(ev);
}
                    }
                }
            }
        }

        private void CargarAsignaturas()
        {
            foreach (var curso in Escuela.Cursos)
            {
                List<Asignatura> listaAsignaturas = new List<Asignatura>(){
                    new Asignatura{Nombre = "Matematicas"},
                    new Asignatura{Nombre ="Castellano"},
                    new Asignatura{Nombre = "Filosofia"},
                    new Asignatura{Nombre = "Quimica"}
                };
                curso.Asignaturas = listaAsignaturas;
            }
        }

        private List<Alumno> GenerarAlumnosAlAzar(int cantidad)
        {
            string[] nombre1 = { "Alba", "Felipa", "Eusebio", "Farid", "Donald", "Alvaro", "Nicolas" };
            string[] apellido1 = { "Ruiz", "Sarmiento", "Rojas", "Ortega", "Trump", "Toledo", "Herrera" };
            string[] nombre2 = { "Francisco", "Annabel", "Rick", "Murty", "Silvana", "Teodoro" };

            var listaAlumnos = from n1 in nombre1
                               from n2 in nombre2
                               from a1 in apellido1
                               select new Alumno { Nombre = $"{n1} {n2} {a1}" };

            return listaAlumnos.OrderBy((al) => al.UniqueId).Take(cantidad).ToList();
        }

        private void CargarCursos()
        {
            Escuela.Cursos = new List<Curso>(){
                new Curso(){ Nombre = "101" },
                new Curso(){ Nombre = "201" },
                new Curso(){ Nombre = "301"},
                new Curso(){ Nombre = "401" },
                new Curso(){ Nombre = "501" },
            };

            Random rnd = new Random();
            foreach (var c in Escuela.Cursos)
            {
                int cantidadRandom = rnd.Next(5, 20);
                c.Alumnos = GenerarAlumnosAlAzar(cantidadRandom);
            }
        }

    }
}