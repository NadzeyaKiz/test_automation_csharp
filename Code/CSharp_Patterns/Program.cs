using CSharp_Patterns;
using CSharp_Patterns.Decorator;
using CSharp_Patterns.FactoryMethod;

#region Implementation of the Decorator pattern

Console.WriteLine("Execution of the Task1. Implementation of the Decorator pattern");
IGigantosaurus basicGigantosaurus = new Gigantosaurus();
Console.WriteLine("------------------------");
Console.WriteLine("The basic volume of the roar of the 'Gigantosaurus'");
basicGigantosaurus.Roar();
Console.WriteLine("------------------------");
// Output: Gigantosaurus: Roar!

IGigantosaurus loudGigantosaurus = new LoudGigantosarusDecorator(basicGigantosaurus);
Console.WriteLine("------------------------");
Console.WriteLine("Increased the volume of the roar of the 'Gigantosaurus' to 'Loud'");
loudGigantosaurus.Roar();
Console.WriteLine("------------------------");
// Output:
// LoudGigantosaurusDecorator: ROAR!!!
// Gigantosaurus: Roar!

IGigantosaurus extraLoudGigantosaurus = new ExtraLoudGigantosaurusDecorator(loudGigantosaurus);
Console.WriteLine("------------------------");
Console.WriteLine("Increased the volume of the roar of the 'Gigantosaurus' to 'Loud' to 'ExtraLoud'");
extraLoudGigantosaurus.Roar();
Console.WriteLine("------------------------");
Console.WriteLine("End of execution of the Task1");

// Output:
// ExtraLoudGigantosaurusDecorator: ROOOOAAAARRRR!!!!
// Gigantosaurus: Roar!

/*Both decorator classes inherit from IGigantosaurus to maintain interface and compatibility with the Gigantosaurus 
 * base class. They decorate the base Gigantosaurus object by adding a new behavior (increasing the volume of the roar) 
 * without changing the Gigantosaurus itself. Thus, they make it easy to add new functionality to the base object, applying 
 * the open/close principle and avoiding the need to change the base class itself.*/

#endregion

#region Factory Method

// Creation of developers and use of their methods Create(), which returns an object of type IVehicle
Console.WriteLine();
Console.WriteLine("Execution of the Task2. Factory method");
Console.WriteLine("------------------------");
Console.WriteLine("The information about created unicycle object is: ");
IDeveloper unicycleDeveloper = new UnicycleDeveloper();
IVehicle unicycle = unicycleDeveloper.Create();
unicycle.GetInfo();

Console.WriteLine();

Console.WriteLine("The information about created motorcycle object is: ");
IDeveloper motorcycleDeveloper = new MotorcycleDeveloper();
IVehicle motorcycle = motorcycleDeveloper.Create();
motorcycle.GetInfo();

Console.WriteLine();

Console.WriteLine("The information about created car object is: ");
IDeveloper carDeveloper = new CarDeveloper();
IVehicle car = carDeveloper.Create();
car.GetInfo();

Console.WriteLine();

Console.WriteLine("The information about created truck object is: ");
IDeveloper truckDeveloper = new TruckDeveloper();
IVehicle truck = truckDeveloper.Create();
truck.GetInfo();

Console.WriteLine("------------------------");
Console.WriteLine("End of execution of the Task2");

#endregion