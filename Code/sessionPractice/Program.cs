//Console.WriteLine("Please enter a number");
//int number = Convert.ToInt32(Console.ReadLine());

//int sum = 0;
//int tempNumber = number;

//while (tempNumber > 0)
//{
//    int digit = tempNumber % 10;// Получаем последнюю цифру числа
//    sum += digit;// Добавляем цифру к сумме
//    tempNumber = tempNumber / 10;// Убираем последнюю цифру из числа
//}
//Console.WriteLine($"The sum of number's digits {number} equals: {sum}");


//Console.Write("Please enter the first number: ");
//int number1 = Convert.ToInt32(Console.ReadLine());

//Console.Write("Please enter the secomd number: ");
//int number2 = Convert.ToInt32(Console.ReadLine());

//if (number1 == number2)
//{
//    Console.WriteLine($"The number {number1} and number {number2} are equal");
//}
//else if (number1 > number2)
//{
//    Console.WriteLine($"The first number {number1} is more then second number {number2}");
//}
//else
//{
//    Console.WriteLine($"The first number {number1} is less then second numberr {number2}");
//}


//static class Program
//{
//    static double CountDiscount(double price, double expectedDiscount)
//    {
//        double totalPrice = price - (price * expectedDiscount / 100);
//        return totalPrice;
//    }
//    static void CountDiscountWithConsole()
//    {
//        string itemName = Console.ReadLine();
//        double unitPrice = int.Parse(Console.ReadLine());
//        double discount = int.Parse(Console.ReadLine());
//        double totalPrice = unitPrice - (unitPrice* discount / 100);
//        Console.WriteLine();
//    }
//    static void Main()
//    {
//        string itemName = Console.ReadLine();
//        double unitPrice = int.Parse(Console.ReadLine());
//        double discount = int.Parse(Console.ReadLine());

//        double totalPrice = unitPrice - (unitPrice * discount / 100);

//        Console.WriteLine($"Your Item {itemName} price is {totalPrice}");
//    }
//}
static class Programm
{
    static void Main()
    {
        Console.WriteLine("Please enter the first number");
        double firstNubber = double.Parse(Console.ReadLine());

        Console.WriteLine("Please enter the first number");
        double secondNubber = double.Parse(Console.ReadLine());

        double result = new Calc().Summery(firstNubber, secondNubber);
        Console.WriteLine($"The summary of the number1 and number2 is {result}"); 

        double resultMult = new Calc().Multiplibcation(firstNubber, secondNubber);
        Console.WriteLine($"The multiplication of the number1 {firstNubber} and the number2 {secondNubber} is {resultMult}");
    }
}
public class Calc
{
    public double Summery(double number1, double number2)
    {
        
        double summ = number1 + number2;
        return summ;

    }
    public double Multiplibcation(double number1, double number2) 
    {
        double mult = number1 * number2;
        return mult;
    }
}










