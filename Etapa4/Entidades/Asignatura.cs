using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreEscuela.Entidades
{
    public class Asignatura
    {
        public string uniqueID { get; private set; }
        public string Nombre { get; set; }
        public List<Alumno> Alumnos {get; set;}
        public List<Evaluaciones> Evaluacion {get; set;}

        public Asignatura() => uniqueID = Guid.NewGuid().ToString();
    }
}