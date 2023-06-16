using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_oop_1
{
    internal class Homework_1
    {
        public double CalculateTotalAmount(double itemQuantity, double itemPrice, double enteredDiscount)
        {
            double totalWithoutDiscount = Math.Round((itemQuantity * itemPrice), 2);
            double discountAmount = Math.Round((totalWithoutDiscount*enteredDiscount/100), 2);
            double TotalAmount = totalWithoutDiscount - discountAmount;
            return TotalAmount;           
        }

        public double CalculateTotalAmountOptional(double itemQuantity, double itemPrice, double enteredDiscount = 0)
        {
            double totalWithoutDiscount = Math.Round((itemQuantity * itemPrice), 2);
            double discountAmount = Math.Round((totalWithoutDiscount * enteredDiscount / 100), 2);
            double TotalAmount = totalWithoutDiscount - discountAmount;
            return TotalAmount;
        }


        public double CalculeteTotalAmountForEachItemAndReceiptTotal(double[] toPayForItems)                    
        {
            double receiptTotal = 0;
            for (int i = 0; i < toPayForItems.Length; i++)
                receiptTotal += toPayForItems[i];               
            return Math.Round((receiptTotal), 2);
        }

        public void PrintReceipt(string[] itemNames, double[] itemPricies, double[] itemQuantities, double[] toPayForItems)
        {          
            Console.WriteLine($"---------------------------------------------------");
            Console.WriteLine("{0, -20}{1, 10}{2, 15}{3, 15}", "Name", "Price", "ItemCount", "SubTotalItem");

            for ( int i = 0; i < itemNames.Length; i++ )
                Console.WriteLine($"{itemNames[i],-20}{itemPricies[i],10}{itemQuantities[i],15}{toPayForItems[i],15}");

            var receiptTotal = CalculeteTotalAmountForEachItemAndReceiptTotal(toPayForItems);

            Console.WriteLine($@"The amount to pay is {receiptTotal}");
            Console.WriteLine($"---------------------------------------------------");
        }

        public double CalculatePerimeter(params double[] sides)
        {
            double perimeter = 0;
            foreach (double side in sides)
            {
                perimeter += side;
            }
            return perimeter;
        }
        public double CalculateArea(double baseLength, double height)
        {
            return 0.5 * baseLength * height;
        }

        public double CalculateArea(double radius)
        {
            return Math.PI * Math.Pow(radius, 2);
        }
    }
}
