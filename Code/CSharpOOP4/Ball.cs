using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CSharpOOP4
{
    internal class Ball : Shape
    {
        private double _radius;

        /* It was possible to write  "public Sphere(string name, double radius) : base(name)", 
         * but the current variation is beter becouse the user can not change the name to unvalid for examle
         * "Square"*/
        public Ball(double radius) : base("Ball")
        {
            _radius = radius;
        }

        public override double CalculateShapeVolume()
        {
            return Math.Round((4 / 3.0) * Math.PI * Math.Pow(_radius, 3), 2);
        }

        public override void DisplayShapeInfo()
        { 
            base.DisplayShapeInfo();
            Console.WriteLine($"The radius of the ball is {_radius}");
            Console.WriteLine("The formula for calculating the volume of the ball shape is (4/3)*PI*radius^3");
        }
    }      
}
