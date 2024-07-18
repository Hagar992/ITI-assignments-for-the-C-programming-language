using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAY_4_part_3_
{
    internal class My_math
    {
        public int Add(int a, int b)
        {
            return a + b;
        }

        public int Sub(int a, int b)
        {
            return a - b;
        }

        public int Mul(int a, int b)
        {
            return a * b;
        }

        public int Div(int a, int b)
        {
            if (b == 0)
            {
                throw new DivideByZeroException("Division by zero is not allowed.");
            }
            return a / b;
        }

        public int Reminder(int a, int b)
        {
            return a % b;
        }
    }
}
