using System;

namespace Övning3_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("För att delta i tävlingen måste du angå din ålder.");
            Console.Write("Ange din ålder: ");
            int ålder = int.Parse(Console.ReadLine());

            switch (ålder)
            {
                case < 16:
                    Console.WriteLine("Du är för ung för att delta i tävlingen.");
                    Console.ReadKey();
                    break;
                case >= 16 and <= 19:
                    Console.WriteLine("Du är i rätt åldersgrupp, registra dig för tävlingen!");
                    Console.ReadKey();
                    break;
                case > 19:
                    Console.WriteLine("Tyvär, du är för gammal för att delta i tävlingen.");
                    Console.ReadKey();
                    break;
                default:
                    Console.WriteLine("DU har inte angett ett heltals nummer.");
                    Console.WriteLine("Vänligen försök igen.");
                    break;
            }
        }
    }
}