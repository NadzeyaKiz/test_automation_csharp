using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAdvanced
{
    public class Flower
    {
        public string Name { get; set; }
        public string Color { get; set; }
        public double Price { get; set; }
        public override string ToString()
        {
           return string.Format($"Flower: {Name} - Color: {Color} - Price: {Price}");
        }
    }
}
