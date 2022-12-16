using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreEscuela.Entidades
{
    public abstract class ClaseEscuelaBase
    {
        public string uniqueID { get; private set; }
        public string Nombre { get; set; }
        public ClaseEscuelaBase()
        {
            uniqueID = Guid.NewGuid().ToString();
        }
    }
}