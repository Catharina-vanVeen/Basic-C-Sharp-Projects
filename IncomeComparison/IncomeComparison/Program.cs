using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncomeComparison
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anonymous Income Comparison Program");
            Console.WriteLine("Person 1");
            Console.WriteLine("Hourly Rate?");
            float hourlyRate1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Hours worked per week?");
            float hours1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Person 2");
            Console.WriteLine("Hourly Rate?");
            float hourlyRate2 = float.Parse(Console.ReadLine());
            Console.WriteLine("Hours worked per week?");
            float hours2 = float.Parse(Console.ReadLine());

            Console.WriteLine("Annual salary of Person 1:");
            float annualSalary1 = hourlyRate1 * hours1 * 52;
            Console.WriteLine(annualSalary1);
            Console.WriteLine("Annual salary of Person 2:");
            float annualSalary2 = hourlyRate2 * hours2 * 52;
            Console.WriteLine(annualSalary2);

            Console.WriteLine("Does Person 1 make more money than Person 2?");
            Console.WriteLine(annualSalary1 > annualSalary2);

            Console.ReadLine();
        }
    }
}
