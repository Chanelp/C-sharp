using System.Collections.Generic;
using System.Linq.Expressions;

/*
 * 
Console.WriteLine("Escribe tu nombre");
string myName = Console.ReadLine();
Console.WriteLine("Tu nombre es: " + myName);


//Escribe un programa que tome la hora y la escriba por pantalla.
Console.WriteLine("Escribe la hora");
string myHour = Console.ReadLine();
Console.WriteLine("La hora es: " + myHour);

//String Example

string nombre = "Chanel Paredes";
int height = 170;
int age = 20;
string info = "The requested info is: \n User name: " + nombre + "\n Altura: " + height + "\n Edad:" + age; 
Console.WriteLine(info);

// Working with numbers  - Square Area

float sideA = 10.543f;
int sideB = 20;
sideB++;

//Rectangule formula is a*b
float area = sideA * sideB;
Console.WriteLine(area);

//LogicalOperatorExmaple

bool value1 = true;
bool value2 = true;
bool value3 = false;

// Operators: &&, ||, ! 
bool result = value1 && value2 && value3;
Console.WriteLine("The result of logical AND is:" + result);

//Si cualquiera de los valores es verdadero, retorna true
bool result2 = value1 && value2 && value3;
Console.WriteLine("The result of logical AND is:" + result2);

// Con ! negación, estamos preguntando si ese valor no es, verdadero.
bool result3 = !value1;
Console.WriteLine(result3);

*/

// Operadores relacionales
/*
int value1 = 3;
int value2 = 18;
int value3 = -18;

bool result0 = (value1 == value2);
Console.WriteLine("The result of value1 == value2 is:" + result0);

bool result1 = (value1 != value2);
Console.WriteLine("The result of value1 != value2 is:" + result1);

bool result2 = (value1 > value2);
Console.WriteLine("The result of value1 > value2 is:" + result2);

bool result3 = (value1 < value2);
Console.WriteLine("The result of value1 < value2 is:" + result3);

bool result4 = (value1 >= value2);
Console.WriteLine("The result of value1 >= value2 is:" + result4);

bool result5 = (value1 <= value2);
Console.WriteLine("The result of value1 <= value2 is:" + result5);


Console.WriteLine("Please enter the side A of the rectangule, you can use decimal");
float sideA = float.Parse(Console.ReadLine());

Console.WriteLine("Please enter the side A of the rectangule, you can use decimal");
float sideB = float.Parse(Console.ReadLine());

float area = sideA * sideB;
Console.WriteLine(area);


//Arreglos en C#

// Declaración
string[] coffeeTypes;
float[] coffeePrices;

//Inicialización
coffeeTypes = new string[] { "Expreso", "Largo", "Filtrado", "Late" };
coffeePrices = new float[] { 1.2f, 1.5f, 5f, 5.5f };

coffeeTypes[1] = "Lungo";

//Formas de recorer arreglos
for (int i = 0; i < coffeeTypes.Length; i++)
{
    Console.WriteLine(coffeeTypes[i] + " Coffe $" + coffeePrices[i]);
}

string[] coffeTypes = { "Cappuccino", "Mocca", "Expresso", "Americano" };

foreach (var item in coffeTypes)
{
    Console.WriteLine(item );
}


//Listas en C#

List<string> tacoShoppingList = new List<string>();
tacoShoppingList.Add("Dos tacos al pastor");
tacoShoppingList.Add("Tres tacos al jamon");
tacoShoppingList.Add("Cinco tacos de tripa");
tacoShoppingList.Add("Seis coca colas");

for(int i = 0; i < tacoShoppingList.Count; i++)
{
    Console.WriteLine(tacoShoppingList[i]);
}

//Remover elemento
tacoShoppingList.Remove("Seis coca colas");

for (int i = 0; i < tacoShoppingList.Count; i++)
{
    Console.WriteLine(tacoShoppingList[i]);
}

tacoShoppingList.RemoveAt(0);

for (int i = 0; i < tacoShoppingList.Count; i++)
{
    Console.WriteLine(tacoShoppingList[i]);
}

tacoShoppingList.ForEach((x) => Console.WriteLine(x));

// Métodos útiles 1-Random

Random rnd = new Random();
Console.WriteLine($"Un valor aleatorio: {rnd.Next(1, 10)}");

//Métodos útiles de String en c#

string ClassTopic = "Métodos de string";
string School = "Platzi";
Console.WriteLine("Estoy aprendiendo de " + ClassTopic + " en " + School + ".");

// Clone
string SchoolClone = School.Clone().ToString();
Console.WriteLine(SchoolClone);

//CompareTo

Console.WriteLine(ClassTopic.CompareTo(School));
Console.WriteLine( School.CompareTo(SchoolClone));

//Contains
Console.WriteLine(SchoolClone.Contains("tzi"));

//EndsWith
Console.WriteLine(School.EndsWith("zi"));

//StartsWith
Console.WriteLine(ClassTopic.StartsWith("apre"));

//Equals
Console.WriteLine(ClassTopic.Equals(School));

//IndexOf
Console.WriteLine(School.IndexOf("t"));

//ToLower() y ToUpper()
Console.WriteLine(School.ToUpper());
Console.WriteLine(ClassTopic.ToLower());

// Insert()
Console.WriteLine(School.Insert(6, "Never stop learning"));

//LastIndexOf()
Console.WriteLine(ClassTopic.LastIndexOf("s"));

//Remove()

Console.WriteLine(School.Remove(6));

//Split()
string[] split = ClassTopic.Split(new char[] { 's' });
Console.WriteLine(split[0]);
Console.WriteLine(split[1]);
Console.WriteLine(split[2]);

//Replace()
Console.WriteLine(ClassTopic.Replace("s", "z"));

//Substring()
Console.WriteLine(ClassTopic.Substring(2, 10));

//ToCharArray()
School.ToCharArray();

//Trim()
string TextWithSpaces = " Habia espacios en blanco al inico y al final ";
Console.WriteLine(TextWithSpaces.Trim());

//RETO: Dada una fecha como un string, y tomando en cuenta el símbolo “/”,
//se obtienen el día, el mes y el año, de la siguiente forma:

Console.WriteLine("Inserta la fecha");
string fecha = Console.ReadLine();

string[] elementSplit = fecha.Split(new char[] { '/' });

//Recorrer split
foreach(var elem in elementSplit)
{
    Console.WriteLine(elem);
}
*
*/

//Ejercicio 2
//Tipos Usando los tipos de variables más adecuados, describe los objetos siguientes:
//Coche: int puertas, int ruedas, string marca, string ITV vigente
//Mesa: float peso, float largo, string material, string color

