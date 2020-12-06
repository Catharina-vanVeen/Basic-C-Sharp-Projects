using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> integers = new List<int>() { 2, 5, 8, 13, 16, 347, 3456, 50000, 2000000 };
            Console.WriteLine("Please provide an integer to divide by.");
            try
            {
                int divisor = int.Parse(Console.ReadLine());
                foreach (int integer in integers)
                {
                    Console.WriteLine(integer + " / " + divisor + " = " + (integer / divisor));
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("You did not enter an integer.");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("One can't devide by zero.");
            }
            Console.WriteLine("Press any key to end the program.");
            Console.ReadKey();
        }
    }
}
