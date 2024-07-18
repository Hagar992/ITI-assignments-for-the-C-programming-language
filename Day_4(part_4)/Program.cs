using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_4_part_4_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[4];

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"Enter element{i}: ");
                array[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine($"The Element Before Swab: ");
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"Element{i}= {array[i]} ");

            }

            Console.WriteLine("Enter index_1: ");
            int index_1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter index_2: ");
            int index_2 = int.Parse(Console.ReadLine());



            Swab_1(array, index_1, index_2);
            Console.WriteLine($"The Element After Swab: ");
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"Element{i}= {array[i]} ");

            }
            void Swab_1(int[] arra, int num_1, int num_2)
            {
                int item = arra[num_1];
                num_1 = arra[num_2];
                num_2 = item;
            }









            Console.WriteLine("\nEnter details for one student:");
            Student singleStudent = new Student();
            Console.Write("Enter SSN: ");
            singleStudent.Ssn = Console.ReadLine();
            Console.Write("Enter Name: ");
            singleStudent.Name = Console.ReadLine();
            Console.Write("Enter Age: ");
            singleStudent.Age = int.Parse(Console.ReadLine());
            Console.Write("Enter Address: ");
            singleStudent.Address = Console.ReadLine();

            Console.WriteLine("Student details:");
            singleStudent.Print();


            Console.WriteLine("\nEnter number of students:");
            int numberOfStudents = int.Parse(Console.ReadLine());
            Student[] students = new Student[numberOfStudents];

            for (int i = 0; i < numberOfStudents; i++)
            {
                Console.WriteLine($"\nEnter details for student {i + 1}:");
                students[i] = new Student();
                Console.Write("Enter SSN: ");
                students[i].Ssn = Console.ReadLine();
                Console.Write("Enter Name: ");
                students[i].Name = Console.ReadLine();
                Console.Write("Enter Age: ");
                students[i].Age = int.Parse(Console.ReadLine());
                Console.Write("Enter Address: ");
                students[i].Address = Console.ReadLine();
            }

            Console.WriteLine("\nStudents details:");
            for (int i = 0; i < numberOfStudents; i++)
            {
                students[i].Print();
            }
        }

    }
}
