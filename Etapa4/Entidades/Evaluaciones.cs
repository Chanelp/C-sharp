using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreEscuela.Entidades
{
    public class Evaluaciones
    {
        public string uniqueID {get; private set;}
        public string Nombre {get; set;}
        public Alumno Alumno { get; set; }
        public Asignatura Asignatura { get; set; }
        public float Nota { get; set; }
        
        public Evaluaciones() => uniqueID = Guid.NewGuid().ToString();
    }
}