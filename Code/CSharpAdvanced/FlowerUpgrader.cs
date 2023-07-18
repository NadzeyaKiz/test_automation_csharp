using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAdvanced
{
    public class FlowerUpgrader<T> where T : Flower
    {  
        public List<RepaintedFlower> Repaint(List<T> flowers, string newColor)
        {
            return flowers.Select(x => new RepaintedFlower(x, newColor, Math.Round(x.Price * 1.15, 2))).ToList();           
        }
    }    
}
