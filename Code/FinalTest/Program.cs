using FinalTest;

Console.WriteLine("Execution of task:");
var citiesTask = new Cities();
citiesTask.CityFiltering();
Console.WriteLine("Execution of task is finished:");


Console.WriteLine("Execution of the generic method task!");
var genericMethodTask = new GenericMethodTask();
genericMethodTask.PrintValue("my name is Nadya");
genericMethodTask.PrintValue(123456);
genericMethodTask.PrintValue(123.12);
Console.WriteLine("Execution of the generic method task is finished!");

