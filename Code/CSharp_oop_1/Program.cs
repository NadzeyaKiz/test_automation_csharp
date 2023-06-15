using CSharp_oop_1;
using System.Transactions;

Console.WriteLine("Tasks Execution!");
var homework_1 = new Homework_1();

# region Task 01
//Console.WriteLine("Execution of task_01:");
//
//Console.WriteLine("Please enter the product quantity");
//double itemQuantity = Convert.ToDouble(Console.ReadLine());
//Console.WriteLine("Please enter the price for one item");
//double itemPrice = Convert.ToDouble(Console.ReadLine());
//Console.WriteLine("Please enter the discount");
//double enteredDiscount = Convert.ToDouble(Console.ReadLine());
//
//var TotalAmount = homework_1.CalculateTotalAmount(itemQuantity, itemPrice, enteredDiscount);
//Console.WriteLine("---------------------");
//Console.WriteLine($@"The total amount for {itemQuantity} items with price of {itemPrice} for item, and discount {enteredDiscount} - is {TotalAmount};");
//Console.WriteLine("---------------------");
//Console.WriteLine("Execution of task_01 is finished");
#endregion

#region Task 02 and 03
//Console.WriteLine("Execution of task_02 and task_03:");
//string questionAnswer;
//int numberOfItems;

//Console.WriteLine($"Would you like to enter the number of items in your basket? (y/n)");
//questionAnswer = Console.ReadLine();

//if (questionAnswer.ToLower() == "y")       //Required parameter (number of items) provided
//{
//    Console.WriteLine("Please enter how many items do you have in your basket:");
//    numberOfItems = Convert.ToInt32(Console.ReadLine());
//}
//else                                      // Optional parameter (number of items) provided
//{
//    Console.WriteLine("Defolt number of items in your basket is 3");
//    numberOfItems = 3;
//}

//string[] itemNames = new string[numberOfItems];
//double[] itemPricies = new double[numberOfItems];
//double[] itemQuantities = new double[numberOfItems];

//for (int i = 0; i < numberOfItems; i++)
//{
//    Console.WriteLine($"Please enter {i} item name");
//    itemNames[i] = Console.ReadLine();
//    Console.WriteLine($"Please enter {i} item price");
//    itemPricies[i] = Convert.ToDouble(Console.ReadLine());
//    Console.WriteLine($"Please enter {i} item number of items");
//    itemQuantities[i] = Convert.ToDouble(Console.ReadLine());
//}

//Console.WriteLine("Please enter the discount:");
//double enteredDiscount = Convert.ToDouble(Console.ReadLine());

//double[] toPayForItems = new double[numberOfItems];
//for (int i = 0; i < numberOfItems; i++)
//{
//    toPayForItems[i] = Math.Round(homework_1.CalculateTotalAmount(itemQuantities[i], itemPricies[i], enteredDiscount), 2);
//}

//homework_1.PrintReceipt(itemNames, itemPricies, itemQuantities, toPayForItems);
#endregion

#region Task 04
//Console.WriteLine("Please enter five sides of the shape:");
//double[] enteredSides = new double[5];
//for (int i = 0; i < 5; i++)
//{
//    enteredSides[i] = Convert.ToDouble(Console.ReadLine());
//}
//Random random = new Random();
//for (int i = 0; i < enteredSides.Length; i++)
//{
//    int randomIndex = random.Next(enteredSides.Length);
//    double temp = enteredSides[i];
//    enteredSides[i] = enteredSides[randomIndex];
//    enteredSides[randomIndex] = temp;
//}

//Console.WriteLine("____________________________");    
//double trianglePerimeter = homework_1.CalculatePerimeter(enteredSides[0], enteredSides[1], enteredSides[2]);
//Console.WriteLine($"The values {enteredSides[0]}, {enteredSides[1]}, {enteredSides[2]} where choosen for triange perimeter");
//Console.WriteLine($"Triangle's perimeter: {trianglePerimeter}");

//double quadrilateralPerimeter = homework_1.CalculatePerimeter(enteredSides[0], enteredSides[1], enteredSides[2], enteredSides[3]);
//Console.WriteLine($"The values {enteredSides[0]}, {enteredSides[1]}, {enteredSides[2]}, {enteredSides[3]} where choosen for quadrilateral perimeter");
//Console.WriteLine($"Quadrilateral's perimeter: {quadrilateralPerimeter}");

//double pentagonPerimeter = homework_1.CalculatePerimeter(enteredSides[0], enteredSides[1], enteredSides[2], enteredSides[3], enteredSides[4]);
//Console.WriteLine($"The values {enteredSides[0]}, {enteredSides[1]}, {enteredSides[2]}, {enteredSides[3]}, {enteredSides[4]} where choosen for pentagon perimeter");
//Console.WriteLine($"Quadrilateral's perimeter: {pentagonPerimeter}");
//Console.WriteLine("____________________________");
#endregion

#region Task 05
//// Calculation of the triangle area
//Console.WriteLine("Please enter the lenght of the triangle base:");
//double triangleBase = Convert.ToDouble(Console.ReadLine());
//Console.WriteLine("Please enter the lenght of the triangle height:");
//double triangleHeight = Convert.ToDouble(Console.ReadLine());

//double triangleArea = homework_1.CalculateArea(triangleBase, triangleHeight);
//Console.WriteLine($"The area of the triangle is: {triangleArea}");

////Calculation of the circle area
//Console.WriteLine("Please enter the radius of the circle:");
//double radius = Convert.ToDouble(Console.ReadLine());

//double circleArea = homework_1.CalculateArea(radius);
//Console.WriteLine($"The area of the circle is: {circleArea}");
#endregion

#region Task 06
/*
 * Here are real life examples that illustrate the four principles of OOP: inheritance, encapsulation, polymorphism, and abstraction.
1. Inheritance: production of refrigerators. Different models of refrigerators can have a common parent class "Refrigerator", which 
contains common functionality and characteristics, such as compressor, evaporator, condenser. In addition, each refrigerator model 
can have its own unique characteristics and behavior.
2. Encapsulation: bank account. When you open a bank account, you get access to certain  functions and products (deposit, withdrawal, 
balance check, etc.). However, the internal details of how a bank account works, such as the calculation logic and saving data, are 
hidden from you. Instead, you interact with the bank account through a  GUI provided by the bank.This provides secure access to the 
functionality of the account while keeping its internal implementation hidden. This allows the bank to change or improve the account's 
internal implementation without affecting the code that uses the account.
3. Polymorphism: Animals. We have a hierarchy of animal classes let's think of it from programming point of view. We have a base class 
"Animal" and subclasses such as "Dog","Cat" and "Horse". Each class provides its own implementation of the MakeSound() method, but they 
are all subtypes of the Animal base class.In this example, the "Animal" base class contains the "Make a Sound()" abstract method, and 
each subclass (Dog, Cat, and Horse) provides its own implementation of this method.
4. Abstraction: transportation System. There are lots of various modes of transport in the trasportation system, such as buses, 
trains, and airplanes. Each mode of transport has its own unique characteristics and functionalities,  but we wont to create a 
common interface for interacting with the transportation system.By using abstraction, you can treat different modes of transport 
polymorphically through the Transport class, allowing you to start and stop them using a unified interface. This abstraction allows us 
to interact with the transportation system without worrying about the specific implementation details of each mode of transport, promoting 
code reusability and maintainability.
*/
#endregion