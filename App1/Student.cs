using System;
using System.Collections.Generic;
using System.Text;

namespace App1
{
    class Student : Person
    {
        private static int last_id = 0;
        public int ID { get; private set; }
        public Student(string name, string sname, int age) : base(name, sname, age)
        {
            ID = last_id++;
        }

        public override string ToString()
        {
            return "Student "+this.ID+ ", "+base.ToString();
        }
    }
}
