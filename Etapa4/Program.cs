using System;
using CoreEscuela;
using CoreEscuela.Entidades;
using static System.Console;
using CoreEscuela.Util;
using System.Collections.Generic;

var engine = new EscuelaEngine();
engine.Inicializar();
Printer.WriteTitle("BIENVENIDOS A LA ESCUELA");
Printer.Pitar();
ImprimirCusosEscuela(engine.Escuela);

Printer.DibujarLinea();

//MÉTODOS
void ImprimirCusosEscuela(Escuela escuela)
{
    Printer.WriteTitle("Cursos de la Escuela");

    //No voy a verificar cursos, salvo que la escuela sea distinta de null
    if (escuela?.Cursos != null)
    {
        foreach (var curso in escuela.Cursos)
        {
            WriteLine($"NOMBRE -> {curso.Nombre} \n ID -> {curso.UniqueId}");
        }
    }
}