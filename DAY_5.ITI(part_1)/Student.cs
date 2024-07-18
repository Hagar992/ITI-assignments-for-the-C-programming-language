using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAY_5.ITI_part_1_
{
    internal class Student
    {
        private string ssn;
        private string name;
        private int age;
        private string address;
        static int counter = 0;

        public string Ssn { get => ssn; set => ssn = value; }
        public string Name { get => name; set => name = value; }
        public int Age { get => age; set => age = value; }
        public string Address { get => address; set => address = value; }
        public static int Counter { get => counter; set => counter = value; }

        //Use"constructor chaining"
        public Student()
        {   
            counter++;
            Notification();


        }
        public Student(string ssn):this()
        {
            this.Ssn = ssn;
        }
        public Student(string ssn, string name):this(ssn)
        {
            this.Name = name;
        }
        public Student(string ssn, string name, int age):this(ssn, name)
        {
            this.Age = age;
        }

        public Student(string ssn, string name, int age, string address):this(ssn, name,age) 
        {
            this.Address = address;
        }

        public static int GetCounter()
        {

            return counter;
        }
        public string Print()
        {
            return $"SSN={ssn} " +
                $"Name:{name}" +
                $"Age:{age}" +
                $"Address:{address}";

        }
        private static void Notification()
        {
            if (counter % 10 == 0)
            {
                Console.WriteLine("Notification: 10 students have been added.");
            }
        }


    }
}
