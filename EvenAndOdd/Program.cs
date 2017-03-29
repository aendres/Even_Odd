using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvenAndOdd
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;

            do
            {
                Console.WriteLine("Enter a number between 1 and 100: ");
                int number = int.Parse(Console.ReadLine());

                if (number % 2 != 0)
                {
                    Console.WriteLine(number + " is Odd");
                }
                else if (number >= 2 && number % 2 == 0 && number <= 25)
                {
                    Console.WriteLine(number + " is Even and less than 25");
                }

                else if (number % 2 == 0 && number >= 26)
                {
                    Console.WriteLine(number + " is Even");
                }

                Console.WriteLine("Would you like to continue? (y/n)");
                input = Console.ReadLine();
            }
            while (input.ToLower() == "y");
            {
                Console.WriteLine("Have a good day!");
            }
        }
    }
}
