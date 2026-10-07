using System;

namespace Uppgift_3._5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv ett heltal: ");
            int tal1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Skriv ett annat heltal: ");
            int tal2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Välj ett alternativ: ");
            Console.WriteLine("1. addition");
            Console.WriteLine("2. subtraktion");
            Console.WriteLine("3. multiplikation");
            Console.WriteLine("4. division");
            int val = int.Parse(Console.ReadLine());

            switch (val)
            {
                case 1:
                    Console.WriteLine($"Resultat: {tal1 + tal2}");
                    break;
                case 2:
                    Console.WriteLine($"Resultat: {tal1 - tal2}");
                    break;
                case 3:
                    Console.WriteLine($"Resultat: {tal1 * tal2}");
                    break;
                case 4:
                    if (tal2 != 0)
                    {
                        Console.WriteLine($"Resultat: {tal1 / tal2}");
                    }
                    else
                    {
                        Console.WriteLine("Fel: Division med noll är inte tillåten.");
                    }
                    break;
                default:
                    Console.WriteLine("Fel: Ogiltigt val.");
                    break;
            }
        }
    }
}