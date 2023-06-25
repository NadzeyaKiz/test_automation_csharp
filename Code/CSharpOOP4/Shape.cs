using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOOP4
{
    abstract class Shape
    {
        private string _name;
        public string Name { get { return _name; } }
        
        public Shape(string name)
        {
            _name = name;
        }

        public abstract double CalculateShapeVolume();

        public virtual void DisplayShapeInfo()
        {
            Console.WriteLine("The name of the shape is: " + _name);
            Console.WriteLine($"The volume of the shape {_name} is: " + CalculateShapeVolume());
        }
    }

}
