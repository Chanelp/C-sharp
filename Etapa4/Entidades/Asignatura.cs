using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreEscuela.Entidades
{
    public class Asignatura: ClaseEscuelaBase
    {
        public List<Alumno> Alumnos {get; set;}
        public double Evaluacion {get; set;}
    }
}