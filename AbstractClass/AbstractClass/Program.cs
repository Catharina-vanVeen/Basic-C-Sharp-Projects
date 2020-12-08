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

            //IQuittable quitter = new Employee();
            //quitter.Quit();

            Employee<string> employeeA = new Employee<string>() { FistName = "John", LastName = "Doe", ID = 999, Things = new List<string> { "Apple", "Pear", "Banana" } };
            Employee<int> employeeB = new Employee<int>() { FistName = "Chris", LastName = "Smith", ID = 999, Things = new List<int> { 1, 5, 10, 50 } };

            foreach (string thing in employeeA.Things)
            {
                Console.WriteLine(thing);
            }

            foreach (int thing in employeeB.Things)
            {
                Console.WriteLine(thing);
            }



            //Employee<string> employeeC = new Employee<string>() { FistName = "John", LastName = "Doe", ID = 888 };
            //if (employeeA == employeeB)
            //{
            //    Console.WriteLine("employeeA and EmployeeB are the same");
            //}
            //if (employeeA != employeeC)
            //{
            //    Console.WriteLine("employeeA and EmployeeC are not the same");
            //}
            Console.ReadKey();
        }
    }
}
