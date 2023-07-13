using CSharpAdvanced;
using System.Collections.Generic;


//#region

//Console.WriteLine("Execution of the task 01!:");
//Console.WriteLine("--------------------------");
//Console.WriteLine("Entering values:");

//GenericMethod genericMethod = new GenericMethod();

//Console.WriteLine("Please enter integer values (separated by spaces):");
//var intList = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
//int firstInt = genericMethod.GetFirstElement(intList);

//Console.WriteLine("Please enter string values (separated by spaces):");
//var stringList = Console.ReadLine().Split(' ').ToList();
//string firstString = genericMethod.GetFirstElement(stringList);

//Console.WriteLine("Please enter double values (separated by spaces):");
//var doubleList = Console.ReadLine().Split(' ').Select(double.Parse).ToList();
//double firstDouble = genericMethod.GetFirstElement(doubleList);

//Console.WriteLine("--------------------------");
//Console.WriteLine("Output values:");
//Console.WriteLine("First int: " + firstInt);
//Console.WriteLine("First string: " + firstString);
//Console.WriteLine("First double: " + firstDouble);
//Console.WriteLine("End of the execution of the task 01!");
//Console.WriteLine("--------------------------");
//#endregion

#region Task02 Task for generic methods - flowers

Rose rose = new Rose();
Chamomile chamomile = new Chamomile();

Console.WriteLine("Enter the quantity of Roses:");
int roseQuantity = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter the quantity of Chamomiles:");
int chamomileQuantity = Convert.ToInt32(Console.ReadLine());

List<Rose> roses = CreateFlowerList<Rose>(roseQuantity);
List<Chamomile> chamomiles = CreateFlowerList<Chamomile>(chamomileQuantity);

double roseTotalCost = CalculateTotalCost(roses);
double chamomileTotalCost = CalculateTotalCost(chamomiles);

Console.WriteLine("Receipt:");
Console.WriteLine("--------------");
PrintReceipt(roses);
PrintReceipt(chamomiles);
Console.WriteLine("--------------");
Console.WriteLine("Rose Total cost: $" + roseTotalCost);
Console.WriteLine("Chamomile Total cost: $" + chamomileTotalCost);

static List<T> CreateFlowerList<T>(int quantity) where T : Flower, new()
{
    List<T> flowers = new List<T>();
    for (int i = 0; i < quantity; i++)
    {
        flowers.Add(new T());
    }
    return flowers;
}

static double CalculateTotalCost<T>(List<T> flowers) where T : Flower
{
    double totalCost = 0;
    foreach (T flower in flowers)
    {
        totalCost += flower.Price;
    }
    return totalCost;
}
static void PrintReceipt<T>(List<T> flowers) where T : Flower
{
    foreach (T flower in flowers)
    {
        Console.WriteLine($"Flower: {flower.Name} - Color: {flower.Color} - Price: {flower.Price}");
    }
}


#endregion

//#region

//Rose rose = new Rose();
//Chamomile chamomile = new Chamomile();

//Console.WriteLine("Before upgrade:");
//PrintFlowerInfo(rose);
//PrintFlowerInfo(chamomile);

//FlowerUpgrader<Rose> roseUpgrader = new FlowerUpgrader<Rose>();
//roseUpgrader.UpgradeFlower(rose);

//FlowerUpgrader<Chamomile> chamomileUpgrader = new FlowerUpgrader<Chamomile>();
//chamomileUpgrader.UpgradeFlower(chamomile);

//Console.WriteLine("After upgrade:");
//PrintFlowerInfo(rose);
//PrintFlowerInfo(chamomile);

//static void PrintFlowerInfo(Flower flower)
//{
//    Console.WriteLine($"Flower: {flower.Name}, Color: {flower.Color}, Price: {flower.Price}");
//}
//#endregion

//#region Task04

//Flower flower = new Flower();
//flower.Name = "Rose";
//flower.Color = flower.GenerateRandomColor();
//flower.Price = 60.0;

//flower.PrintFlowerInfo();

//bool isExpensive = flower.Price.IsPriceExpensive();
//Console.WriteLine($"Is price expensive? {isExpensive}");

//string capitalized = "rose".CapitalizeFirstLetterFlower();
//Console.WriteLine($"Capitalized string: {capitalized}");

//bool isValidColor = flower.IsColorValid();
//Console.WriteLine($"Is color valid? {isValidColor}");
//#endregion