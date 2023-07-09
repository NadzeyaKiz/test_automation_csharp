using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Patterns.FactoryMethod
{// The Unicycle class is responsible for creating and representing the unicycle.
 // Is a Concrete Product in the Factory Method pattern.
    internal class Unicycle : IVehicle
    {
        public void GetInfo()
        {
            Console.WriteLine("Unicycle: Single-wheel vehicle");
        }
    }
}
