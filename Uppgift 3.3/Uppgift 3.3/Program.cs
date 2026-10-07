using System;

namespace Uppgift_3._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("För att hyra en bil kostar det 80kr per timme man kör.");
            Console.WriteLine("Hur många timmar tänker du hyra bilen, svara i heltal?");
            int timmar = int.Parse(Console.ReadLine());
            int kostnad = timmar * 80;

            switch (kostnad)
            {
                case <= 950:
                    Console.WriteLine($"Kostnaden för att hyra bilen i {timmar} timmar är {kostnad} kr");
                    Console.ReadKey();
                    break;
                case > 950:
                    Console.WriteLine($"kostnaden för att hyra bilen i {timmar} timmar är {kostnad} kr, ");
                    Console.WriteLine($"men eftersom det är mer än 950kr så får du hyra bilen för 950kr istället.");
                    Console.ReadKey();
                    break;
                default:
                    Console.WriteLine("Du skrev inte in ett heltal antal timmar, vänligen försök igen.");
                    Console.ReadKey();
                    break;
            }


        }
    }
}