using CSharpAdvanced;
using System.Collections.Generic;


#region Task01

Console.WriteLine("Execution of the task 01!:");
Console.WriteLine("--------------------------");
Console.WriteLine("Entering values:");

Task01 genericMethod = new Task01();

Console.WriteLine("Please enter integer values (separated by spaces):");
var intList = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
int firstInt = genericMethod.GetFirstElement(intList);

Console.WriteLine("Please enter string values (separated by spaces):");
var stringList = Console.ReadLine().Split(' ').ToList();
string firstString = genericMethod.GetFirstElement(stringList);

Console.WriteLine("Please enter double values (separated by spaces):");
var doubleList = Console.ReadLine().Split(' ').Select(double.Parse).ToList();
double firstDouble = genericMethod.GetFirstElement(doubleList);

Console.WriteLine("--------------------------");
Console.WriteLine("Output values:");
Console.WriteLine("First int: " + firstInt);
Console.WriteLine("First string: " + firstString);
Console.WriteLine("First double: " + firstDouble);
Console.WriteLine("End of the execution of the task 01!");
Console.WriteLine("--------------------------");
#endregion

#region Task02 Task for generic methods - flowers

Rose rose = new Rose();
Chamomile chamomile = new Chamomile();

Console.WriteLine("Enter the quantity of Roses:");
int roseQuantity = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter the quantity of Chamomiles:");
int chamomileQuantity = Convert.ToInt32(Console.ReadLine());

List<Rose> roses = FlowerHelper.CreateFlowerList<Rose>(roseQuantity);
List<Chamomile> chamomiles = FlowerHelper.CreateFlowerList<Chamomile>(chamomileQuantity);

double roseTotalCost = FlowerHelper.CalculateTotalCost(roses);
double chamomileTotalCost = FlowerHelper.CalculateTotalCost(chamomiles);

Console.WriteLine("Receipt:");
Console.WriteLine("--------------");
FlowerHelper.PrintReceipt(roses);
FlowerHelper.PrintReceipt(chamomiles);
Console.WriteLine("--------------");
Console.WriteLine("Rose Total cost: $" + roseTotalCost);
Console.WriteLine("Chamomile Total cost: $" + chamomileTotalCost);

#endregion

#region Task03

Console.WriteLine();
Console.WriteLine("Execution of the task03:");

FlowerUpgrader<Rose> roseUpdater = new FlowerUpgrader<Rose>();
Console.WriteLine("Please enter a new color for a rose for repaint:");
string newRoseColor = Console.ReadLine();
Console.WriteLine("Please enter a quantity of roses for repaint:");
int roseQuantityForRepaint = Convert.ToInt32(Console.ReadLine());
List<Rose> rosesForRepaint = FlowerHelper.CreateFlowerList<Rose>(roseQuantityForRepaint);
List<RepaintedFlower> repaitedRoses = roseUpdater.Repaint(rosesForRepaint, newRoseColor);

FlowerUpgrader<Chamomile> chamomileUpdater = new FlowerUpgrader<Chamomile>();
Console.WriteLine("Please enter a new color for a chamomile for repaint:");
string newChamomileColor = Console.ReadLine();
Console.WriteLine("Please enter a quantity of chamomiles for repaint:");
int chamomilesQuantityForRepaint = Convert.ToInt32(Console.ReadLine());
List<Chamomile> chamomilesForRepaint = FlowerHelper.CreateFlowerList<Chamomile>(chamomilesQuantityForRepaint);
List<RepaintedFlower> repaitedChomomiles = chamomileUpdater.Repaint(chamomilesForRepaint,newChamomileColor);


double repaintedRoseTotalCost = FlowerHelper.CalculateTotalCost(repaitedRoses);
double repaintedChamomileTotalCost = FlowerHelper.CalculateTotalCost(repaitedChomomiles);

Console.WriteLine("Receipt:");
Console.WriteLine("--------------");
FlowerHelper.PrintReceipt(repaitedRoses);
Console.WriteLine($"The quantuty of repainted roses is {roseQuantityForRepaint}, new roses color is {newRoseColor}");
FlowerHelper.PrintReceipt(repaitedChomomiles);
Console.WriteLine($"The quantuty of repainted chamomiles is {chamomilesQuantityForRepaint}, new chamomiles color is {newChamomileColor}");
Console.WriteLine("--------------");
Console.WriteLine("Repainted rose Total cost: $" + repaintedRoseTotalCost);
Console.WriteLine("Repainted chamomile Total cost: $" + repaintedChamomileTotalCost); 
Console.WriteLine("End of the execution of the task03:");

#endregion

#region Task04

Flower jasmine = new Flower
{
    Name = "jasmine",
    Color = "Red",
    Price = 20,
};

Console.WriteLine("Execution of the task04: ");
Console.WriteLine("--------------");

string randomColor = jasmine.GenerateRandomColor();
Console.WriteLine($"Random Color: {randomColor}");

Console.WriteLine("Flower info:------");
jasmine.PrintFlowerInfo();
Console.WriteLine("End of flower info--");

bool isExpensive = jasmine.IsPriceExpensive();
Console.WriteLine($"Is Expensive: {isExpensive}");

string capitalized = jasmine.CapitalizeFirstLetterFlower();
Console.WriteLine($"Capitalized flower name: {capitalized}");

bool isColorValid = jasmine.IsColorValid();
Console.WriteLine($"Is color valid: {isColorValid}: ");

Console.WriteLine("--------------");
Console.WriteLine("Execution of the task04 is finished!");

#endregion