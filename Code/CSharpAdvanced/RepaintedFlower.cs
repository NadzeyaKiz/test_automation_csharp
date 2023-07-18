using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAdvanced
{
    public class RepaintedFlower : Flower
    {
        public RepaintedFlower(Flower originalFlower, string color, double price)
        {
            OriginalFlower = originalFlower;
            Name = originalFlower.Name;
            Color = color;
            Price = price;
        }

        public Flower OriginalFlower { get; set; }

        public override string ToString()
        {
            return string.Format($"Flower: {Name} - Color: {Color} (Original color: {OriginalFlower.Color}) - Price: {Price} (Original price: {OriginalFlower.Price})");
        }
    }

}
