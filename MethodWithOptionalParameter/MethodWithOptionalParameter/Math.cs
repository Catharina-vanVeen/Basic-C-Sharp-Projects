using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodWithOptionalParameter
{
    class Math
    {
        public int SurpriseMath(int input1, int input2 = 5)
        {
            return input1 * input2;
        }
    }
}
