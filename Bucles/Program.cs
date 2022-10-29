/*
 * Estrucutras de toma de deciciones: BUCLES.
 * While, do... while, for
 * 
 */

using System.Globalization;

int intento = 0;

while(intento <= 10) {
    Console.Write($"Intento # {intento} ");

    if(intento == 10)
    {
        break;
    }

    intento++;
}

Console.Write($"\nValor de intento después del bucle {intento}\n");

for(int x = 0; x <= 5; x++)
{
    Console.Write(x + " ");
}

//Do... while
int intento2 = 5;

do{
    Console.Write($"Do: {intento2} ");
    intento2+= 5;
} while (intento2 <= 10);

//FOREACH
var names = new List<string> { "Juan", "Martin", "Alan" };

foreach(var name in names)
{
    Console.WriteLine($"El nombre actual es: {name.ToUpper()}");
}

//Sumar los 100 primeros numeros enteros
int numbers = 0;
int suma = 0;

for (numbers = 0; numbers <= 100; numbers++)
{
    suma += numbers;
}

Console.WriteLine(suma);

//Expandir: el usuario indique hasta donde sumar
int resultado = 0;
int j = 0;

Console.WriteLine("Ingresa un numero");
int limite = Convert.ToInt32(Console.ReadLine());

for (j = 0; j <= limite; j++)
{
    resultado += j;
}

Console.WriteLine($"La suma hasta el numero ingresado es: {resultado}");

//Escribir todos los elementos de un array
int[] arreglo = new int[3];
arreglo[0] = 1;
arreglo[1] = 2;
arreglo[2] = 3;

for(int h = 0; h < arreglo.Length; h++)
{
    Console.Write(arreglo[h] + " ");
}

foreach(var ele in arreglo)
{
    Console.Write(ele + " ");
}

j = 0;
while( j < 3)
{
    Console.Write(arreglo[j] + " ");
    j++;
}

/*
 * Ejercicio 1 - While

Escribe una tabla de multiplicar del 1 al 10 para un número entero que recibe por consola. Es decir, un programa que presente para el 1:

1 x 1 = 1
1 x 2 = 2
…
1 x 10 = 10
 */

int number = 0;
Console.WriteLine("Ingresa el # de la tabla");
int tabla = Convert.ToInt32(Console.ReadLine());

while(number <= 10)
{
    Console.WriteLine($"2 x {number} = {number * tabla}");
    number++;
}

/*
 * Ejercicio 2 - Do while

Escribe un programa que realice estos pasos:

Reciba al menos un número por consola

Determine si el número es positivo o negativo

Presente un contador para cada tipo (positivo y negativo).
 */

int numero = 0;
int contador = 0;
do {
    Console.WriteLine("Inserta un numero a comprobar");
    numero = Convert.ToInt32(Console.ReadLine());

    if (numero < 0)
    {
        Console.WriteLine("Es negativo");
    } 
    else if(numero == 0)
    {
        Console.WriteLine("Es cero");
    }
    else
    {
        Console.WriteLine("Es positivo");
    }

    contador++;

} while (contador == 0);

/*Ejercicio 3 - For

Escribe un programa que realice estos pasos:
Reciba 3 datos:
ancho
alto
relleno o no

Dibuje en consola con un mismo caracter, por ejemplo *, un rectángulo de las dimensiones introducidas 
y use el tercer dato para discernir si el rectángulo está relleno (tiene más * dentro) o no.
En caso de recibir el mismo número n dos veces debe dibujar un cuadrado de lado n.

Reto: Extiende el programa anterior para recibir otro número que sea el número de cuadrados 
o rectángulos que se deben dibujar en la pantalla. Ejemplos:

Input: 2,2,2, relleno = true
Output:
** **
** **

Input: 3, 4, 1, relleno = false
Output:
***
* *
* *
***
 */
/*
Console.WriteLine("Ingrese el alto");
int ancho = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ingrese el ancho");
int alto = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Relleno o no");
bool relleno = Convert.ToBoolean(Console.ReadLine());
Console.WriteLine("Cuantas figuras?");
int cantidad = Convert.ToInt32(Console.ReadLine());

for(int h = 0; h < alto; h++)
{
    for(int w = 0; w < ancho; w++)
    {
        Console.Write("*");
    }
    Console.WriteLine("*");
}*/
// Exercise 3 For

Console.WriteLine("\n-----Drawing a rectangle-----\n");
Console.Write("Insert the height (number): ");
int height = Convert.ToInt32(Console.ReadLine());
Console.Write("Insert the width (number): ");
int width = Convert.ToInt32(Console.ReadLine());

Console.Write("With filling? (Y/N): ");
string withFilling = Console.ReadLine();
Console.Write("How much filling? (number): ");
int qFilling = Convert.ToInt32(Console.ReadLine());

string filling = new string('*', qFilling);

for (int i = 0; i < height; i++)
{
    for (int w = 0; w < width; w++)
    {
        if ((withFilling == "N") && (i > 0 && i < height - 1) && (j > 0 && j < width - 1))
        {
            Console.Write(" ");
        }
        else
        {
            Console.Write(filling);
        }
    }
    Console.Write("\n");
};