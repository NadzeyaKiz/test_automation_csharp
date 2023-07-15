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
        public static bool IsPriceExpensive(this Flower flower)
        {
            return flower.Price > 50;
        }
        public static string CapitalizeFirstLetterFlower(this Flower flower)
        {
            if (string.IsNullOrEmpty(flower.Name))
                return flower.Name;

            return char.ToUpper(flower.Name[0]) + flower.Name.Substring(1);
        }
        public static bool IsColorValid(this Flower flower)
        {
            string[] validColors = { "Red", "Blue", "Yellow", "Pink", "Purple" };
            return validColors.Contains(flower.Color);
        }
    }
}
