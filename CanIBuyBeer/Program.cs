using System;

namespace CanIBuyBeer
{
    class Program
    {
        static int SafeNumberInput()
        {
            int number;
            while (true)
            {
                string input = Console.ReadLine();
                if (int.TryParse(input, out number) == true)
                    break;
                Console.WriteLine("Var vänlig bara siffor tack!");
            }

            return number;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hur gammal är du?");
            var age = SafeNumberInput();
            Console.WriteLine("Vilken location är du på? (systemet/krogen)");
            var location = Console.ReadLine();
            location = location.ToLower();
            Console.WriteLine("Har du leg? (J/N)");
            var leg = Console.ReadLine();
            Console.WriteLine("Vilken promillehalt har du?");
            decimal promille = Convert.ToDecimal(Console.ReadLine());

            //if (age > 17 && locationA == "krogen" && leg == "J" && promille < 1.0m ||
            //    age > 19 && locationB == "systemet" && leg == "J" && promille < 1.0m)
            //{
            //    Console.WriteLine("Du får köpa Sharaab.");
            //}
            //else
            //{
            //    Console.WriteLine("Nej du får inte köpa Sharaab.");
            //}

            bool canIBuyBeer = age > 17 && location == "krogen" && leg == "J" && promille < 1.0m ||
                age > 19 && location == "systemet" && leg == "J" && promille < 1.0m;
            if (canIBuyBeer == true)
            {
                Console.WriteLine("Du kan köpa Öl.");
            }
            else
            {
                Console.WriteLine("Du kan inte köpa Öl.");
            }
        }
    }
}
