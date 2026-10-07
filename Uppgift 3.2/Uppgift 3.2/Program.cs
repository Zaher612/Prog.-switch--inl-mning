using System;

namespace Uppgift_3._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Har du gått ut från gymnasiet?");
            Console.WriteLine("Om ja svara med 'j' och om nej svara med 'n'.");
            string svar = Console.ReadLine();
             
            Console.WriteLine("Vänligen ange din ålder nedan, svara endast med heltal:");
            int ålder = int.Parse(Console.ReadLine());

            switch (svar)
            {
                case "j" when ålder < 22:
                    Console.WriteLine("Vi vill gärna anställa dig!");
                    Console.ReadKey();
                    break;
                case "j" when ålder >= 22:
                    Console.WriteLine("Vi letar tyvär efter annan personal just nu.");
                    Console.ReadKey();
                    break;
                case "n" when ålder < 22 && ålder > 15:
                    Console.WriteLine("Vi vill gärna anställa dig!");
                    Console.ReadKey();
                    break;
                case "n" when ålder >= 22:
                    Console.WriteLine("Vi letar tyvär efter annan personal just nu.");
                    Console.ReadKey();
                    break;
                case "n" when ålder < 15:
                    Console.WriteLine("Vi letar tyvär efter annan personal just nu.");
                    Console.ReadKey();
                    break;
                default:
                    Console.WriteLine("Ogiltigt svar, vänligen försök igen.");
                    Console.ReadKey();
                    break;

            }
        }
    }
}