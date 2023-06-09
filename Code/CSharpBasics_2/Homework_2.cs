using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasics_2
{
    class Homework_2
    {
        public void Task_01()
        {
            Console.WriteLine("Please enter an integer");
            int  variable_1 = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Please enter a double");
            double variable_2 = Convert.ToDouble(Console.ReadLine());
            
            Console.WriteLine("Please enter a boolen");
            bool variable_3 = Convert.ToBoolean(Console.ReadLine());
            
            Console.WriteLine("Please enter a byte");
            byte variable_4 = Convert.ToByte(Console.ReadLine());

            Console.WriteLine("--------------------");
            Console.WriteLine($"Entered integer is {variable_1}\nEntered double is {variable_2}\nEntered bool is {variable_3}\nEntered byte is {variable_4}");
            Console.WriteLine("--------------------");
        }
        public void Task_02() 
        {
            Console.WriteLine("Please enter an integer");
            int variable_1 = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Please enter a double");
            double variable_2 = double.Parse(Console.ReadLine());

            Console.WriteLine("--------------------");
            Console.WriteLine($"Entered integer is {variable_1}\nEntered double is {variable_2}");
            Console.WriteLine("--------------------");

        }
        public void Task_03() 
        {
            Console.WriteLine("Please enter an integer");
            string enteredNumber = Console.ReadLine();

            Console.WriteLine("--------------------");
            
            int number;            
            if (int.TryParse(enteredNumber, out number))
            {
                Console.WriteLine($"Parsed entered number is {number}");
            }
            else
            {
                Console.WriteLine($"Failed to parse value '{enteredNumber}' to integer");

            }
            Console.WriteLine("--------------------");

        }
        public void Task_04() 
        {
            int variable1 = 65;
            int variable2 = variable1 + 3;
            int variable3 = variable1 + variable2;
            Console.WriteLine("--------------------");
            Console.WriteLine($"Entered number is {variable1}\nThe first variable increased by 3 is {variable2}\nThe sum of the first two variablesvariables is {variable3}");
            Console.WriteLine("--------------------");

        }
        public void Task_05()
        {
            Console.WriteLine("Please enter 1st item name");
            var item1 = Console.ReadLine();
            Console.WriteLine("Please enter 1st item price");
            var price1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please enter 1st item number of items");
            var count1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Please enter 2nd item name");
            var item2 = Console.ReadLine();
            Console.WriteLine("Please enter 2nd item price");
            var price2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please enter 2nd item number of items");
            var count2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Please enter 3rd item name");
            var item3 = Console.ReadLine();
            Console.WriteLine("Please enter 3rd item price");
            var price3 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please enter 3rd item number of items");
            var count3 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Please enter 4th item name");
            var item4 = Console.ReadLine();
            Console.WriteLine("Please enter 4th item price");
            var price4 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please enter 4th item number of items");
            var count4 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Please enter 5th item name");
            var item5 = Console.ReadLine();
            Console.WriteLine("Please enter 5th item price");
            var price5 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please enter 5th item number of items");
            var count5 = Convert.ToDouble(Console.ReadLine());


            var toPayForItem1 = price1 * count1;
            var toPayForItem2 = price2 * count2;
            var toPayForItem3 = price3 * count3;
            var toPayForItem4 = price4 * count4;
            var toPayForItem5 = price5 * count5;
            var receiptTotal = toPayForItem1 + toPayForItem2 + toPayForItem3 + toPayForItem4 + toPayForItem5;
            var discountTotal = Math.Round((receiptTotal * 15 / 100), 2);
            var toPay = receiptTotal - discountTotal;

            Console.WriteLine($"---------------------------------------------------");
            Console.WriteLine("{0, -20}{1, 10}{2, 15}{3, 15}", "Name", "Price", "ItemCount", "SubTotalItem");
            Console.WriteLine($"{item1, -20}{price1, 10}{count1, 15}{toPayForItem1, 15}");
            Console.WriteLine($"{item2, -20}{price2, 10}{count2, 15}{toPayForItem2, 15}");
            Console.WriteLine($"{item3, -20}{price3, 10}{count3, 15}{toPayForItem3, 15}");
            Console.WriteLine($"{item4, -20}{price4, 10}{count4, 15}{toPayForItem4, 15}");
            Console.WriteLine($"{item5, -20}{price5, 10}{count5, 15}{toPayForItem5, 15}");
            
            Console.WriteLine($@"You got the discount of {discountTotal}");
            Console.WriteLine($@"The amount to pay is {toPay}");
            Console.WriteLine($"---------------------------------------------------");

        }
        public void Task_06()
        {
            double a = 5;
            double b = 3;
            double expression1 = a + 3 * b - a / 5;

            //prefix increment
            double prefIncrExpression = ++a + 3 * b - a / 5;
            // ++a increments the value of a by 1, so a becomes 6.
            //3 * b multiplies the value of b (which is 3) by 3, resulting in 9.
            //a / 5 divides the updated value of a (which is 6) by 5, resulting in 1.2.
            //(++a) + (3 * b) adds the updated value of a (which is 6) to the result of step 2, which gives 15.
            //Finally, subtracting the result of step 3 (1.2) from the result of step 4 (15) gives a final value of 13.8.
            //So, the value of expression2 would be 13.8.
            Console.WriteLine($@"The result  of the '++a + 3 * b - a / 5' expression with prefix increment '++a' is {prefIncrExpression} (Expected result 13.8)");

            a = 5;
            //postfix increment          
            double postIncrExpression = a++ + 3 * b - a / 5;
            //a++ uses the value of a (which is 5).
            //3 * b multiplies the value of b(which is 3) by 3, resulting in 9.
            //a / 5 divides the value of a(which is 5+1) by 5, resulting in 1.2.
            //a++ + (3 * b) adds the initial value of a(which is 5) to the result of step 2, giving 14.
            //Finally, subtracting the result of step 3(1.2) from the result of step 4(14) gives a final value of 12.8.
            Console.WriteLine($@"The result  of the 'a++ + 3 * b - a / 5' expression with postfix increment 'a++' is {postIncrExpression} (Expected tesult 12.8)");
            
            a = 5;
            //prefix decrement
            double prefDecrExpression = --a + 3 * b - a / 5;
            //--a decrements the value of a by 1 before any other operation is performed. So, a becomes 4.
            //3 * b multiplies the value of b(which is 3) by 3, resulting in 9.
            //a / 5 divides the updated value of a(which is 4) by 5, resulting in 0.8.
            //--a + (3 * b) adds the updated value of a(which is 4) to the result of step 2, giving 13.
            //Finally, subtracting the result of step 3(0.8) from the result of step 4(13) gives a final value of 12.2.
            Console.WriteLine($@"The result  of the '--a + 3 * b - a / 5' expression with prefix decrement '--a' is {prefDecrExpression} (Expected result 12.2)");

            a = 5;
            //postfix decrement
            double postDecrExpression = a-- + 3 * b - a / 5;
            //a-- uses the value of a (which is 5) and then decrements a by 1.
            //3 * b multiplies the value of b(which is 3) by 3, resulting in 9.
            //a / 5 divides the value of a(which is 5-1) by 5, resulting in 0.8.
            //a-- + (3 * b) adds the initial value of a(which is 5) to the result of step 2, giving 14.
            //Finally, subtracting the result of step 3(1) from the result of step 4(14) gives a final value of 13.2.
            //Therefore, the value of prefDecrExpression would be 13
            Console.WriteLine($@"The result  of the 'a-- + 3 * b - a / 5;' expression with prefix decrement 'a--' is {postDecrExpression} (Expected result 13.2)");


        }
        public void Task_07()
        {
            int a = 12;
            int b = 12;
            bool areEqual = a == b;
            Console.WriteLine($@"The result of 'a == b' (were a=12, b=12) is {areEqual}");
            int a1 = 10;
            int b1 = 8;
            bool areNotEqual = a1 == b1;
            Console.WriteLine($@"The result of 'a == b' (were a1=10, b1=8) is {areNotEqual}");


            Console.WriteLine("---------------");


            bool and1 = true;
            bool and2 = true;
            bool and3 = true;
            bool and5 = false;
            bool and4 = and1 && and2 == and3;
            bool and6 = and1 && and5 == and3;
            Console.WriteLine($@"The result of 'and1 && and2 == and3' (were and1=true, and2=true, and3 = true) is {and4}");
            Console.WriteLine($@"The result of 'and1 && and5 == and3' (were and1=true, and2=true, and5 = false) is {and6}");


            Console.WriteLine("---------------");


            bool or1 = false;
            bool or2 = true;
            bool or3 = false;
            bool or4 = false;
            bool or5 = (or1 || or2) != or3;
            bool or6 = (or1 || or4) != or3;
            Console.WriteLine($@"The result of 'or5 = (or1 || or2) != or3' (were or1=false, or2=true, or3 = false) is {or5}");
            Console.WriteLine($@"The result of 'or6 = (or1 || or4) != or3' (were or1=false, or3=false, or4 = false) is {or6}");


            Console.WriteLine("---------------");


            int notEqual1 = 32;
            int notEqual2 = 30;
            int notEqual3 = 32;
            bool notEqual4 = notEqual1 != notEqual2;
            bool notEqual5 = notEqual1 != notEqual3;
            Console.WriteLine($@"The result of 'notEqual4 = notEqual1 != notEqual2' (were notEqual1 = 32, notEqual2 = 30) is {notEqual4}");
            Console.WriteLine($@"The result of 'notEqual5 = notEqual1 != notEqual3' (were notEqual1 = 32, notEqual3 = 32) is {notEqual5}");


            Console.WriteLine("---------------");


            int comper1 = 4;
            int comper2 = 4;
            int comper3 = 2;
            bool comper4 = comper1 <= comper2;
            bool comper5 = comper1 <= comper3;
            Console.WriteLine($@"The result of ' comper4 = comper1 <= comper2' (comper1 = 4, comper2 = 4) is {comper4}");
            Console.WriteLine($@"The result of ' comper5 = comper1 <= comper3' (comper1 = 4, comper3 = 2) is {comper5}");


        }
        public void Task_08()
        {
            //The operation of boxing an integer 'number' variable that is assigned to the object 'boxedNumber'.
            int number = 123456789;
            // The following line boxes a.
            object boxedNumber = number;

            //Then I unbox the object 'boxedNumber' and assign it to the integer variable unboxedNumber.
            int unboxedNumber = (int)boxedNumber;  // unboxing

        }
        public void Task_09()
        {
            //Implicit Conversion:
            int number1 = 42;       // Declaring and assigning an int value
            double number2 = number1; // Implicit conversion: int to double


            //Explicit Conversion:
            double number3 = 3.14;  // Declaring and assigning a double value
            int number4 = (int)number3; // Explicit conversion: double to int
        }

    }
}
