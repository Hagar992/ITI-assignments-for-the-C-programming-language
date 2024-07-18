using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace DAY_7.ITI_part_2_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //get number from user and print corresponding day name to it. 1-7
            Console.Write("Enter Num Between 1_7: ");
            int num=int.Parse(Console.ReadLine());

            if(num<1||num>7)
            {
                Console.WriteLine("\"Invalid input. Please enter a number between 1 and 7:");
            }
            else
            {
                Days day = (Days)num;
                Console.WriteLine("The corresponding day is: " + day);
            }

        }
        enum Days
        {
            Sunday = 1,
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday

        }
    }
}
