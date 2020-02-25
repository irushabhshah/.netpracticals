using System;

namespace Practical_1
{
    class Program
    {
        static void Main(string[] args)
        {
            PatternOne();
            PatternTwo();
            PatternThree();
        }

        private static void PatternOne()
        {
            Console.WriteLine("Patter 1 Start");
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= 5; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine(" ");
            }
            Console.WriteLine("Patter 1 End");
        }
        private static void PatternTwo()
        {
            Console.WriteLine("Patter 2 Start");
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine(" ");
            }
            Console.WriteLine("Patter 2 End");
        }
        private static void PatternThree()
        {
            Console.WriteLine("Patter 3 Start");
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 5; j >= i; j--)
                {
                    Console.Write(" ");
                }
                for (int k = 1; k <=i; k++) {
                    Console.Write("*");

                }
                Console.WriteLine(" ");
            }
            Console.WriteLine("Patter 3 End");
        }
    }
}
