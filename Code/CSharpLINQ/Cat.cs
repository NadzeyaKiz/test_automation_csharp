using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLINQ
{
    internal class Cat
    {
        public string Color { get; set; }


        public void Task_09(string[] args)
        {
            List<string> colors = new List<string> { "grey", "white", "black" };
            List<Cat> cats = colors.Select(color => new Cat { Color = color }).ToList();

            Console.WriteLine("The list of cats: ");

            foreach (var cat in cats)
            {
                Console.WriteLine("Color is: " + cat.Color);
            }
        }
        public void Task_010(string[] args)
        {
            List<Cat> cats = new List<Cat>
            {
                new Cat { Color = "gray" },
                new Cat { Color = "white" },
                new Cat { Color = "black" }
            };

        }
    }    
}
