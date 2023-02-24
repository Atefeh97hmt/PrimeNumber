using System;

namespace PrimeNumber
{
    public class PrimeNumber
    {
        public static void Main(string[] args)
        {
            int divisor = 0;
            Console.WriteLine("please enter a number:");
            int number = int.Parse(Console.ReadLine());

            void Prime_Number()
            {
                for (int counter = 1; counter <= number; counter++)
                    if (number % counter == 0) divisor++;

                if (divisor == 2)
                    Console.WriteLine(number + " " + "is prime");

                else
                    Console.WriteLine(number + " " + "is not prime");
            }
            Prime_Number();
            Console.ReadKey();
        }
    }
}