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
            Console.WriteLine("3. Avsluta");

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
}