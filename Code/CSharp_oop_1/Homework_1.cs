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
            double totalWithoutDiscount = itemQuantity * itemPrice;
            double discountAmount = Math.Round((totalWithoutDiscount*enteredDiscount/100), 2);
            double TotalAmount = totalWithoutDiscount - discountAmount;
            return TotalAmount;           
        }
        public double CalculeteTotalAmountForEachItemAndReceiptTotal(double[] toPayForItems)                    
        {
            double receiptTotal = 0;
            for (int i = 0; i < toPayForItems.Length; i++)
                receiptTotal += toPayForItems[i];   
            
            return receiptTotal;
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
    }
}
