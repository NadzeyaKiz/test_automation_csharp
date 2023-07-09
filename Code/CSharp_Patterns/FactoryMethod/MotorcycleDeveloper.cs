using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Patterns.FactoryMethod
{/* The MotorcycleDeveloper class is the Creator of Motorcycle objects.
    Implements the IDeveloper interface and provides a Create() method that returns an object of type IVehicle 
    (Motorcycle).*/
    internal class MotorcycleDeveloper : IDeveloper
    {
        public IVehicle Create()
        {
            return new Motorcycle();
        }
    }
}
