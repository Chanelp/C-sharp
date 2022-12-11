using System;
using System.Collections.Generic;

namespace CoreEscuela.Entidades
{
    public class Alumno
    {
        public string uniqueID {get; private set;}
        public string Nombre {get; set;}
        public List<Evaluación> Evaluaciones { get; set; } = new List<Evaluación>();
        
        public Alumno() => uniqueID = Guid.NewGuid().ToString();
    }
}