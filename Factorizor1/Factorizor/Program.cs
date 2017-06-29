using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Test Test Test
namespace Factorizor
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = GetNumberFromUser();

            Calculator.PrintFactors(number);
            Calculator.IsPerfectNumber(number);
            Calculator.IsPrimeNumber(number);

            Console.WriteLine("Press any key to quit.");
            Console.ReadKey();
        }

        /// Prompt the user for an integer. 
        /// Make sure they enter a valid integer!
        /// See the String Input lesson for TryParse() examples.
        /// <returns>The user input as an integer.</returns>

        static int GetNumberFromUser()
        {
            string input;
            int output;

            while (true)
            {
                Console.Write("What number would you like to factor? ");
                input = Console.ReadLine();

                if (int.TryParse(input, out output))
                {
                    break; // Stop looping, if entry is a number
                }
                else
                    Console.WriteLine("That is not a number! Please enter a number.");
            }
            return output;
        }
    }
    class Calculator
    {

        /// Given a number, print the factors per the specification.

        public static void PrintFactors(int number)
        {
            Console.Write("The factors are:");
            for (int i = 1; i <= number; i++)
            {
                if (number % i == 0)
                {
                    Console.Write(" " + i);
                }
            }
            Console.WriteLine();
        }

        /// Given a number, print if it is perfect or not.

        public static void IsPerfectNumber(int number)
        {
            int pernum = 0;
            for (int i = 1; i < number; i++)
            {
                if (number % i == 0)
                {
                    pernum = pernum + i;
                }
            }
            if (pernum == number)
            {
                Console.WriteLine(number + " is a perfect number.");
            }
            else
            {
                Console.WriteLine(number + " is not a perfect number");
            }
        }

        /// Given a number, print if it is prime or not.

        public static void IsPrimeNumber(int number)
        {
            int prinum = 0;
            for (int i = 1; i <= number; i++)
            {
            if (number % i == 0)
                {
                prinum += 1;
                }
            }
            if (prinum == 2)
            {
                Console.WriteLine(number + " is a prime number");
            }
            else
            {
                Console.WriteLine(number + " is not a prime number");
            }
        }
    }
}
