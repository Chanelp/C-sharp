// Librería MATH para operaciones matemáticas
int n1 = 100;
Console.WriteLine(Math.Sqrt(n1));

float n2 = 9.99f;
Console.WriteLine("Round: " + Math.Round(n2));

float n3 = 9.01f;
Console.WriteLine("Ceiling: " + Math.Ceiling(n3));
Console.WriteLine("Floor: " + Math.Floor(n2));

//Array de enteros, imprimir todos, y determinar el max y min
int[] arreglo = new int[5] {2, 4, 6, 8, 12};

foreach(var num in arreglo)
{
    Console.WriteLine($"Numero actual {num}");
}

Console.WriteLine($"Numero maximo: {arreglo.Max()}");
Console.WriteLine($"Numero minimo: {arreglo.Min()}");