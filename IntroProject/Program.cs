// Proyecto de introducción. Empleando los conceptos básicos del lenguaje

/* RESTAURANT: 10 TABLES RESERVATION SYSTEM
 - Validar sí el usuario existe, en caso contrario registrarse
 - Saludo de bienvenida a usuarios existentes
 - Repetirse hasta que se hayan registrado 10 usuarios
 */

string[] userNames = new string[10] {"Chanel", "Maxi", "Lup", "Xe", "Zu", "Ne", "Ra", "Al", "Pir", ""};
int currentUser = 9;
bool userType;

while (currentUser < 10)
{
    
    Console.WriteLine("\n \nAre you a registered user? Write true, or write false to register");
    userType = Convert.ToBoolean(Console.ReadLine());

    if(userType == true){
        Console.WriteLine("Hello, you are a registered user. Please enter your exact username.");
        string userToSearch = Console.ReadLine();

        Console.WriteLine("The user you searched is {0}", userToSearch);
        int index = Array.IndexOf(userNames, userToSearch);

        if(index == -1){
            Console.WriteLine("Try again or register");
        }
        else{
            Console.WriteLine("Welcome {0}, it's a pleasure give you food", userNames[index]);
        }
    } 

    else if(userType == false){
        Console.WriteLine("Write and remember your user name");
        userNames[currentUser] = Console.ReadLine();

        Console.WriteLine("Your username has been saved sucessfully\n" + "Your username is {0}", userNames[currentUser]);
        currentUser++;
    }
    
}
Console.WriteLine("The restaurant is full, try again next year");

//Mostrar los 10 usuarios
int auxIndex = 0;

foreach(string element in userNames)
{
    Console.WriteLine("User numer: {0}, user name: {1}", auxIndex, element);
    auxIndex++;
}

Environment.Exit(0);
