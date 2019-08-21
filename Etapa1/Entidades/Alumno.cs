using System;
using System.Collections.Generic;

namespace CoreEscuela.Entidades
{
    public class Alumno:objetoEscuelaBase
    {
        public List<Evaluación> Evaluaciones { get; set; } = new List<Evaluación>();
    }
}