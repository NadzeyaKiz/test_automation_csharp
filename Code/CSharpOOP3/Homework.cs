using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOOP3
{
    public class Flowers  //Task_01
    {
        public string color;
        public double price;

        public string Color//(setter-only property)
        {
            set { color = value; }
        }

        public double Price { get; }//(read-only property)


    }    
}
