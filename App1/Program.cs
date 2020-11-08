using System;
using System.Collections.Generic;

namespace App1
{
    class Program
    {
        public int LiczbaA;
        public float LiczbaB;
        public String Text;
        
        public Program()
        {
            this.LiczbaA = 10;
            this.LiczbaB = -1.0f;
            this.Text = "No text";
        }
        

        public override string ToString()
        {
            return this.Text;
        }

        static void Main(String[] args)
        {
            Console.WriteLine("Hello World!");
            Program p = new Program();
            //p.LiczbaA = 12;
            //p.LiczbaB = 14;  //rzutowanie bezstratne
            //p.LiczbaB = 4.5f; // 4.5f to float
            //p.LiczbaB = (float)4.5; //rzutowanie doube na float
            //p.Text = "Ala ma kota";
            Console.WriteLine(p.Text + " " + p.LiczbaA * p.LiczbaB + "::" + p);

            Student studentA = new Student("Alan", "Alanowski", 20);
            Student studentB = new Student("Alice", "Alicewska", 19);
            Console.WriteLine(studentA);
            Console.WriteLine(studentB);

            List<Student> studenci = new List<Student>();
            studenci.Add(studentA);
            studenci.Add(studentB);
            studenci.Add(new Student("Tom", "Toaszewski", 24));
            Console.WriteLine("===========================");
            //Console.WriteLine(studenci);
            foreach (Student st in studenci ){
                Console.WriteLine(st);
            }
            Console.WriteLine("===========================");
            for(int i=0; i<studenci.Count; i++)
            {
                Console.WriteLine(studenci[i]);
            }
            //delete studentA; W C# niszczenie robi .NET

        }
    }
}
