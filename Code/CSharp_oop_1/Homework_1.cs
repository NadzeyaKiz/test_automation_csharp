using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_oop_1
{
    internal class Homework_1
    {
        public double CalculeteTotalAmount(double itemQuantity, double itemPrice, double enteredDiscount)
        {
            double totalWithoutDiscount = itemQuantity * itemPrice;
            double discountAmount = totalWithoutDiscount*enteredDiscount/100;
            double TotalAmount = totalWithoutDiscount - discountAmount;
            return TotalAmount;           
        }
    }
}
