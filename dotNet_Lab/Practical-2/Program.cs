using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace practical2
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName, country;
            do
            {
                Console.WriteLine("What's your name?");
                firstName = Console.ReadLine();
            }
            while (!Regex.IsMatch(firstName, @"^[a-zA-Z]+$"));
            do
            {
                Console.WriteLine("Where are you from?");
                country = Console.ReadLine();
            }
            while (!Regex.IsMatch(country, @"^[a-zA-Z]+$"));

            Console.WriteLine("Hello " + firstName + " from " + country);
        }
    }
}