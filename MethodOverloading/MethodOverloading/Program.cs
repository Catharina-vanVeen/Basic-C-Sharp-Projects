using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverloading
{
    class Program
    {
        static void Main(string[] args)
        {
            MagicMath magic = new MagicMath();

            Console.WriteLine(magic.SurpriseMath(5));
            Console.WriteLine(magic.SurpriseMath(5.33m));
            Console.WriteLine(magic.SurpriseMath("5"));

            Console.ReadKey();
        }
    }
}
