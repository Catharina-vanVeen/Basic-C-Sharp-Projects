using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    class InvalidAnswerException : Exception
    {
        public InvalidAnswerException() : base() { }
        public InvalidAnswerException(string message) : base(message) { }
    }
}
