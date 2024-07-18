using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAY_7.ITI_part_1_
{
    internal static class Calc
    {
        //class calc: sum, sub, mul, dev calling method without creating object
        public static int Sum(int a, int b)
        { 
            return a + b;
        }
        public static int Sub(int a, int b)
        {
            return  a - b;
        }
        public static int Mul(int a, int b)
        {
            return a * b; 
        }
        public static int Dev(int a, int b)
        {
            if (b == 0) throw new Exception("Cannot divide by zero.");
            return a / b;
        }

    }
}
