using CSharpOOP2;
//using System.Diagnostics;
//using System.Dynamic;

//#region Creation of the first instance of the class Table (Task_04)
//Table table1 = new Table();
//table1.Name = "Napoleon";
//table1.Quantity = 12;
//table1.Price = 143.65;
//table1.Brand = "IKEA";
//table1.IsAvailable = true;
//#endregion

//#region Creation of the second instance of the class Table (Task_05)
//Table table2 = new Table()
//{
//    Name = "Picollo",
//    Quantity = 10,
//    Price = 123.12,
//    Brand = "EWEE",
//    IsAvailable = true
//};
//#endregion

//#region Creating a third instance of the Table class with a constructor that initializes all fields (Task_9)
//Table table3 = new Table("Woody", 2, 249.99, "XYZ Furniture", true);
//#endregion

//#region Calling the PrintAvailability() method (Task10)
//table1.PrintAvailability(); //Calling the PrintAvailability() method on an instance table1
//table2.PrintAvailability();//Calling the PrintAvailability() method on an instance table2
//#endregion

//#region Calling a InternalMethod() method with private and internal modifiers (Task_11)
//// Calling a method with the private modifier
//// table1.PrivateMethod(); // Error Line - Not available from class Program

//// Calling a method with the internal modifier
//table2.InternalMethod(); // There is no error in this case because Program and Table are in the same assembly
//#endregion

//# region Do not declare a field that is used to change the method PrintAvailability() (Task_12)
//Table table4 = new Table()
//{
//    Name = "Rainbow",
//    Price = 123.43,
//    Brand = "Test",
//    IsAvailable = true
//};
//table4.PrintAvailability();// Product Rainbow is temporarily out of stock.

///*This is because C# defaults to 0 for numeric data types such as int. When the Quantity field is not declared or initialized, 
// * it defaults to 0, which in this case is 0. The PrintAvailability() method checks the Quantity value. If Quantity is greater 
// * than 0, the message "Table {Name} is available." However, if Quantity is 0, the else branch is executed and the message 
// * "Product {Name} is temporarily out of stock.". Thus, if the value of the Quantity field is missing, it will have a default 
// * value (0), and the PrintAvailability() method will display a message that the product is temporarily out of stock.*/
//#endregion

#region (Task_13)
Table table5 = new Table()
{
    Name = "Rainbow",
    Quantity = 10,
    Brand = "Test",
    IsAvailable = true
};
// Вывод значения поля Price
Console.WriteLine($"Значение поля Price: {table5.Price}");
#endregion