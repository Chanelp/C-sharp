using static System.Console;

namespace CoreEscuela.Util
{
    public static class Printer 
    {
        public static void DibujarLinea(int tam = 10){
            WriteLine(new String('=', tam));
        }

        public static void WriteTitle(string titulo){
            DibujarLinea(titulo.Length + 4);
            WriteLine($"| {titulo} |");
            DibujarLinea(titulo.Length + 4);
        }

        public static void Pitar(int hz = 659, int tiempo = 125, int cantidad = 1){
            while(cantidad-- > 0){
                Console.Beep(hz, tiempo);
            }
        }
    }
}