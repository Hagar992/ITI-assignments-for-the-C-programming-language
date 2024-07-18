using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAY_5.ITI_Part_2_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Teacher teacher = new Teacher(1, "Ali", "Doe", "cairo", 40, 50000, "Math");
            Console.WriteLine("Teacher Information:");
            teacher.Print();

           
            Student student = new Student(2, "Hala", "Smith", "alex", 16, 11, "B");
            Console.WriteLine("\nStudent Information:");
            student.Print();
        }
    }
}
