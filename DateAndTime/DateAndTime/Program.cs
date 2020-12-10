using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateAndTime
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime now = DateTime.Now;
            Console.WriteLine(now);
            Console.WriteLine("Please provide number of hours");
            double hours = Convert.ToDouble(Console.ReadLine());
            DateTime future = now.AddHours(hours);
            Console.WriteLine(future.ToString("H:mm:ss"));

            Console.ReadKey();
        }
    }
}
