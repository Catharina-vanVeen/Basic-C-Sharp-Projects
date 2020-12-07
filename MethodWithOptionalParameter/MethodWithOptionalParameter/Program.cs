using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodWithOptionalParameter
{
    class Program
    {
        static void Main(string[] args)
        {
            Math math = new Math();
            Console.WriteLine("Please provide an integer.");
            int input1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please provide another integer or press enter, if you don't want to provide a second integer.");
            try
            {
                int input2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(math.SurpriseMath(input1, input2));
            }
            catch
            {
                Console.WriteLine(math.SurpriseMath(input1));
            }
            Console.ReadKey();
        }
    }
}
