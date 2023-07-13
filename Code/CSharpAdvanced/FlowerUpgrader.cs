using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAdvanced
{
    internal class FlowerUpgrader<T> where T : Flower
    {
        public void UpgradeFlower(T flower)
        {
            flower.Price += flower.Price * 0.15;
        }
    }    
}
