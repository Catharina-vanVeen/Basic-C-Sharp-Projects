using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaFunctions
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>();
            employees.Add(new Employee() { Firstname = "Joe", LastName = "Smith", ID = 1 });
            employees.Add(new Employee() { Firstname = "Joe", LastName = "Johnson", ID = 2 });
            employees.Add(new Employee() { Firstname = "Joe", LastName = "Black", ID = 3 });
            employees.Add(new Employee() { Firstname = "John", LastName = "Johnson", ID = 4 });
            employees.Add(new Employee() { Firstname = "John", LastName = "Black", ID = 5 });
            employees.Add(new Employee() { Firstname = "John", LastName = "Smith", ID = 6 });
            employees.Add(new Employee() { Firstname = "Susan", LastName = "Johnson", ID = 7 });
            employees.Add(new Employee() { Firstname = "Susan", LastName = "Black", ID = 8 });
            employees.Add(new Employee() { Firstname = "Susan", LastName = "Smith", ID = 9 });
            employees.Add(new Employee() { Firstname = "Susan", LastName = "White", ID = 10 });

            List<Employee> newList1 = new List<Employee>();
            foreach (Employee employee in employees)
            {
                if (employee.Firstname == "Joe")
                {
                    newList1.Add(employee);
                }
            }

            List<Employee> newList2 = employees.Where(e => e.Firstname == "Joe").ToList();

            List<Employee> newList3 = employees.Where(e => e.ID > 5).ToList();

            Console.WriteLine("newList1");
            foreach (Employee e in newList1)
            {
                Console.WriteLine(e.Firstname + " " + e.LastName + " " + e.ID);
            }

            Console.WriteLine("newList2");
            foreach (Employee e in newList2)
            {
                Console.WriteLine(e.Firstname + " " + e.LastName + " " + e.ID);
            }
            
            Console.WriteLine("newList2");
            foreach (Employee e in newList3)
            {
                Console.WriteLine(e.Firstname + " " + e.LastName + " " + e.ID);
            }

            Console.ReadKey();
        }
    }
}
