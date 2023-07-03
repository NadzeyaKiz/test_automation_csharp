using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCollections1
{
    public class Task_01
    {          
        public void SortArray(int[] array) 
        {
            Array.Sort(array);            
        }
        
        public int[] ParseArray(string input)
        {         
            string[] numbers = input.Split(' ');

            int[] array = new int[numbers.Length];
            for (int i = 0; i < numbers.Length; i++)
            {
                if (!int.TryParse(numbers[i], out array[i]))
                {
                    Console.WriteLine($"Error! Invalid input: {input}");
                    return new int[0];
                }
            }
            return array;
        }

        public int[] GetEvenOrOddNumbers(int[] array, bool isEven)
        {
            List<int> numbers = new List<int>();
            foreach (int number in array)
            {
                // even numbers
                if (isEven && number % 2 == 0)
                    numbers.Add(number);
                // odd numbers
                else if (!isEven && number % 2 != 0)
                    numbers.Add(number);
            }
            return numbers.ToArray();
        }

        public void PrintArray(int[] array)
        {
            foreach (int number in array)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();
        }        
    }
}

