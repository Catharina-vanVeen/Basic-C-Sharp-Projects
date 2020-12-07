using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment231
{
    public static class StaticMathClass
    {
        public static int Half(int input)
        {
            return input / 2;
        }
        public static decimal Half(decimal input)
        {
            return input / 2;
        }
        public static int Half(int input, out int remainder)
        {
            remainder = input % 2;
            return input / 2;
        }
    }
}
