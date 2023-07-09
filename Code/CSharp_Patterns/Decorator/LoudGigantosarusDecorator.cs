using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Patterns.Decorator
{
    /*Decorator class responsible for increasing the volume of the Gigantosaurus roar. This class is
     * a concrete decorator within the Decorator pattern structure. It wraps the base object of the Gigantosaurus 
     * and adds additional functionality, in this case, increasing the volume of the roar.*/
    public class LoudGigantosarusDecorator : IGigantosaurus
    {
        private IGigantosaurus _gigantosaurus;

        public LoudGigantosarusDecorator(IGigantosaurus gigantosaurus)
        {
            _gigantosaurus = gigantosaurus;
        }

        public void Roar()
        {
            Console.WriteLine("LoudGigantosaurusDecorator: ROAR!!!");
            _gigantosaurus.Roar();
        }
    }
}
