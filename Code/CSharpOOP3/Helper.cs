namespace CSharpOOP3
{
    public class Helper
    {
        //The GenerateRandomColor method generates a random color from a predefined list and returns it as a string
        public static string GenerateRandomColor()
        {
            Random random = new Random();
            string[] colors = { "Red", "Blue", "Yellow", "Pink", "Purple" };
            int randomIndex = random.Next(colors.Length);
            return colors[randomIndex];
        }
        public static void PrintFlowerInfo(string name, string color, double price)
        {
            Console.WriteLine($"Flower Name is {name}");
            Console.WriteLine($"Flower Color is {color}");
            Console.WriteLine($"Flower Price is {price}");
            Console.WriteLine($"Flower Kind is {Flowers.Type}");
        }
        public static bool IsPriceExpensive(double price)
        {           
            return price > 50;
        }
        public static string CapitalizeFirstLetter(string input)
        {
            if (string.IsNullOrEmpty(input))
                return input;

            return char.ToUpper(input[0]) + input.Substring(1);
        }
    }
}
