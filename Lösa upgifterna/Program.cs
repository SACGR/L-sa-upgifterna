// See https://aka.ms/new-console-template for more information
using System;

    Console.WriteLine("Vilken dell vill du ha");
Console.WriteLine("1 2 eller 3");
Console.WriteLine("1.Är fregesport\n2.Är en Romb ritare\n3.Den kan kontrolera om ett tall är ett primtal");
string veljare = Console.ReadLine();



if (veljare == "1")
{
    Console.WriteLine("Här är alternativ 1 \nDu ska svara på tre fråger");
    string Fråga1 = ("Fråga 1");
    string retSvar1 = "Svar1";
    string Fråga2 = ("fråga 2");
    string retSvar2 = "Svar2";
    string Fråga3 = ("Fråga 3");
    string retSvar3 = "Svar3";

    Console.WriteLine(Fråga1);
    string Svar1 = Console.ReadLine();
    Console.WriteLine(Fråga2);
    string Svar2 = Console.ReadLine();
    Console.WriteLine(Fråga3);
    string Svar3 = Console.ReadLine();

    if (Svar1 == retSvar1 & Svar2 == retSvar2 & Svar3 == retSvar3)
    {
        Console.WriteLine("ret");
        Console.ReadLine();
    }
    else
    {
        Console.WriteLine("fel");
    }
}
if (veljare == "2")
{

}
if (veljare == "3")
{
    Console.WriteLine("Villket lal vill du pröva om det är ett primtal");

   

}