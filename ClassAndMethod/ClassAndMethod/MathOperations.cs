using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAndMethod
{
    class MathOperations
    {
        public static int? Square(int input)
        {
            try
            {
                return checked(input * input);
            }
            catch (OverflowException)
            {
                Console.WriteLine("The number you chose is too big to calculate the square");
                return null;
            }
        }
        public static int? Factorial(int input)
        {
            if (input < 0)
            {
                Console.WriteLine("Factorial for negative numbers does not exist.");
                return null;
            }
            else
            {
                int factorial = 1;
                try
                {
                    for (int i = 1; i <= input; i++)
                    {
                        factorial = checked(factorial * i);
                    }
                    return factorial;

                }
                catch (OverflowException)
                {
                    Console.WriteLine("The number you chose is too big to calculate the factorial.");
                    return null;
                }
            }
            
        }
        public static int? TriangularNumber(int input)
        {
            try
            {
                return checked(input * (input + 1) / 2);
            }
            catch (OverflowException)
            {
                Console.WriteLine("The number you chose is too big to calculate the triangular number.");
                return null;
            }
            
        }
    }
}
