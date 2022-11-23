using CoreEscuela.Entidades;

var escuela = new Escuela("ITLA", 2000, TipoEscuela.Secundaria);
escuela.Pais = "Dominican Republic";
escuela.Ciudad = "Santo Domingo";
//miEscuela.TipoEscuela = TipoEscuela.Primaria;


//Instancias de escuela
var curso1 = new Curso(){
    Nombre = "101"
};
var curso2 = new Curso(){
    Nombre = "201"
};
var curso3 = new Curso(){
    Nombre = "301"
};

//crear arreglo de objetos
var arregloCursos = new Curso[3]; 
arregloCursos[0] = new Curso() {
    Nombre = "101"
};
arregloCursos[1] = curso2;
arregloCursos[2] = new Curso {Nombre = "301"};


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

//Recorrer arreglo d eobjetos con foreach
System.Console.WriteLine(new String('=', 50));
foreach (var curso in arregloCursos)
{
    Console.WriteLine($"NOMBRE -> {curso.Nombre} \n ID -> {curso.UniqueId}");
}

