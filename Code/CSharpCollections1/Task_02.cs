using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCollections1
{
    internal class Task_02
    {
        public static double Main()
        {
            double[] array = { 2.5, 1.0, 4.3, 3.2, 5.7 };

            double minNumber = FindMinNumber(array);
            double maxNumber = FindMaxNumber(array);

            double difference = maxNumber - minNumber;

            return difference;           
        }

        static double FindMinNumber(double[] array)
        {
            double minNumber = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] < minNumber)
                    minNumber = array[i];
            }

            return minNumber;
        }
        static double FindMaxNumber(double[] array)
        {
            double maxNumber = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > maxNumber)
                    maxNumber = array[i];
            }

            return maxNumber;
        }
    }
}
