using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BranchingAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");
            Console.WriteLine("What is the weight of the package?");
            float weight = float.Parse(Console.ReadLine());
            if (weight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                Console.ReadKey();
                return;
            }
            Console.WriteLine("What is the width of the package?");
            float width = float.Parse(Console.ReadLine());
            Console.WriteLine("What is the height of the package?");
            float height = float.Parse(Console.ReadLine());
            Console.WriteLine("What is the length of the package?");
            float length = float.Parse(Console.ReadLine());
            if (width + height + length > 50)
            {
                Console.WriteLine("Package too big to be shipped via Package Express.");
                Console.ReadKey();
                return;
            }
            else
            {
                string quote = (width * height * length * weight / 100).ToString("N2");
                Console.WriteLine("Your estimated total for shipping this package is: $" + quote);
                Console.ReadKey();
                return;
            }
        }
    }
}
