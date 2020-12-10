using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment310
{
    class Program
    {
        static void Main(string[] args)
        {
            const string school = "Dawson Academy";
            var student1 = new Student("Iestyn");
            Console.WriteLine("{0} is a {1} at {2}.",student1.Name, student1.Year, school);
            Console.ReadKey();

        }
    }
}
