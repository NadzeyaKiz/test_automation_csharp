using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAdvanced
{
    public static class FlowerExtensions
    {       
        public static string GenerateRandomColor(this Flower flower)
        {
            Random random = new Random();
            string[] colors = { "Red", "Blue", "Yellow", "Pink", "Purple" };
            int randomIndex = random.Next(colors.Length);
            return colors[randomIndex];
        }
        public static void PrintFlowerInfo(this Flower flower)
        {
            Console.WriteLine($"Flower Name is {flower.Name}");
            Console.WriteLine($"Flower Color is {flower.Color}");
            Console.WriteLine($"Flower Price is {flower.Price}");
            Console.WriteLine($"Flower Kind is {flower.GetType().Name}");
        }
        public static bool IsPriceExpensive(this double price)
        {
            return price > 50;
        }
        public static string CapitalizeFirstLetterFlower(this string input)
        {
            if (string.IsNullOrEmpty(input))
                return input;

            return char.ToUpper(input[0]) + input.Substring(1);
        }
        public static bool IsColorValid(this Flower flower)
        {
            string[] validColors = { "Red", "Blue", "Yellow", "Pink", "Purple" };
            return validColors.Contains(flower.Color);
        }
    }
}
