using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CSharpLINQ
{
    public class Homework
    {
        public void Task_01()
        {
            List<int> numbers = new List<int> { 27, 14, 8, 43, 19, 56, 32, 9, 65, 21 };
            var divisibleByThree = numbers.Where(number => number % 3 == 0).ToList();
            Console.WriteLine($"The numbers from the list: {string.Join(", ", numbers)}\nthat are divisible by 3 are:  {string.Join(", ", divisibleByThree)}");
        }
        public void Task_02()
        {
            List<int> numbers = new List<int> { 7, -8, -9, 9, 10, -11, -7, 12, -13, 14 };
            var negativeAndLessThanTen = numbers.Where(number => number < 10).ToList();
            Console.WriteLine($"The numbers from the list: {string.Join(", ", numbers)} \nthat are negative and less than 10 are: {string.Join(", ", negativeAndLessThanTen)}");
        }
        public void Task_03()
        {
            List<string> fruts = new List<string> { "apple", "orange", "pear", "banana", "peach" };
            var filteredAndSortedfruts = fruts.Where(frut => frut.Length % 2 == 0).OrderBy(frut => frut).ToList();
            Console.WriteLine($"The filtered and sorted fruts from the list: {string.Join(", ", fruts)}\nare: {string.Join(", ", filteredAndSortedfruts)}");
        }
        public void Task_04()
        {
            List<string> cities = new List<string> { "London", "Manchester", "Madrid", "Osaka", "Mazyr" };
            string startLetter = "M";
            string endLetter = "r";
            var filteredCities = cities.Where(city => city.StartsWith(startLetter, StringComparison.CurrentCultureIgnoreCase) &&
            city.EndsWith(endLetter, StringComparison.CurrentCultureIgnoreCase));
            Console.WriteLine($"The cities from the list: {string.Join(", ", cities)}\nwich starts with {startLetter} and ends with {endLetter} are: {string.Join(", ", filteredCities)}");
        }
        public void Task_05()
        {                      
            string inputString = Console.ReadLine();
            string[] words = inputString.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            var uppercaseWords = words.Where(word => word.All(char.IsUpper));
            Console.WriteLine($"The words from the list: {string.Join(", ", words)}\nin uppercase are {string.Join(", ", uppercaseWords)}");
        }
        public void Task_06()
        {
            List<int> numbers = new List<int> { 15, 17, 18, 15, 20, 18, 23, 27, 20, 23 };
            var distincedNumbers = numbers.Distinct().Reverse().ToList();
            Console.WriteLine($"The collection with removed duplicates from the collection {string.Join(", ", numbers)} \nin descending order is {string.Join(", ", distincedNumbers)}");
        }
        public void Task_07()
        {
            List<int> numbers = new List<int> { 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 };
            int enteredNumber = Convert.ToInt32(Console.ReadLine());
            bool numberExists = numbers.Contains(enteredNumber);

            if (numberExists)
            {
                Console.WriteLine($"The entered number is presented in the collection {string.Join(", ", numbers)}.");
            }
            else
            {
                Console.WriteLine($"The entered number is not presented in the collection {string.Join(", ", numbers)}.");
            }
        }
        public void Task_08()
        {
            List<string> poemWords = new List<string> { "how", "doth", "the", "little", "crocodile", "improve", "his", "shining", "tail" };
            int totalLength = poemWords.Sum(p => p.Length);
            Console.WriteLine($"The sum of the lengths of all elements of the collection {totalLength}");
            if (totalLength > 5)
            {
                Console.WriteLine("Первый элемент: " + poemWords.First());
                Console.WriteLine("Последний элемент: " + poemWords.Last());
            }
        }
        public void Task_09()
        {

        }
        public void Task_10()
        {

        }
    }
}
