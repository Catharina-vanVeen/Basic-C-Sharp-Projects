using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAndMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please provide an integer.");
            try
            {
                int input = int.Parse(Console.ReadLine());

                int? square = MathOperations.Square(input);
                if (square != null)
                {
                    Console.WriteLine("The square of you number is " + square);
                }
                

                int? factorial = MathOperations.Factorial(input);
                if (factorial != null)
                {
                    Console.WriteLine(input + " factorial is " + factorial);
                }

                int? triangularNumber = MathOperations.TriangularNumber(input);
                if (triangularNumber != null)
                {
                    Console.WriteLine("The triangular number for " + input + " is " + triangularNumber);
                }
                

            }
            catch (OverflowException)
            {
                Console.WriteLine("The number you picked is too big to handle.");
            }

            Console.ReadKey();
        }
    }
}
