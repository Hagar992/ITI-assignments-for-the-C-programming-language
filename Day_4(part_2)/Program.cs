using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_4_part_2_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[4];
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"Enter Element({i}): ");
                array[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Array befor swapping:");
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"Element({i}) = {array[i]} ");
            }
            Console.WriteLine();

            Console.Write("Enter the first index: ");
            int index1 = int.Parse(Console.ReadLine());
            Console.Write("Enter the second index: ");
            int index2 = int.Parse(Console.ReadLine());

            if (index1 >= 0 && index1 < array.Length && index2 >= 0 && index2 < array.Length)
            {
                Swab(ref array[index1], ref array[index2]);
                Console.WriteLine("Array after swapping:");
                for (int i = 0; i < array.Length; i++)
                {
                    Console.Write($"Element({i}) = {array[i]} ");
                }
                Console.WriteLine(); // Print a newline for better readability
            }
            else
            {
                Console.WriteLine("Invalid indices. Please enter valid indices within the array bounds.");
            }

        }
        static void Swab(ref int num1, ref int num2)
        {
            int temp = num1;
            num1 = num2;
            num2 = temp;
        }
    }

}


