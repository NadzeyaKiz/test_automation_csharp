using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Patterns.FactoryMethod
{// The class CarDeveloper is the creator (Creator) of objects of type Car.
 // Implements the IDeveloper interface and provides a Create() method that returns an IVehicle (Car) object.
    internal class CarDeveloper : IDeveloper
    {
        public IVehicle Create()
        {
            return new Car();
        }
    }
}
