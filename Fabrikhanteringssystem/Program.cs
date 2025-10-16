using System;
using System.Collections.Generic;

class Program
{
    static List<string> inventory = new List<string>();

    static void Main(string[] args)
    {
        Console.WriteLine("Välkommen till Fabrikshanteringssystemet!");

        while (true)
        {
            Console.WriteLine("\nVälj en åtgärd:");
            Console.WriteLine("1. Lägg till produkt");
            Console.WriteLine("2. Visa inventarie");
            Console.WriteLine("3. Ta bort produkt");
            Console.WriteLine("4. Avsluta");

            string val = Console.ReadLine();
            switch (val)
            {
                case "1":
                    LäggTillProdukt();
                    break;
                case "2":
                    VisaInventarie();
                    break;
                case "3":
                    TaBortProdukt();
                    break;
                case "4":
                    return;
                default:
                    Console.WriteLine("Ogiltigt val. Försök igen.");
                    break;
            }
        }
    }

    static void LäggTillProdukt()
    {
        Console.Write("Ange produktens namn: ");
        string produkt = Console.ReadLine();

        if (!string.IsNullOrWhiteSpace(produkt))
        {
            inventory.Add(produkt);
            Console.WriteLine($"Produkten \"{produkt}\" har lagts till.");
        }
        else
        {
            Console.WriteLine("Produktnamnet kan inte vara tomt.");
        }
    }

    static void VisaInventarie()
    {
        if (inventory.Count == 0)
        {
            Console.WriteLine("Inventarielistan är tom.");
            return;
        }

        Console.WriteLine("\nInventarie:");
        for (int i = 0; i < inventory.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {inventory[i]}");
        }
    }

    static void TaBortProdukt()
    {
        Console.Write("Ange produktens namn: ");
        string produktNamn = Console.ReadLine();

        if (!string.IsNullOrWhiteSpace(produktNamn))
        {
            if (inventory.Contains(produktNamn))
            {
                inventory.Remove(produktNamn);
                Console.WriteLine($"Produkten \"{produktNamn}\" har tagits bort från inventariet.");
            }
            else
            {
                Console.WriteLine($"Produkten \"{produktNamn}\" finns inte i inventariet.");
            }
        }
        else
        {
            Console.WriteLine("Produktnamnet får inte vara tomt.");
        }
           
        if (inventory.Count == 0)
        {
            Console.WriteLine("Det finns inga produkter att ta bort.");
            return;
        }
    }
}