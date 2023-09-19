using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalTest
{
    public abstract class Dog
    {
        public string Name { get; set; }
        public int Breed { get; set; }

        public abstract void Eat();
        public abstract void Poop();
    }
}
