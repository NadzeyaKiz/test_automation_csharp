using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalTest
{
    public class GenericMethodTask
    {
        public void PrintValue<T>(T value)
        {
            Console.WriteLine(value);
        }
    }
}
