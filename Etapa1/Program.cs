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

Console.WriteLine(escuela);
System.Console.WriteLine(new String('=', 50));
Console.WriteLine(curso1.Nombre + " , " + curso1.UniqueId);
Console.WriteLine(curso2.Nombre + " , " + curso2.UniqueId);
Console.WriteLine($"{curso3.Nombre} , {curso3.UniqueId}");