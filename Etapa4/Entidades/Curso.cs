using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreEscuela.Entidades
{
    public class Curso
    {
        public string UniqueId { get; private set; }
        public string Nombre { get; set; }
        public TipoJornada Jornada { get; set; }

        //Constructor que asigna ID aleatorio
        public Curso() => UniqueId = Guid.NewGuid().ToString();

        //Otra forma de generar ID con random
        /*public Curso(){
            Random id = new Random();
            UniqueId = id.Next(1, 100).ToString();//Guid.NewGuid().ToString();
        }*/

    }
}