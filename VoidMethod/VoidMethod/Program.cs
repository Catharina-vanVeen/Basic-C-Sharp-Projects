using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoidMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            MysteryOperation mystery = new MysteryOperation();
            mystery.Mystery(input1: 2, input2: 4);
            Console.ReadKey();
        }
    }
}
