
// Estructuras de datos:
/*
 * struct => Agrupar datos con una utilidad, pueden ser diferentes tipos
 * Estructura de datos REf: cuando se necesite un objeto de tipo referencia.
 * Readonly: protección ante escritura, que el objeto sea solo de escritura. Siguiendo el ejemplo de las coordenadas, lo importante es saber donde colocarlo: antes de struct
   Al crear el objeto ya no se pueden modificar los datos. Si solo defines el get, también se interpreta como solo lectura.
 * Con with podemos clonar objetos parecidos y modificar entonces lo que necesitemos.
 *
*/

//En acción

Coords misCoordenadas = new Coords(2, 7, 11);
Console.WriteLine(misCoordenadas.X);
Console.WriteLine(misCoordenadas.Y);
Coords misCoordenadas2 = misCoordenadas with { X = 28 };
Console.WriteLine(misCoordenadas2);

Cliente cliente1 = new Cliente("Austin", "3393749", "Juacobo 11", "austin1@outlook.com", true);
Console.WriteLine(cliente1);
Cliente cliente2 = cliente1 with { Nombre = "Paula", NuevoC = false };
Console.WriteLine(cliente2);

//EJEMPLO CON COORDENADAS
public struct Coords {
    public Coords(double x, double y, double z) {
        X = x;
        Y = y;
        Z = z;
    }
public double X { get; set; }
public double Y { get; set; }
    public double Z { get; }

public override string ToString() => $"({X}, {Y}, {Z})";
}


/* Ejercicio
 * Crea una estructura de datos para un cliente con estos campos:
 * Nombre completo, Teléfono, Dirección, Email, Si es nuevo cliente
 * Bonus: escribe un método para presentar estos datos desde la estructura al hacer Console.WriteLine(...)
 */

public struct Cliente {
    public Cliente(string nombre, string telefono, string direccion, string email, bool nuevoC) {

        Nombre = nombre;
        Telefono = telefono;
        Direccion = direccion;
        Email = email;
        NuevoC = nuevoC;
    }

    public string Nombre { get; set; }
    public string Telefono { get; set; }
    public string Direccion { get; set; }
    public string Email { get; set; }
    public bool NuevoC { get; set; }

    public override string ToString() => $"({Nombre}, {Telefono}, {Direccion}, {Email}, {NuevoC})";

}