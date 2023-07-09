using CSharp_Patterns;
using CSharp_Patterns.Decorator;

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
