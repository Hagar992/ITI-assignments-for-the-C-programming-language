using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1_iti_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Print the sum of two num
            Console.WriteLine("Q1_____________________________________");

            int num_1 = 3;
            int num_2 = 2;
            int sum = num_1 + num_2;
            Console.WriteLine($"{num_1}+{num_2}= {sum}");



            Console.WriteLine("Q2_____________________________________");

            //Console.WriteLine("Enter 6 number");
            int n1 = 9;
            int n2 = 4;
            int n3 = 6;
            int n4 = 3;
            int n5 = 5;
            int n6 = 7;
            int R1 = n1 + n2 * n3;
            int R2 = (n2 + n3) % n4;
            int R3 = n1 + n2 * n4 / n5;
            int R4 = n1 + n2 / n3 * n4 - n5 % n6;
            Console.WriteLine($"R1={n1} + {n2} *{n3}= {R1}");
            Console.WriteLine($"R2=( {n2} +{n3} )% {n4}= {R2}");
            Console.WriteLine($"R3={n1} + {n2} * {n4} / {n5}= {R3}");
            Console.WriteLine($"R4= {n1} + {n2} / {n3} * {n4} - {n5} % {n6}= {R4}");



            Console.WriteLine("Q2.2_____________________________________");

            int x = 5;
            int z = (x++) + x;
            int c = x++;
            Console.WriteLine($"x++ = {c}");//6
            Console.WriteLine($"z=(x++(6))+x(5)= {z}");//11



            Console.WriteLine("Q3_____________________________________");

            int A = 5;
            int B = 5;
            int C = 8;
            Console.WriteLine($"{A}>{B}=> {A > B}");
            Console.WriteLine($"{A}={B}=> {A == B}");
            Console.WriteLine($"{A}={C}=> {A < C}");
            Console.WriteLine($"{C}>{B} ||{A}<{C} => {C > B || A < C}");
            Console.WriteLine($"{C}>{B} && {C}>{A}=> {C > B && C > A}");

















        }
    }
}
