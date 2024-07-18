using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iti_Day_3_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*3D_Array
             * // استقبال أبعاد المصفوفة من المستخدم
                Console.Write("Enter the number of layers: ");
                int layers = int.Parse(Console.ReadLine());
        
                Console.Write("Enter the number of rows: ");
                int rows = int.Parse(Console.ReadLine());

                Console.Write("Enter the number of columns: ");
                int columns = int.Parse(Console.ReadLine());

                // تعريف المصفوفة ثلاثية الأبعاد بالأبعاد التي تم استقبالها
                int[,,] array3D = new int[layers, rows, columns];

                // تعبئة المصفوفة بالقيم باستخدام الحلقات و GetLength
                for (int i = 0; i < array3D.GetLength(0); i++) // GetLength(0) للحصول على عدد الطبقات
                {
                    for (int j = 0; j < array3D.GetLength(1); j++) // GetLength(1) للحصول على عدد الصفوف
                    {
                        for (int k = 0; k < array3D.GetLength(2); k++) // GetLength(2) للحصول على عدد الأعمدة
                        {
                            Console.Write($"Enter value for element at [{i}, {j}, {k}]: ");
                            array3D[i, j, k] = int.Parse(Console.ReadLine());
                        }
                    }
                }

                // طباعة المصفوفة
                Console.WriteLine("The 3D array:");
                for (int i = 0; i < array3D.GetLength(0); i++)
                {
                    for (int j = 0; j < array3D.GetLength(1); j++)
                    {
                        for (int k = 0; k < array3D.GetLength(2); k++)
                        {
                            Console.Write(array3D[i, j, k] + " ");
                        }
                        Console.WriteLine();
                    }
                    Console.WriteLine();
                }
              
             */

            /*Casting(Convert & Parse & TryParse)
             * Convert  	 يعيد القيمة الافتراضية  	       يرمي استثناءات عند الفشل     	تحويل الأنواع المتعددة
             * Parse    	يرمي   ArgumentNullException	 يرمي استثناءات عند الفشل	                                  تحويل السلاسل النصية فقط      ط            
             * TryParse 	يعيد  false بدون استثناءات	          لا يرمي استثناءات        	           تحويل السلاسل النصية بأمان
             * 
             * 
             * Convert: مرن ويُستخدم لتحويل أنواع متعددة، يمكنه التعامل مع القيم null.
             * Parse: مخصص لتحويل السلاسل النصية إلى نوع محدد، يرمي استثناءات عند الفشل.
             * TryParse: آمن لتحويل السلاسل النصية إلى نوع محدد بدون رمي استثناءات، يعيد قيمة منطقية للإشارة إلى النجاح أو الفشل.
  
             */

            /*Type of error
             * 1-(Syntax Errors)>>تحدث عندما تكون هناك مشاكل في بناء الجملة (syntax) الخاصة بالكود.
             * 2- (Runtime Errors)>>تحدث أثناء تشغيل البرنامج.
             * 3_(Logical Errors)>>تحدث عندما يعمل البرنامج ولكن لا ينتج النتائج المتوقعة بسبب خطأ في منطق الكود.
             * 
             * 
             
             */
            /*OOP
             * 
             */

            /*Task_3
             * 
             
             */
            Console.WriteLine("Do you want to enter data for one employee or a group of employees? (Enter 'one' or 'group'):");
            string choice = Console.ReadLine().ToLower();

            if (choice == "one")
            {
                Employee employee = EnterEmployeeData();
                employee.PrintOnConsole();
            }
            else if (choice == "group")
            {
                Console.Write("Enter the number of employees: ");
                int numEmployees;
                while (!int.TryParse(Console.ReadLine(), out numEmployees) || numEmployees <= 0)
                {
                    Console.Write("Please enter a valid number of employees: ");
                }

                Employee[] employees = new Employee[numEmployees];
                for (int i = 0; i < numEmployees; i++)
                {
                    Console.WriteLine($"Enter data for employee {i + 1}:");
                    employees[i] = EnterEmployeeData();
                }

                for (int i = 0; i < numEmployees; i++)
                {
                    Console.WriteLine($"Employee {i + 1}:");
                    employees[i].PrintOnConsole();
                }
            }
            else
            {
                Console.WriteLine("Invalid choice. Please restart the program and enter 'one' or 'group'.");
            }
        }

        static Employee EnterEmployeeData()
        {
            Employee employee = new Employee();

            try
            {
                Console.Write("Enter SSN: ");
                employee.setSsn(int.Parse(Console.ReadLine()));

                Console.Write("Enter First Name: ");
                employee.setFname(Console.ReadLine());

                Console.Write("Enter Last Name: ");
                employee.setLname(Console.ReadLine());

                while (true)
                {
                    try
                    {
                        Console.Write("Enter Age (23-45): ");
                        employee.setAge(int.Parse(Console.ReadLine()));
                        break;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }

                while (true)
                {
                    try
                    {
                        Console.Write("Enter Address (Cairo, Alex, Giza): ");
                        employee.setAddress(Console.ReadLine());
                        break;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");

            }

            return employee;

        }

        private struct Employee
        {
            private int ssn;
            private string fname;
            private string lname;
            private int age;//
            private string address;//

            public void setSsn(int ssn) { this.ssn = ssn; }
            public int getSsn() { return this.ssn; }

            public void setFname(string fname) { this.fname = fname; }
            public string getFname() { return this.fname; }

            public void setLname(string lname) { this.lname = lname; }
            public string getLname() { return this.lname; }

            public void setAge(int age)
            {
                if (age < 23 || age > 45) throw new Exception("You must enter the age between 23 and 45");
                this.age = age;
            }
            public int getAge() { return this.age; }

            public void setAddress(string address)
            {
                if (address.ToLower() != "cairo" && address.ToLower() != "alex" && address.ToLower() != "giza")
                {
                    throw new Exception("The address must be Cairo, Alex, or Giza.");
                }
                this.address = address;
            }
            public string getAddress() { return this.address; }

            public string Print()
            {
                return $"SSN= {ssn}\t" +
                    $"First_Name: {fname}\t" +
                    $"Last_Name: {lname} \t" +
                    $"Age: {age}\t" +
                    $"Address: {address} \t";

            }

            public void PrintOnConsole()
            {
                Console.WriteLine(Print());

            }

        }
    }
}
