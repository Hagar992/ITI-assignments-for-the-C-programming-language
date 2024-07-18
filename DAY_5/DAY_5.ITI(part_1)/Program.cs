using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAY_5.ITI_part_1_
{
    internal class Program
    {
        static void Main(string[] args)
        {



            while (true)
            {
                Console.WriteLine("Do you want to enter data for a single student or multiple students? (one/group/exit)");
                string choice = Console.ReadLine().ToLower();

                if (choice == "one")
                {
                    EnterStudentData();
                }
                else if (choice == "group")
                {
                    Console.Write("How many students do you want to enter? ");
                    int numberOfStudents = int.Parse(Console.ReadLine());

                    for (int i = 0; i < numberOfStudents; i++)
                    {
                        Console.WriteLine($"Enter data for student {i + 1}:");
                        EnterStudentData();
                        Console.WriteLine("_________________________________");
                    }
                }
                else if (choice == "exit")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid choice. Please choose either 'one', 'group', or 'exit'.");
                }
            }

        }
        private static void EnterStudentData()
        {
            Console.Write("SSN: ");
            string ssn = Console.ReadLine();
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Age: ");
            int age = int.Parse(Console.ReadLine());
            Console.Write("Address: ");
            string address = Console.ReadLine();
            Student student = new Student(ssn, name, age, address);
            student.Print(); 
        }

    }
}
