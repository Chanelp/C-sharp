// IF ELSE
Console.WriteLine("Please enter a number between 0 and 10");
int num = int.Parse(Console.ReadLine());

if((num >= 0) && (num <= 10))
{
    Console.WriteLine("Good Job");
} else
{
    Console.WriteLine("Hey! The number should be 0 or more and 10 or less.");
}



//Switch statement
Console.WriteLine("Do you enjoy C#? (YES/NO/MAYBE)");
string input = Console.ReadLine();

switch (input.ToLower())
{
    case "yes":
    case "maybe":
        Console.WriteLine("It is great!");
        break;
    case "no":
        Console.WriteLine("Oh, do not tell me that");
        break;
    default:
        Console.WriteLine("Okey, just keep trying.");
        break;
}