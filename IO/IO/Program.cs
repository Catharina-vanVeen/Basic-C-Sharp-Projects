using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace IO
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please provide a number.");
            File.WriteAllText(@"C:\Users\Owner\Desktop\log.txt", Console.ReadLine());
            Console.WriteLine(File.ReadAllText(@"C:\Users\Owner\Desktop\log.txt"));
            Console.ReadKey();
        }
    }
}
