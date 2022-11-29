using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreEscuela.Entidades
{
    public class Alumno
    {
        public string uniqueID {get; private set;}
        public string Nombre {get; set;}
        public List<Asignatura> Asignatura {get; set;}
        
        public Alumno() => uniqueID = Guid.NewGuid().ToString();
    }
}