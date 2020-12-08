using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enums
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("What day of the week is today?");
            try
            {
                DayOfTheWeek day = (DayOfTheWeek)Enum.Parse(typeof(DayOfTheWeek), Console.ReadLine(), true);
                Console.WriteLine(day);
                Console.ReadKey();
            }
            catch (ArgumentException)
            {
                Console.WriteLine("Please enter an actual day of the week.");
                Console.ReadKey();
                Main();
            }
            
        }

        public enum DayOfTheWeek
        {
            Monday,
            Tueday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }
    }
}
