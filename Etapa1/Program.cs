using CoreEscuela.Entidades;

var miEscuela = new Escuela("ITLA", 2000, TipoEscuela.Secundaria);
miEscuela.Pais = "Dominican Republic";
miEscuela.Ciudad = "Santo Domingo";
//miEscuela.TipoEscuela = TipoEscuela.Primaria;

Console.WriteLine(miEscuela.Nombre);
System.Console.WriteLine(miEscuela);