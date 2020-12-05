using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please provide an integer between -184,467,440,737,095,516 and 184,467,440,737,095,516.");
            long number1 = long.Parse(Console.ReadLine()) * 50;
            Console.WriteLine("Your number mulitplied by 50 is " + number1);

            Console.WriteLine("Please provide an integer between -9,223,372,036,854,775,808 and 9,223,372,036,854,775,782.");
            long number2 = long.Parse(Console.ReadLine()) + 25;
            Console.WriteLine("Your number plus 25 is " + number2);

            Console.WriteLine("Please provide an integer between -9,223,372,036,854,775,808 and 9,223,372,036,854,775,807.");
            double number3 = long.Parse(Console.ReadLine()) / 12.5;
            Console.WriteLine("Your number divided by 12.5 is " + number3);

            Console.WriteLine("Please provide an integer between -9,223,372,036,854,775,808 and 9,223,372,036,854,775,807.");
            long number4 = long.Parse(Console.ReadLine());
            bool isGreater = number4 > 50;
            Console.WriteLine("Your number is greater than 50? " + isGreater);

            Console.WriteLine("Please provide an integer between -9,223,372,036,854,775,808 and 9,223,372,036,854,775,807.");
            long number5 = long.Parse(Console.ReadLine()) % 7;
            Console.WriteLine("Your number mod 7 is " + number5);
            Console.ReadLine();
        }

    }
}
