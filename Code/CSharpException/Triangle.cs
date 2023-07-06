using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CSharpException
{
    public class Triangle
    {
        public Triangle(double sideA, double sideB, double sideC) 
        {
            ValidateSidesNotNull(sideA, sideB, sideC);
            ValidateSidesSummOfSides(sideA, sideB, sideC);
                
            SideA = sideA;
            SideB = sideB;
            SideC = sideC;

        }
        public double SideA { get; private set; }
        public double SideB { get; private set; }
        public double SideC { get; private set; }

        public void DisplaySides()
        {
            Console.WriteLine($"The sideA of the triangle is: {SideA}");
            Console.WriteLine($"The sideB of the triangle is: {SideB}");
            Console.WriteLine($"The sideC of the triangle is: {SideC}");
        }

        public void ValidateSidesNotNull (double sideA, double sideB, double sideC)
        {
            if (sideA <= 0 || sideB <= 0 || sideC <= 0)
            {
                throw new ArgumentException("Side value cannot be equal to or less than zero");
            }
        }

        public void ValidateSidesSummOfSides(double sideA, double sideB, double sideC)
        {
            if (sideA + sideB <= sideC || sideA + sideC <= sideB || sideB + sideC <= sideA)
            {
                throw new ArgumentException("The sum of two sides must be greater than the third side. Please enter valid values for the triangle sides.");
            }
        }
    }
}
