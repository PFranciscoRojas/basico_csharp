using System;
using System.Collections.Generic;
using CoreEscuela.Entidades;

namespace CoreEscuela
{
    public class EscuelaEngine
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
            CargarAlumnos();
            CargarAsignaturas();
            CargarEvaluaciones();
        }

        private void CargarEvaluaciones()
        {
            throw new NotImplementedException();
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
                curso.Asignaturas.AddRange(listaAsignaturas);
            }
        }

        private void CargarAlumnos()
        {
            string[] nombre1 = {"Alba","Felipa","Eusebio","Farid","Donald","Alvaro","Nicolas"};
            string[] apellido1 = {"Ruiz","Sarmiento","Rojas","Ortega","Trump","Toledo","Herrera"};
            string[] nombre2 = {"Francisco","Annabel","Rick","Murty","Silvana","Teodoro"};
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
        }
    }
}