using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;
using System.Globalization;
using System;
using Humanizer;


Console.WriteLine("Please enter a name");
string name = Console.ReadLine();

Console.WriteLine("Please enter your rol");
string rol = Console.ReadLine();

Console.WriteLine("Please enter your age");
var age = int.Parse(Console.ReadLine());

Console.WriteLine($"My name is {name}, my rol is {rol}, and I'm {age.ToWords(new System.Globalization.CultureInfo("en"))} years old");

var text1 = DateHumanizeExtensions.Humanize(DateTime.Now,DateTime.UtcNow, new CultureInfo("es-MX")); 
var text2 = DateTime.Now.AddMinutes(154).Humanize(culture: new CultureInfo("es-MX"));
var text3 = DateTime.Now.AddMinutes(-468).Humanize(culture: new CultureInfo("es-MX"));

System.Console.WriteLine(DateTime.Now);
System.Console.WriteLine(text1);
System.Console.WriteLine(text2);
System.Console.WriteLine(text3);