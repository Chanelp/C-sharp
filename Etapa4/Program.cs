using System;
using System.Collections.Generic;
using CoreEscuela;
using CoreEscuela.Entidades;
using CoreEscuela.Util;
using static System.Console;

namespace CoreEscuela
{
    class Program
    {
        static void Main(string[] args)
        {
            var engine = new EscuelaEngine();
            engine.Inicializar();
            Printer.WriteTitle("BIENVENIDOS A LA ESCUELA");
            ImprimirCusosEscuela(engine.Escuela);
            Printer.DibujarLinea();
        }

        //MÉTODOS
        private static void ImprimirCusosEscuela(Escuela escuela)
        {
            Printer.WriteTitle("Cursos de la Escuela");

            //No va a verificar cursos, salvo que la escuela sea distinta de null
            if (escuela?.Cursos != null)
            {
                foreach (var curso in escuela.Cursos)
                {
                    WriteLine($"NOMBRE -> {curso.Nombre} \n ID -> {curso.UniqueId}");
                }
            }
        }
    }
}