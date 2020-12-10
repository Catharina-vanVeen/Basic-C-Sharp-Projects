using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment310
{
    public class Student
    {
        public Student(string name) : this(name, "Freshman") {  }

        public Student(string name, string year)
        {
            Name = name;
            Year = year;
        }

        public string Name { get; set; }
        public string Year { get; set; }
    }
}
