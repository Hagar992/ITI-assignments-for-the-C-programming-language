using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_7_part_5_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Build a program to let the user enter students data
            //and store them give home the option to edit or delete any index of the lost

            List<Student> students = new List<Student>();

            while (true)
            {
                Console.WriteLine("Choose an option:");
                Console.WriteLine("1. Add student");
                Console.WriteLine("2. Edit student");
                Console.WriteLine("3. Delete student");
                Console.WriteLine("4. List students");
                Console.WriteLine("5. Exit");

                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        AddStudent(students);
                        break;
                    case 2:
                        EditStudent(students);
                        break;
                    case 3:
                        DeleteStudent(students);
                        break;
                    case 4:
                        ListStudents(students);
                        break;
                    default:
                        Console.WriteLine("Invalid option. Please try again.");
                        break;
                }
            }
        }

        static void AddStudent(List<Student> students)
        {
            Console.WriteLine("Enter student ID:");
            string id = Console.ReadLine();
            Console.WriteLine("Enter student name:");
            string name = Console.ReadLine();
            Console.WriteLine("Enter student age:");
            int age = int.Parse(Console.ReadLine());

            students.Add(new Student { ID = id, Name = name, Age = age });
            Console.WriteLine("Student added successfully.");
        }

        static void EditStudent(List<Student> students)
        {
            Console.WriteLine("Enter the ID of the student to edit:");
            string id = Console.ReadLine();
            var studentToEdit = students.Find(s => s.ID == id);

            if (studentToEdit != null)
            {
                Console.WriteLine("Enter new name:");
                studentToEdit.Name = Console.ReadLine();
                Console.WriteLine("Enter new age:");
                studentToEdit.Age = int.Parse(Console.ReadLine());
                Console.WriteLine("Student updated successfully.");
            }
            else
            {
                Console.WriteLine("Student not found.");
            }
        }

        static void DeleteStudent(List<Student> students)
        {
            Console.WriteLine("Enter the ID of the student to delete:");
            string id = Console.ReadLine();
            var studentToDelete = students.Find(s => s.ID == id);

            if (studentToDelete == null)
            {
                Console.WriteLine("Student not found.");
                
            }
            else
            {
                students.Remove(studentToDelete);
                Console.WriteLine("Student deleted successfully.");
            }
        }

        static void ListStudents(List<Student> students)
        {
            Console.WriteLine("Student List:");
            foreach (var student in students)
            {
                Console.WriteLine(student);
            }
        }
    }
    
}
