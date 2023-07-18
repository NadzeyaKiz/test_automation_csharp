using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAdvanced
{
    public class FlowerHelper
    {
        public static List<T> CreateFlowerList<T>(int quantity) where T : Flower, new()
        {
            List<T> flowers = new List<T>();
            for (int i = 0; i < quantity; i++)
            {
                flowers.Add(new T());
            }
            return flowers;
        }

        public static double CalculateTotalCost<T>(List<T> flowers) where T : Flower
        {
            double totalCost = 0;
            foreach (T flower in flowers)
            {
                totalCost += flower.Price;
            }
            return totalCost;
        }
        public static void PrintReceipt<T>(List<T> flowers) where T : Flower
        {
            foreach (T flower in flowers)
            {
                Console.WriteLine(flower.ToString());
            }
        }
    }
}
