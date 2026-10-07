using System;

namespace Uppgift_3._4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Låtar på radiostationen har minst och max gränser.");
            Console.WriteLine("Ange minuter-längd för låten, t.ex 3 min och 50 sekunder (skriv endast " + "3" + " minuter):");
            int minuter = int.Parse(Console.ReadLine());
            Console.WriteLine("Ange sekunder-längd för låten, t.ex 3 min och 50 sekunder (skriv endast " + "50" + " sekunder):");
            int sekunder = int.Parse(Console.ReadLine());

            int totalTid = (minuter * 60) + sekunder;

            switch (totalTid)
            {
                case <= 260 and >= 165:
                    Console.WriteLine("Låten är av godkänd längd.");
                    Console.ReadKey();
                    break;
                case < 165:
                    Console.WriteLine("Låten är för kort.");
                    Console.ReadKey();
                    break;
                case > 260:
                    Console.WriteLine("Låten är för lång.");
                    Console.ReadKey();
                    break;
                default:
                    Console.WriteLine("Du har inte angett två giltiga siffror. Försök igen.");
                    Console.ReadKey();
                    break;
            }
        }
    }
}