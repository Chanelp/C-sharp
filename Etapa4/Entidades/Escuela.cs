using System;
using System.Text;
using System.Collections.Generic;

namespace CoreEscuela.Entidades
{
    public sealed class Escuela: ClaseEscuelaBase
    {
        public int AñoCreacion { get; set; }
        public string Pais { get; set; }
        public string Ciudad { get; set; }
        public TipoEscuela TipoEscuela;

        public List<Curso> Cursos {get; set;}

        public Escuela(string nombre, int año) => (Nombre, AñoCreacion) = (nombre, año);
        
        public Escuela(string nombre, int año, TipoEscuela tipo, string pais = "", string ciudad ="")
        {
            ( Nombre, AñoCreacion, TipoEscuela ) = (nombre, año, tipo);
            Pais = pais;
            Ciudad = ciudad;
        }

        //Sobreescribir método ToString()
        public override string ToString()
        {
            return $"Nombre: \"{Nombre}\", Tipo: {TipoEscuela} \n Pais: {Pais}, Año Creación: {AñoCreacion}, {System.Environment.NewLine} Ciudad: {Ciudad}";
        }
    }
}