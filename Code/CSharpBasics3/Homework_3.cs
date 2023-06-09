using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CSharpBasics_3
{
    class Homework_3
    {
        public void Task_01()
        {
            Console.WriteLine("Please enter an integer");
            var enteredNumber = Console.ReadLine();
            int number = Convert.ToInt32(enteredNumber);

            Console.WriteLine("--------------------");

            if (number % 2 == 0 && number % 5 == 0)
            {
                Console.WriteLine("The number is divisible by 2 and 5: 'Tutti-Frutti'");
            }

            else if (number % 2 == 0)
            {
                Console.WriteLine($"The number {enteredNumber} is divisible by 2: 'Tutti'");
            }
            else if (number % 5 == 0)
            {
                Console.WriteLine($"The number {enteredNumber} is divisible by 5: 'Frutti'");
            }
            else
            {
                Console.WriteLine($"The number '{enteredNumber}' is not divisible by 2 or 5");
            }

            Console.WriteLine("--------------------");

        }
        public void Task_02()
        {
            Console.WriteLine("Please enter smaller number 1");
            var smallerNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter bigger number 2");
            var biggerNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("--------------------");

            for (int current = smallerNumber; current <= biggerNumber; current++)
            {
                if (current % 2 == 0 && current % 5 == 0)
                {
                    Console.WriteLine("'Tutti-Frutti'");
                }

                else if (current % 2 == 0)
                {
                    Console.WriteLine("'Tutti'");
                }
                else if (current % 5 == 0)
                {
                    Console.WriteLine("'Frutti'");
                }
                else
                {
                    Console.WriteLine($"Number {current} can’t be divided on 2 or 5");
                }
            }

            Console.WriteLine("--------------------");
        }
        public void Task_03()
        {
            Console.WriteLine("Please enter the first number");
            var number1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter the second number");
            var number2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("--------------------");

            if (number1 > number2)
            {
                Console.WriteLine($"The first number {number1} is greater than the second number {number2}");
                Task_03_1(number2, number1);

            }
            else if (number1 < number2)
            {
                Console.WriteLine($"The second number {number2} is geater than the first number {number1}");
                Task_03_1(number1, number2);


            }
            else
            {
                Console.WriteLine($"The first number {number1} and the second number {number2} are equal");
            }

            Console.WriteLine("--------------------");


        }

        private void Task_03_1(int number1, int number2)
        {

            for (int current = number1; current <= number2; current++)
            {
                if (current % 2 == 0 && current % 5 == 0)
                {
                    Console.WriteLine("'Tutti-Frutti'");
                }

                else if (current % 2 == 0)
                {
                    Console.WriteLine("'Tutti'");
                }
                else if (current % 5 == 0)
                {
                    Console.WriteLine("'Frutti'");
                }
                else
                {
                    Console.WriteLine($"Number {current} can’t be divided on 2 or 5");
                }
            }
        }
    }
}

    

