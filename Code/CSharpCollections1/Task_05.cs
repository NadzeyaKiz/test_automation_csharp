using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCollections1
{
    internal class Task_05
    {        
        public Dictionary<string, string> ParseDictionary()
        {
            Dictionary<string, string> dictionary = new Dictionary<string, string>();
            
            for (int i = 1; i <= 5; i++)
            {
                Console.Write($"Pair {i}: ");
                string input = Console.ReadLine();
                string[] pair = input.Split(':');

                if (pair.Length == 2)
                {
                    string country = pair[0].Trim();
                    string capital = pair[1].Trim();

                    dictionary[country] = capital;
                }
            }

            return dictionary;
        }

        public Dictionary<string, string> ReverseDictionary(Dictionary<string, string> originalDictionary)
        {
            Dictionary<string, string> reversedDictionary = new Dictionary<string, string>();

            foreach (KeyValuePair<string, string> pair in originalDictionary)
            {
                string country = pair.Key;
                string capital = pair.Value;

                reversedDictionary[capital] = country;
            }

            return reversedDictionary;
        }

        public void PrintDictionary(Dictionary<string, string> dictionary, bool isReverse)
        {
            string country;
            string capital;

            foreach (KeyValuePair<string, string> pair in dictionary)
            {
                if (!isReverse)
                {
                    country = pair.Key;
                    capital = pair.Value;
                    Console.WriteLine($"Country: {country}, Capital: {capital}");
                }
                else
                {
                    country = pair.Value;
                    capital = pair.Key;
                    Console.WriteLine($"Capital: {capital}, Country: {country}");
                }
            }
        }
    }
}


