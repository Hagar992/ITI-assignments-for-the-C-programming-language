using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAY_4_part_3_
{
    internal class Program
    {
        static void Main(string[] args)
        {

            My_math math = new My_math();

            Console.WriteLine("Enter the first number:");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the second number:");
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Calculator:");
            Console.WriteLine($"Add {num1} + {num2} = " + math.Add(num1, num2));
            Console.WriteLine($"Sub {num1} - {num2} = " + math.Sub(num1, num2));
            Console.WriteLine($"Mul {num1} * {num2} = " + math.Mul(num1, num2));
            Console.WriteLine($"Div {num1} / {num2} = " + (num2 != 0 ? math.Div(num1, num2).ToString() : "Cannot divide by zero"));
            Console.WriteLine($"Reminder {num1} % {num2} = " + (num2 != 0 ? math.Reminder(num1, num2).ToString() : "Cannot divide by zero"));
        }


    }

}
