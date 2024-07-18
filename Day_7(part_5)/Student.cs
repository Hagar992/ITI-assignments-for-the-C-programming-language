using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_7_part_5_
{
    internal class Student
    {
        //public Student(string name, int age, string iD)
        //{
        //    Name = name;
        //    Age = age;
        //    ID = iD;
        //}

        public string Name { get; set; }
            public int Age { get; set; }
            public string ID { get; set; }

            public override string ToString()
            {
                return $"ID: {ID}, Name: {Name}, Age: {Age}";
            }
        
    }
}
