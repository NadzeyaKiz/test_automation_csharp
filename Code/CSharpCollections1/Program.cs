using CSharpCollections1;


#region Task_01
var evenAndOddNumbers = new Task_01EvenAndOddNumbers();
Console.WriteLine("Enter the elements of the array separated by a space:");
string input = Console.ReadLine();

Console.WriteLine("Array with even numbers (sorted in ascending order):");
evenAndOddNumbers.PrintArray(evenArray);

Console.WriteLine("Array with odd numbers (sorted in ascending order):");
evenAndOddNumbers.PrintArray(oddArray);
#endregion

#region
var task02 = new Task_02();
Console.WriteLine("The difference between the maximum and minimum number: " + task02.Main(difference));
#endregion

#region
var task03 = new Task_03();
task03.PrintSurnames(List<string> surnames);
#endregion

#region
var task04 = new Citizen();
Console.WriteLine("Please enter the Specified address to search for voters");

#endregion region