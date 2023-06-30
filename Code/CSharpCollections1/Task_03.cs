using System;
using System.Collections.Generic;
using System.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;


namespace CSharpCollections1
{
    public class Task_03
    {
        public void SortSurnames(List<string>surnames)
        {
            surnames.Sort();            
        }

        public List<string> ParseSurnames(string input)
        {
            string[] stringSurnames = input.Split(';');
            List<string> surnames = new List<string>();

            surnames = surnames.ToList();
            for (int i = 0; i < surnames.Count; i++)
            {
                surnames.Add(input);
            }
            return surnames;
        }

public void PrintSurnames(List<string> surnames)
        {
            foreach (string surname in surnames)
            {
                Console.WriteLine(surname);
            }
        }
    }
}
