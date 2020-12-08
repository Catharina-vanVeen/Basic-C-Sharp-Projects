using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    public class Employee : Person, IQuittable
    {
        public int ID { get; set; }
        public override void SayName()
        {
            Console.WriteLine("Name: " + FistName + " " + LastName);

        }

        public void Quit()
        {
            Console.WriteLine("I have had it. I quit!");
        }

        public static bool operator ==(Employee employee1, Employee employee2)
        {
            bool isSame = employee1.ID == employee2.ID;
            return isSame;
        }
        public static bool operator !=(Employee employee1, Employee employee2)
        {
            bool isDifferent = employee1.ID != employee2.ID;
            return isDifferent;
        }
    }
}

