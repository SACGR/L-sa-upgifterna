// See https://aka.ms/new-console-template for more information
using System;

static void PrintaRetning(string Fråga, string retSvar, string Svar)
{
    Console.Write(Fråga + "\nRet svar- " + retSvar + "\nDit svar- " + Svar + "\n");
    if (retSvar == Svar)
    { Console.Write("rett!"); }
    Console.WriteLine("\n\n");
}

while (true)
{
    Console.WriteLine("Vilken dell vill du ha");
    Console.WriteLine("1 2 eller 3");
    Console.WriteLine("1.Är fregesport\n2.Är en Romb ritare\n3.Den kan kontrolera om ett tall är ett primtal");
    string veljare = Console.ReadLine();



    if (veljare == "1")
    {
        Console.WriteLine("Här är alternativ 1 \nDu ska svara på tre fråger");
        string Fråga1 = ("Fråga 1\nVad hetter jag");
        string retSvar1 = "Caspian";
        string Fråga2 = ("fråga 2\nVad är 1+1");
        string retSvar2 = "2";
        string Fråga3 = ("Fråga 3\n Vad är roten ur 2\nSvara exakt");
        string retSvar3 = "2^1/2";

        Console.WriteLine(Fråga1);
        string Svar1 = Console.ReadLine();
        Console.WriteLine(Fråga2);
        string Svar2 = Console.ReadLine();
        Console.WriteLine(Fråga3);
        string Svar3 = Console.ReadLine();


        Console.Write("\n\n\n\nRetning\n");
        PrintaRetning(Fråga1, retSvar1, Svar1);
        PrintaRetning(Fråga2, retSvar2, Svar2);
        PrintaRetning(Fråga3, retSvar3, Svar3);

    }
    if (veljare == "2")
    {
        Console.WriteLine("Hur stor?");
        string sStorleken = Console.ReadLine();
        Console.WriteLine("Vilken teken ska romben vara jod av");
        string Teken = Console.ReadLine();
        int Soileken = int.Parse(sStorleken);

        for (int i = 0; i < Soileken; i++)
        {
            for (int k = 0; k < i || k == i; k++)
            {
                Console.Write(" ");
            }
            for (int l = 0; l < Soileken; l++)
            {
                Console.Write(Teken);
            }
            Console.Write("\n");
        }

    }
    if (veljare == "3")
    {
        bool ErEttPrim = true;
        Console.WriteLine("Villket tal vill du pröva om det är ett primtal");
        int DerasNumer = Convert.ToInt32(Console.ReadLine());
        if (DerasNumer == 0 || DerasNumer == 1)
            ErEttPrim = false;
        else
        {
            for (int i = 2; i <= DerasNumer / 2; i++)
            {
                if (DerasNumer % i == 0)
                {
                    ErEttPrim = false;
                    break;
                }
                
            }
            
        }
        if (ErEttPrim)
            Console.WriteLine("\n\n\n"+DerasNumer + " är ett primtal"+ "\n\n\n");
        else
            Console.WriteLine("\n\n\n"+DerasNumer + " är inte ett primtal"+ "\n\n\n");

    }
}   