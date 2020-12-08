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

            Employee employeeA = new Employee() { FistName = "John", LastName = "Doe", ID = 999 };
            Employee employeeB = new Employee() { FistName = "Chris", LastName = "Smith", ID = 999 };
            Employee employeeC = new Employee() { FistName = "John", LastName = "Doe", ID = 888 };
            if (employeeA == employeeB)
            {
                Console.WriteLine("employeeA and EmployeeB are the same");
            }
            if (employeeA != employeeC)
            {
                Console.WriteLine("employeeA and EmployeeC are not the same");
            }
            Console.ReadKey();
        }
    }
}
