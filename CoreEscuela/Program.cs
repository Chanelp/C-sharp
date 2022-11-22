//EJEMPLO SENCILLA PARA ENTENDER LOS PILARES BASE DE POO: CLASES, OBJETOS Y MODIFICADORES DE ACCESO PRINCIPALES

var miEscuela = new CoreEscuela();
miEscuela.nombre = "Platzi Academy";
miEscuela.direccion = "Bogotá";
miEscuela.añoFundación = 2017;
Console.WriteLine("TIMBRAR");
miEscuela.Timbrar();

class CoreEscuela
{
    public string nombre;
    public string direccion;
    public int añoFundación;
    public string director = "Freddy Vega";

    public void Timbrar(){
        Console.Beep(2000, 3000);
    }
}
