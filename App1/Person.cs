using System;
using System.Collections.Generic;
using System.Text;

namespace App1
{
    class Person
    {
        public String Name { get; private set; }
        public String Surname { get; private set; }
        public int Age { get; private set; }

        public Person(String name, String sname, int age)
        {
            this.Name = name;
            this.Surname = sname;
            this.Age = age;
        }

        public override string ToString()
        {
            return Name + " " + Surname;
        }
    }
}
