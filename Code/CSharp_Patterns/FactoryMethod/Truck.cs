using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Patterns.FactoryMethod
{// The Truck class is responsible for creating and representing the unicycle.
 // Is a Concrete Product in the Factory Method pattern.
    internal class Truck : IVehicle
    {
        public void GetInfo()
        {
            Console.WriteLine("Truck: Large cargo vehicle");
        }
    }
}
