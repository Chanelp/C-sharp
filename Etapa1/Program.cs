using CoreEscuela.Entidades;
using static System.Console;

var escuela = new Escuela("ITLA", 2000, TipoEscuela.Secundaria);
escuela.Pais = "Dominican Republic";
escuela.Ciudad = "Santo Domingo";
//miEscuela.TipoEscuela = TipoEscuela.Primaria;

//Otra forma mejor
escuela.Cursos = new Curso[]{
    new Curso(){ Nombre = "101" },
    new Curso(){ Nombre = "201" },
    new Curso(){ Nombre = "301" }
};

ImprimirCusosEscuela(escuela);

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

    /*//Cortocircuito de evaluación de expresiones
    if (escuela != null && escuela.Cursos != null)
    {
        foreach (var curso in escuela.Cursos)
        {
            WriteLine($"NOMBRE -> {curso.Nombre} \n ID -> {curso.UniqueId}");
        }
    }*/
}