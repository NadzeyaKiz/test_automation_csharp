using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCollections1
{
    public class Task_01EvenAndOddNumbers
    {
        public static void Main()
        {
            int[] array = ReadArrayFromConsole();            
            
            int[] evenArray = GetEvenNumbers(array);
            int[] oddArray = GetOddNumbers(array);

            Array.Sort(evenArray);
            Array.Sort(oddArray);

        }

        public static int[] ReadArrayFromConsole()
        {
            Console.Write("Enter the elements of the array separated by a space: ");
            string input = Console.ReadLine();
            string[] numbers = input.Split(' ');

            int[] array = new int[numbers.Length];
            for (int i = 0; i < numbers.Length; i++)
            {
                if (!int.TryParse(numbers[i], out array[i]))
                {
                    Console.WriteLine("Error! Invalid input.");
                    return new int[0];
                }
            }
            return array;
        }


        public static int[] GetEvenNumbers(int[] array)
        {
            int count = 0;
            foreach (int number in array)
            {
                if (number % 2 == 0)
                    count++;
            }

            int[] evenArray = new int[count];
            int index = 0;
            foreach (int number in array)
            {
                if (number % 2 == 0)
                    evenArray[index++] = number;
            }

            return evenArray;
        }

        public static int[] GetOddNumbers(int[] array)
        {
            int count = 0;
            foreach (int number in array)
            {
                if (number % 2 != 0)
                    count++;
            }

            int[] oddArray = new int[count];
            int index = 0;
            foreach (int number in array)
            {
                if (number % 2 != 0)
                    oddArray[index++] = number;
            }

            return oddArray;
        }

        public static void PrintArray(int[] array)
        {
            foreach (int number in array)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();
        }
        
    }
}

