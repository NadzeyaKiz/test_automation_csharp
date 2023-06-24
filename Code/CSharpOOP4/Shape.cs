﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOOP4
{
    abstract class Shape
    {
        private string _name;

        public Shape(string name)
        {
            _name = name;
        }

        public abstract double CalculateVolume();

        public virtual void DisplayShapeInfo()
        {
            Console.WriteLine("Shape: " + _name);
            Console.WriteLine("Volume: " + CalculateVolume());
        }
    }

}
