using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Patterns.Decorator
{/*The base class to which we want to add additional functionality using decorators.It defines the basic behavior 
  * and can be decorated with one or more decorators that add extra functionality without changing the base class itself.*/
    public class Gigantosaurus : IGigantosaurus
    {
        public void Roar()
        {
            Console.WriteLine("Gigantosaurus: Roar!");
        }
    }
}
