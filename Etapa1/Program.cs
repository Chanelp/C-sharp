using System;
using CoreEscuela.Entidades;
using static System.Console;
using System.Collections.Generic;

var escuela = new Escuela("ITLA", 2000, TipoEscuela.Secundaria);
escuela.Pais = "Dominican Republic";
escuela.Ciudad = "Santo Domingo";

//Implementando la colección List para almacenar los objetos
escuela.Cursos = new List<Curso>(){
    new Curso(){ Nombre = "101", Jornada = TipoJornada.Mañana },
    new Curso(){ Nombre = "201", Jornada = TipoJornada.Mañana },
    new Curso(){ Nombre = "301", Jornada = TipoJornada.Mañana }
};

//Método Add
escuela.Cursos.Add(new Curso{ Nombre = "102", Jornada = TipoJornada.Tarde} );
escuela.Cursos.Add(new Curso{ Nombre = "202", Jornada = TipoJornada.Tarde} );

//Casi todas las colecciones son un Inumerable
var otraColeccion =  new List<Curso> () {
    new Curso(){ Nombre = "401", Jornada = TipoJornada.Mañana },
    new Curso(){ Nombre = "501", Jornada = TipoJornada.Mañana },
    new Curso(){ Nombre = "501", Jornada = TipoJornada.Tarde }
};

//Métodos para agregar y eliminar
escuela.Cursos.AddRange(otraColeccion);
ImprimirCusosEscuela(escuela);

// Predicate<Curso> miAlgoritmo = Predicado;
// escuela.Cursos.RemoveAll(Predicado);

//DELEGADO
escuela.Cursos.RemoveAll(delegate (Curso cur) {return cur.Nombre == "301";});

//EXPRESIÓN LAMDBA
escuela.Cursos.RemoveAll(cur => cur.Nombre.Equals("501") && cur.Jornada == TipoJornada.Mañana);

WriteLine(new String('=', 50));
ImprimirCusosEscuela(escuela);


//MËTODOS
// bool Predicado(Curso curobj)
// {
//     return curobj.Nombre == "301";
// }

void ImprimirCusosEscuela(Escuela escuela)
{
    WriteLine(new String('=', 40));
    WriteLine("Cursos de la Escuela");
    WriteLine(new String('=', 40));

    //No voy a verificar cursos, salvo que la escuela sea distinta de null
    if (escuela?.Cursos != null)
    {
        foreach (var curso in escuela.Cursos)
        {
            WriteLine($"NOMBRE -> {curso.Nombre} \n ID -> {curso.UniqueId}");
        }
    }
}