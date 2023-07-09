using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Patterns.Decorator
{
    /*Class decorator, also responsible for increasing the volume of the Gigantosaurus roar. This class is a concrete 
     * decorator in the Decorator pattern structure. It wraps the base Gigantosaurus object and adds some extra 
     * functionality, in this case even more roar volume boost.*/
    public class ExtraLoudGigantosaurusDecorator : IGigantosaurus
    {
        private readonly IGigantosaurus _gigantosaurus;

        public ExtraLoudGigantosaurusDecorator(IGigantosaurus gigantosaurus)
        {
            _gigantosaurus = gigantosaurus;
        }

        public void Roar()
        {
            Console.WriteLine("ExtraLoudGigantosaurusDecorator: ROOOOAAAARRRR!!!!");
            _gigantosaurus.Roar();
        }
    }
}
