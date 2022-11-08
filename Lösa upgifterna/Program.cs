// See https://aka.ms/new-console-template for more information
using System;

static void PrintaRetning(string Fråga, string retSvar, string Svar, int i)
{
    Console.WriteLine("\nFråga " + (i + 1));
    Console.Write(Fråga + "\nRet svar- " + retSvar + "\nDit svar- " + Svar + "\n");
    if (retSvar == Svar)
    { Console.Write("rett!"); }
    else
        Console.Write("fell :(");
    Console.WriteLine("\n");
}

while (true)
{
    Console.WriteLine("Vilken dell vill du ha");
    Console.WriteLine("1.Är fregesport\n2.Är en Romb ritare\n3.Den kan kontrolera om ett tall är ett primtal");
    string veljare = Console.ReadLine();

    //första tallet är villken låda
    //andra talet är villken fråga
    string[,,] frågesport =
    {
//fråger
        {{"Vad hetter jag"},{"Vad är 1+1"},{"vad är roten ur 2\nsvara exakt"} },
//ret_svar 
        {{"Caspian"},{"2"},{"2^0,5"} },
//Deras svar
        {{" "},{" "},{" "}},    
    };
    int AntalFråger = 3;


    if (veljare == "1")
    {
        for (int i = 0; i < AntalFråger; i++)
        {
            Console.WriteLine("Fråga " + (i+1)+"\n"+ frågesport[0, i, 0]);
            frågesport[2, i, 0] = Console.ReadLine();
        }
        for (int i = 0; i < AntalFråger; i++)
            PrintaRetning(frågesport[0, i, 0], frågesport[1, i, 0], frågesport[2, i, 0],i);
        

    }
    if (veljare == "2")
    {
        string sStorleken = "t";
        while(!int.TryParse(sStorleken, out int value))
        {
            Console.WriteLine("Hur stor?\nEtt värde mellan 1 och 40");
            sStorleken = Console.ReadLine();
        }
        

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
            Console.WriteLine("\n\n\n" + DerasNumer + " är ett primtal" + "\n\n\n");
        else
            Console.WriteLine("\n\n\n" + DerasNumer + " är inte ett primtal" + "\n\n\n");

    }
    else
        Console.WriteLine("Ande ett tall melan 1 och 3");
}   