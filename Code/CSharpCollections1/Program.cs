using System;
using CSharpCollections1;

#region Task_01
Console.WriteLine("Tasks_01 Execution!");
var task_01 = new Task_01();

Console.WriteLine("--------------------------");
Console.Write("Enter the elements of the array separated by a space: ");
string input = Console.ReadLine();

int[] array = task_01.ParseArray(input);

int[] evenArray = task_01.GetEvenOrOddNumbers(array, true);
task_01.SortArray(evenArray);
Console.WriteLine("Array with even numbers (sorted in ascending order):");
task_01.PrintArray(evenArray);

int[] oddArray = task_01.GetEvenOrOddNumbers(array, false);
task_01.SortArray(oddArray);
Console.WriteLine("Array with odd numbers (sorted in ascending order):");
task_01.PrintArray(oddArray);

Console.WriteLine("--------------------------");
Console.WriteLine("Execution of task_01 is finished");
#endregion

#region Task_02
Console.WriteLine("Tasks_02 Execution!");
var task02 = new Task_02();
double[] doubleArray = { 2.5, 1.0, 4.3, 3.2, 5.7 };
double minNumber, maxNumber;
double difference = task02.CountDifference(doubleArray, out minNumber, out maxNumber);
Console.WriteLine("--------------------------");
Console.WriteLine($"The difference between the maximum {maxNumber} and minimum {minNumber} number: {difference}");
Console.WriteLine("--------------------------");
Console.WriteLine("Execution of task_02 is finished");
#endregion

#region Task_03
Console.WriteLine("Tasks_03 Execution!");
var task03 = new Task_03();

Console.WriteLine("--------------------------");
Console.WriteLine("Enter surnames separated by a ';':");
List<string> surnames = task03.ParseSurnames(input);
Console.WriteLine("Sorted list of last names:");
task03.PrintSurnames(surnames);

Console.WriteLine("--------------------------");
Console.WriteLine("Execution of task_03 is finished");
#endregion

#region Task_04 Citizen
Console.WriteLine("Tasks_04 Execution!");
var task04 = new Citizen();

Console.WriteLine("--------------------------");
// Create a list of residents
List<Citizen> citizens = new List<Citizen>()
        {
            new Citizen { FullName = "Ivanov Ivan", Address = "Pervaya str, 1", DateOfBirth = new DateTime(1980, 1, 1) },
            new Citizen { FullName = "Petrov Petr", Address = "Vtoraya str, 2", DateOfBirth = new DateTime(1995, 5, 10) },
            new Citizen { FullName = "Sidorova Anna", Address = "Pervaya str, 1", DateOfBirth = new DateTime(2002, 12, 20) },
            new Citizen { FullName = "Smirnova Olga", Address = "Pervaya str, 3", DateOfBirth = new DateTime(1988, 9, 5) },
            new Citizen { FullName = "Kozlov Konstantin", Address = "Pervaya str, 1", DateOfBirth = new DateTime(1975, 7, 15) }
        };

// Specified address to search for voters
string searchAddress = "Pervaya str, 1";
task04.FilterAndSortVoters(searchAddress, out List<Citizen> eligibleVoters);
Console.WriteLine($"The list of voters living {searchAddress}:");
task04.PrintVoter(searchAddress, eligibleVoters);

Console.WriteLine("--------------------------");
Console.WriteLine("Execution of task_04 is finished");
#endregion;

#region Task_05
Console.WriteLine("Tasks_04 Execution!");
var task05 = new Task_05();

Console.WriteLine("Enter country-capital pairs (e.g., Country: Capital):");

Dictionary<string, string> originalDictionary = task05.ParseDictionary();
Dictionary<string, string> reversedDictionary =task05. ReverseDictionary(originalDictionary);

Console.WriteLine("--------------------------");
Console.WriteLine("Original Dictionary:");
task05.PrintDictionary(originalDictionary, false);

Console.WriteLine("--------------------------");
Console.WriteLine("Reversed Dictionary:");
task05.PrintDictionary(reversedDictionary, true);


Console.WriteLine("--------------------------");
Console.WriteLine("Execution of task_05 is finished");
#endregion