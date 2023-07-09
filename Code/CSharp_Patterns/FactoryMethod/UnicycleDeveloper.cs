using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Patterns.FactoryMethod
{
    internal class UnicycleDeveloper :  IDeveloper
    {// The UnicycleDeveloper class is the Creator of Unicycle type objects.
     // Implements the IDeveloper interface and provides a Create() method that returns an IVehicle (Unicycle) object.
        public IVehicle Create()
        {
            return new Unicycle();
        }
    }
}
