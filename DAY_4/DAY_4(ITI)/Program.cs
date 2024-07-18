using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAY_4_ITI_
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
                Swab(array, index1, index2);
                Console.WriteLine("Array after swapping:");
                for (int i = 0; i < array.Length; i++)
                {
                    Console.Write($"Element({i}) = {array[i]} ");
                }
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Invalid indices. Please enter valid indices within the array bounds.");
            }
        }

        static void Swab(int[] arr, int index1, int index2)
        {
            int temp = arr[index1];
            arr[index1] = arr[index2];
            arr[index2] = temp;
        }
    }
}
