using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Struct
{
    class Program
    {
        static void Main(string[] args)
        {
            Number number = new Number();
            number.Amount = 12.5m;
            Console.WriteLine(number.Amount);
            

            //Number number2 = number;
            //Console.WriteLine(number2.Amount);
            
            //number2.Amount = 15.7m;
            //Console.WriteLine(number.Amount);
            //Console.WriteLine(number2.Amount);
            Console.ReadKey();

        }
    }
}
