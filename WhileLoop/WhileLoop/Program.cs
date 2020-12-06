using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            int min = 1;
            int max = 10;
            Console.WriteLine("Think of a number between " + min + " and " + max + " (inclusive) and I will guess it.");
            Console.WriteLine("Click any key when you are ready.");
            Console.ReadKey();
            while (min <= max)
            {
                int guess = (min + max) / 2;
                string reply = "";
                do
                {
                    Console.WriteLine("Is it " + guess + "?");
                    Console.WriteLine("Please reply 'l' for too low, 'h' for too high and 'y' for yes");
                    reply = Console.ReadLine();
                    if (reply == "l") 
                    { 
                        min = guess + 1; 
                    }
                    else if (reply == "h")
                    {
                        max = guess - 1;
                    }
                    else if (reply == "y")
                    {
                        Console.WriteLine("I won!");
                        Console.ReadKey();
                        return;
                    }
                }
                while (reply != "l" && reply != "h" && reply != "y");
            }
            Console.WriteLine("Game Over! You made a mistake");
            Console.ReadKey();
            return;

        }
    }
}
