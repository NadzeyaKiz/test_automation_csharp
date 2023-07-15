using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAdvanced
{
    public class Task01
    {
        public T GetFirstElement<T>(List<T> list)
        {
            if (list == null || list.Count == 0)
            {
                throw new ArgumentException("The list is empty.");
            }

            return list[0];        
        }
    }
}
