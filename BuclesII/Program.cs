// Bucle: if, switch, break, case

using System.Runtime.CompilerServices;

Console.WriteLine("What day is today?");
string day = Console.ReadLine().ToUpper();

switch (day)
{
    case "LUNES":
        Console.WriteLine("It is monday");
        break;
    case "MARTES":
        Console.WriteLine("It is tuesday");
        break;
    default:
        Console.WriteLine("I do not know what day it is");
        break;
}

//BREAK
if(day == "LUNES")
{
    for(int y = 0; y <3; y++)
    {
        Console.WriteLine("Lunes :) ");
        break;
    }
}

//CONTINUE
for(int z = 0; z < 10; z++)
{
    Console.WriteLine(z);
    if(z == 5)
    {
        Console.Write("z es igual a 5");
        continue;
    }
}