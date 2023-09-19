using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalTest
{
    public class Pudel : Dog
    {
        public override void Eat()
        {
            Console.WriteLine("Pudel yam-yam! Eatind!");
        }

        public override void Poop()
        {
            Console.WriteLine("Podel is pooping!");
        }
    }
}
