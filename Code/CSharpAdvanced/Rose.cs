using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAdvanced
{
    public class Rose : Flower 
    {
        public Rose()
        {
            Name = DefaultName;
            Color = DefaultColor;
            Price = DefaultPrice;
        }

        public const string DefaultName = "Rose";
        public const string DefaultColor = "Red";
        public const double DefaultPrice = 1.5;

    }
}
