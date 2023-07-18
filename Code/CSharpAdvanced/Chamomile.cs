using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAdvanced
{
    public class Chamomile : Flower 
    {
        public Chamomile()
        {
            Name = DefaultName;
            Color = DefaultColor;
            Price = DefaultPrice;           
        }

        public const string DefaultName = "Chamomile";
        public const string DefaultColor = "White";
        public const double DefaultPrice = 0.75;

    }
}
