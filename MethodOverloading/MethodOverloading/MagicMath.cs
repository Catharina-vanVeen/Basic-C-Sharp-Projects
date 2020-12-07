using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverloading
{
    class MagicMath
    {
        public int SurpriseMath(int input)
        {
            return input * 2;
        }

        public int SurpriseMath(decimal input)
        {
            return Convert.ToInt32(input * 10);
        }

        public int SurpriseMath(string input)
        {
            try
            {
                return Convert.ToInt32(input) * 5;
            }
            catch
            {
                return 0;
            }
        }

    }
}
