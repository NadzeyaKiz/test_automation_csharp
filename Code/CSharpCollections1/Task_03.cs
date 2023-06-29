using System;
using System.Collections.Generic;
using System.Linq;


namespace CSharpCollections1
{
    public class Task_03
    {
        static void Main()
        {
            List<string> surnames = ReadSurnamesFromConsole();

            surnames.Sort();

            Console.WriteLine("Sorted list of last names:");
            PrintSurnames(surnames);
        }

        static List<string> ReadSurnamesFromConsole()
        {
            List<string> surnames = new List<string>();

            Console.WriteLine("Enter surnames (enter an empty string to complete the entry):");
            while (true)
            {
                string input = Console.ReadLine().Trim();
                if (string.IsNullOrEmpty(input))
                    break;

                surnames.Add(input);
            }
            return surnames;
        }

        public static void PrintSurnames(List<string> surnames)
        {
            foreach (string surname in surnames)
            {
                Console.WriteLine(surname);
            }
        }

    }
}
