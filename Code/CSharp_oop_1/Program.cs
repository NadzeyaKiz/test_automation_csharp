﻿using CSharp_oop_1;

Console.WriteLine("Tasks Execution!");
var homework_1 = new Homework_1();

# region Task 01
//Console.WriteLine("Execution of task_01:");
//Console.WriteLine("Please enter the product quantity");
//double itemQuantity = Convert.ToDouble(Console.ReadLine());
//Console.WriteLine("Please enter the price for one item");
//double itemPrice = Convert.ToDouble(Console.ReadLine());
//Console.WriteLine("Please enter the discount");
//double enteredDiscount = Convert.ToDouble(Console.ReadLine());
//var TotalAmount = homework_1.CalculateTotalAmount(itemQuantity, itemPrice, enteredDiscount);
//Console.WriteLine("---------------------");
//Console.WriteLine($@"The total amount for {itemQuantity} items 
//with price of {itemPrice} for item, 
//and discount {enteredDiscount} - is {TotalAmount};");
//Console.WriteLine("---------------------");
//Console.WriteLine("Execution of task_01 is finished");
#endregion

#region Task 02
Console.WriteLine("Execution of task_02:");

Console.WriteLine("Please enter how many items do you have in your basket:");
int numberOfItems = Convert.ToInt32(Console.ReadLine());

string[] itemNames = new string[numberOfItems];
double[] itemPricies = new double[numberOfItems];
double[] itemQuantities = new double[numberOfItems];
for (int i = 0; i < numberOfItems; i++)
{
    Console.WriteLine($"Please enter {i} item name");
    itemNames[i] = Console.ReadLine();
    Console.WriteLine($"Please enter {i} item price");
    itemPricies[i] = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine($"Please enter {i} item number of items");
    itemQuantities[i] = Convert.ToDouble(Console.ReadLine());
}

Console.WriteLine("Please enter the discount:");
double enteredDiscount = Convert.ToDouble(Console.ReadLine());

double[] toPayForItems = new double[numberOfItems];
for (int i = 0; i < numberOfItems; i++)
{
    toPayForItems[i] = homework_1.CalculateTotalAmount(itemQuantities[i], itemPricies[i], enteredDiscount);
}


homework_1.PrintReceipt(itemNames, itemPricies, itemQuantities, toPayForItems);



#endregion