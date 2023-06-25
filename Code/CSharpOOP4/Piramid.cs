using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOOP4
{
    internal class Piramid : Shape
    {
        private double _baseArea;
        private double _height;

        /*if we wont to hardcode the name of the "Piramid" class (so the user will not able to choose unvalid
         *name) we may write the code in the following form:
         *public Piramid(double baseArea, double height) : base("Piramid")
         */
        public Piramid(string name, double baseArea, double height) : base(name)
        {
            _baseArea = baseArea;
            _height = height;
        }
        public override double CalculateShapeVolume()
        {
            return  Math.Round(_baseArea * _height / 3, 2);
        }

        public override void DisplayShapeInfo()
        {
            base.DisplayShapeInfo();
            Console.WriteLine($"The base area of the piramid = {_baseArea}");
            Console.WriteLine($"The height of the piramid is {_height}");
            Console.WriteLine("The formula for calculating the volume of the Piramid shape is (1/3)*base area * height");
        }
    }
}
