using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Patterns.FactoryMethod
{// The TruckDeveloper class is the Creator of objects of type Truck.
// Implements the IDeveloper interface and provides a Create() method that returns an IVehicle (Truck) object.
    internal class TruckDeveloper : IDeveloper
    {
        public IVehicle Create()
        {
            return new Truck();
        }
    }
}
