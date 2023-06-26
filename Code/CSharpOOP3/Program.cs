using CSharpOOP3;

Flowers flowers = new Flowers();

//#region Reading and writing values ​​to the fields(Task_2)
//double price = flowers.Price;
//string color = flowers.Color;//Error Line (The property or indexer 'Flowers.Color' cannot be used in this context because it lack the get accessor)

//flowers.Color = "Red";
//flowers.Price = 10.99;//Error Line (Property or index 'Flowers.Price' cannot be assigned to -- it is read only)

//Console.WriteLine($"Flower color: {flowers.Color}");//Error Line(The property or indexer 'Flowers.Color' cannot be used in this context because it lack the get accessor)
//Console.WriteLine($"Flower price: {flowers.Price}");

///* In this case, writing the value of the flowers.Color property is allowed, but attempting to read the value will cause a 
// * compilation error because there is no get block.
// * Attempt to write a value in the flowers.Price is forbidden, but reading the value is allowed.*/
//#endregion

#region Calling a static field and adding a value to it(Task_04)
Flower.Type = "Plants";
string kind = Flower.Type;
Console.WriteLine($"Kind of the flower is {kind}");
#endregion

#region Calling all static methods (Task_07)
string randomColor = Helper.GenerateRandomColor();
Console.WriteLine($"Random Color: {randomColor}");

Helper.PrintFlowerInfo("Rose", "Red", 25.5);

Console.WriteLine("Please enter the flower's price:");
double flowerprice = Convert.ToDouble(Console.ReadLine());
bool isExpensive = Helper.IsPriceExpensive(flowerprice);
Console.WriteLine($"Is Price Expensive: {isExpensive}");

Console.WriteLine("Please enter the name of the flower:");
string lowerletter = Console.ReadLine();
string capitalizedString = Helper.CapitalizeFirstLetter(lowerletter);
Console.WriteLine($"Capitalized String: {capitalizedString}");
#endregion
