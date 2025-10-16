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
        // TODO: Implementera metod för att lägga till produkt
        string product;
        product = Console.ReadLine();
        inventory.Add(product);
        Console.WriteLine($"{product} är nu tillagt!");
    }
    static void VisaInventarie()
    {
        // TODO: Implementera metod för att visa inventarie
        for (int i = 0; i < inventory.Count; i++)
        {
            Console.WriteLine($"[{i+1}] {inventory[i]}");
        }
    }
    static void TaBort()
    {


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