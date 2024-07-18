using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAY_7.ITI_part_1_
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine($"dev=> 2/1= {Calc.Dev(2, 1)}");
            Console.WriteLine($"Sum=> 3+2= {Calc.Sum(3, 2)}");
            Console.WriteLine($"Sub=> 5-2= {Calc.Sub(5, 2)}");
            Console.WriteLine($"Mul=> 2*5= {Calc.Mul(2, 5)}");
            Console.WriteLine($"Dev=> 2/0= {Calc.Dev(2, 0)}");

        }
    }
}
