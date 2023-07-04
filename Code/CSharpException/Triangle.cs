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
            if (!ValidateSidesNotNull(sideA, sideB, sideC))
            {
                throw new ArgumentException("Side value cannot be equal to or less than zero");
            }
            if (!ValidateSidesSummOfSides(sideA, sideB, sideC))
            {
                throw new ArgumentException("The sum of two sides must be greater than the third side. Please enter a valid values of the triangle sides.");
            }

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

        public bool ValidateSidesNotNull (double sideA, double sideB, double sideC)
        {
            if (sideA <= 0 || sideB <= 0 || sideC <= 0)
            {
                return false;
            }

            return true;
        }

        public bool ValidateSidesSummOfSides(double sideA, double sideB, double sideC)
        {
            if (sideA + sideB <= sideC || sideA + sideC <= sideB || sideB + sideC <= sideA)
            {
                return false;
            }

            return true;
        }
    }
}
