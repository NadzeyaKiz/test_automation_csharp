﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Patterns.FactoryMethod
{// The Car class is responsible for creating and representing the unicycle.
 // Is a Concrete Product in the Factory Method pattern.
    internal class Car : IVehicle
    {
        public void GetInfo()
        {
            Console.WriteLine("Car: Four-wheel vehicle");
        }
    }
}
