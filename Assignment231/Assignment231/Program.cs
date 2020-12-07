using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment231
{
    class Program
    {
        static void Main(string[] args)
        {
            MathClass math = new MathClass();
            Console.WriteLine("Please enter an integer");
            int number = Convert.ToInt32(Console.ReadLine());

            math.Half(number);

            Console.WriteLine(StaticMathClass.Half(number));
            int remainder;
            Console.WriteLine(StaticMathClass.Half(number, out remainder));
            Console.WriteLine("Remainder " + remainder);

            Console.WriteLine("Please enter a decimal");
            decimal number2 = decimal.Parse(Console.ReadLine());
            Console.WriteLine(StaticMathClass.Half(number2));
            Console.ReadKey();
            


        }
    }
}
