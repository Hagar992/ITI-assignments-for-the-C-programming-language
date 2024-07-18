using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2_iti_
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("(Q.1)_______________________________________");
            Console.ForegroundColor = ConsoleColor.White;
            byte sum = 0;

            while (true)
            {
                Console.Write("Enter a byte value (0-255): ");
                string input = Console.ReadLine();

                try
                {
                    byte value = byte.Parse(input);

                    checked
                    {
                        sum += value;
                    }

                    Console.WriteLine($"Current sum: {sum}");
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Overflow occurred! The sum has exceeded the byte limit.");
                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid input. Please enter a valid byte value.");
                }
                //يستخدم فى النهاية بحيث لو حصل اي خطا غير الى انا عملاه يعرفنى
                catch (Exception ex)
                {
                    Console.WriteLine($"An unexpected error occurred: {ex.Message}");
                }
            }

            Console.WriteLine("Program has ended due to overflow.");
            //. يتم استخدام هذا النوع من الكود لإعلام البرنامج بوجود خطأ أو حالة غير متوقعة
            //هو مثال على إثارة (throwing) استثناء يدويًا في كود C#.
            // throw new Exception();


            //_____________________________________________________________________________________________________________________
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("(Q.2)_______________________________________");
            Console.ForegroundColor = ConsoleColor.White;

            int[] array = new int[10];


            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"Enter value for element {i + 1}: ");
                array[i] = int.Parse(Console.ReadLine());
            }

            Console.Write("Original array >>");
            PrintArray(array);


            FindMinMax(array, out int minValue, out int maxValue);
            Console.WriteLine($"Minimum value: {minValue}\n");
            Console.WriteLine($"Maximum value: {maxValue}\n");


            SortArray(array);
            Console.Write("Array elements after sorting >>");
            PrintArray(array);


            Console.Write("Enter a number to search for: ");
            int searchValue = int.Parse(Console.ReadLine());
            int index = SearchArray(array, searchValue);
            if (index != -1)
            {
                Console.WriteLine($"Value {searchValue} found at index {index}.");
            }
            else
            {
                Console.WriteLine($"Value {searchValue} not found in the array.");
            }
        }

        static void PrintArray(int[] array)
        {
            Console.WriteLine("Array elements:");
            foreach (int value in array)
            {
                Console.Write(value + " ");
            }
            Console.WriteLine("\n");
        }

        static void FindMinMax(int[] array, out int minValue, out int maxValue)
        {
            minValue = array[0];
            maxValue = array[0];

            foreach (int value in array)
            {
                if (value < minValue)
                {
                    minValue = value;
                }
                if (value > maxValue)
                {
                    maxValue = value;
                }
            }
        }

        static void SortArray(int[] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = 0; j < array.Length - 1 - i; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        int temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }
        }

        static int SearchArray(int[] array, int searchValue)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == searchValue)
                {
                    return i;
                }
            }
            return -1;

        }



    }

}

