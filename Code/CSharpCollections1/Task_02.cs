using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCollections1
{
    internal class Task_02
    {
        public double CountDifference(double[] array, out double minNumber, out double maxNumber)
        {
            minNumber = FindMinNumber(array);
            maxNumber = FindMaxNumber(array);
            double difference = maxNumber - minNumber;

            return difference;
        }

        public double FindMinNumber(double[] array)
        {
            double minNumber = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] < minNumber)
                    minNumber = array[i];
            }

            return minNumber;
        }

        public double FindMaxNumber(double[] array)
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
