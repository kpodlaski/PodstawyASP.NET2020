using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Text;

namespace App1
{
    class Person : IComparable<Person>, IZapisDoPliku
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

        public int CompareTo([AllowNull] Person other)
        {
            return -this.Age + other.Age;
        }

        public void ZapiszDoPliku(string nazwa)
        {
            StreamWriter sw = new StreamWriter(nazwa);
            sw.WriteLine(this.ToString());
            sw.Close();
        }

        public void DodajDoPliku(string nazwa)
        {

            StreamWriter sw = new StreamWriter(nazwa,true);
            sw.WriteLine(this.ToString());
            sw.Close();
        }

        public static IComparer<Person> comparerByName()
        {
            return new ComparerByName();
        }

        class ComparerByName: IComparer<Person>
        {
            public int Compare([AllowNull] Person x, [AllowNull] Person y)
            {
                return x.Name.CompareTo(y.Name);
            }
        }
    }
}
