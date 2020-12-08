using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    public class Employee<T> : Person, IQuittable
    {
        public int ID { get; set; }
        public List<T> Things { get; set; }
        public override void SayName()
        {
            Console.WriteLine("Name: " + FistName + " " + LastName);

        }

        public void Quit()
        {
            Console.WriteLine("I have had it. I quit!");
        }

        public static bool operator ==(Employee<T> employee1, Employee<T> employee2)
        {
            bool isSame = employee1.ID == employee2.ID;
            return isSame;
        }
        public static bool operator !=(Employee<T> employee1, Employee<T> employee2)
        {
            bool isDifferent = employee1.ID != employee2.ID;
            return isDifferent;
        }
    }
}

