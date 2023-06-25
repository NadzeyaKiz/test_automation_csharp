using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOOP4
{
    internal class Cylinder: Shape
    {
        private double _radius;
        private double _height;

        /*if we wont to hardcode the name of the "Cylinder" class (so the user will not able to choose unvalid
         *name) we may write the code in the following form:
         *public Cylinder(double radius, double height) : base("Cylinder")
         */
        public Cylinder(string name, double radius, double height) : base(name)
        {
            _radius = radius;
            _height = height;
        }

        public override double CalculateShapeVolume()
        {
            return Math.Round((Math.PI * Math.Pow(_radius, 2) * _height), 2);
        }

        public override void DisplayShapeInfo()
        {
            base.DisplayShapeInfo();
            Console.WriteLine($"The radius of the cylinder is {_radius}");
            Console.WriteLine($"The height of the cylinder is {_height}");
            Console.WriteLine("The formula for calculating the volume of the Cylinder shape is PI*radius^2*height");
        }
    }   
}
