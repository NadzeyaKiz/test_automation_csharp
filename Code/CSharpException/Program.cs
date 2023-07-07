using CSharpException;

while (true)
{
    try
    {
        Console.WriteLine("Please enter the length of the sideA: ");
        double sideA = double.Parse(Console.ReadLine());

        Console.WriteLine("Please enter the length of the sideB: ");
        double sideB = double.Parse(Console.ReadLine());

        Console.WriteLine("Please enter the length of the sideC: ");
        double sideC = double.Parse(Console.ReadLine());

        Triangle triangle = new Triangle(sideA, sideB, sideC);
        triangle.DisplaySides();

        break;
    }
    catch (FormatException)
    {
        Console.WriteLine("Error: Invalid number format. Please re-enter.");
    }
    catch (ArgumentException e)
    {
        Console.WriteLine($"Error {e.Message}. Please re-enter.");
    }
}