using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_4_part_4_
{
    internal class Student
    {

        //public string Ssn { get; set; }
        //public string Name { get; set; }
        //public int Age { get; set; }
        //public string Address { get; set; }

        private string ssn;
        private string name;
        private int age;
        private string address;


        //public string GetName()
        //{
        //    return name;
        //}

        //public void SetName(string value)
        //{
        //    name = value;
        //}
        public string Ssn
        {
            set { ssn = value; }
            get { return ssn; }
        }
        public string Name
        {
            set { name = value; }
            get { return name; }
        }
        public int Age
        {
            set { age = value; }
            get { return age; }
        }
        public string Address
        {
            set { address = value; }
            get { return address; }
        }

        public void Print()
        {
            Console.WriteLine($"SSN: {ssn}, Name: {name}, Age: {age}, Address: {address}");
        }
    }
}
