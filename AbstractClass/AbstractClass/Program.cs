using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    class Program
    {
        static void Main(string[] args)
        {
            //Employee employee = new Employee() { FistName = "Sample", LastName = "Student" };
            //employee.SayName();

            IQuittable quitter = new Employee();
            quitter.Quit();

            Console.ReadKey();
        }
    }
}
