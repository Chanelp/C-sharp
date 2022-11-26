using CoreEscuela.Entidades;

var escuela = new Escuela("ITLA", 2000, TipoEscuela.Secundaria);
escuela.Pais = "Dominican Republic";
escuela.Ciudad = "Santo Domingo";
//miEscuela.TipoEscuela = TipoEscuela.Primaria;

//crear arreglo de objetos
var arregloCursos = new Curso[3]{
    new Curso(){ Nombre = "101" },
    new Curso(){ Nombre = "201" },
    new Curso(){ Nombre = "301" }
};

//crear arreglo de objetos optimizado
Curso[] arregloCursosOptimizado = {
    new Curso(){ Nombre = "101" },
    new Curso(){ Nombre = "201" },
    new Curso(){ Nombre = "301" }
};

//Otra forma mejor
escuela.Cursos = new Curso[]{
    new Curso(){ Nombre = "101" },
    new Curso(){ Nombre = "201" },
    new Curso(){ Nombre = "301" }
};

escuela.Cursos = arregloCursos;

Console.WriteLine(escuela);
System.Console.WriteLine(new String('=', 50));
ImprimirCusos(arregloCursos);

//Recorrer arreglo de objetos con while
void ImprimirCusos(Curso[] arregloCursos)
{
    int contador = 0;
    while (contador < arregloCursos.Length)
    {
        Console.WriteLine($"Nombre: {arregloCursos[contador].Nombre}, ID: {arregloCursos[contador].UniqueId}");
        contador++;
    }
}

//Recorrer arreglo de objetos con foreach
System.Console.WriteLine(new String('=', 50));
foreach (var curso in arregloCursos)
{
    Console.WriteLine($"NOMBRE -> {curso.Nombre} \n ID -> {curso.UniqueId}");
}
