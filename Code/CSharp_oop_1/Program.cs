using CSharp_oop_1;

Console.WriteLine("Tasks Execution!");
var homework_1 = new Homework_1();

# region Task 01
Console.WriteLine("Execution of task_01:");

Console.WriteLine("Please enter the product quantity");
double itemQuantity = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Please enter the price for one item");
double itemPrice = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Please enter the discount");
double enteredDiscount = Convert.ToDouble(Console.ReadLine());
var TotalAmount = homework_1.CalculeteTotalAmount(itemQuantity, itemPrice, enteredDiscount);
Console.WriteLine("---------------------");
Console.WriteLine($@"The total amount for {itemQuantity} items 
with price of {itemPrice} for item, 
and discount {enteredDiscount} - is {TotalAmount};");
Console.WriteLine("---------------------");
Console.WriteLine("Execution of task_01 is finished");

#endregion