using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    public class Employee : Person, IQuittable
    {
        public override void SayName()
        {
            Console.WriteLine("Name: " + FistName + " " + LastName);

        }

        public void Quit()
        {
            Console.WriteLine("I have had it. I quit!");
        }
    }
}

