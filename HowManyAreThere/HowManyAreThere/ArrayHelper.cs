using System;
using System.Collections.Generic;
using System.Text;

namespace HowManyAreThere
{
    public class ArrayHelper
    {
        public int Count(int[] numbers, int value)
        {
            // TODO - Count how many times "value" occurs in "numbers"
            // TODO - Make sure to return 0 if the array is empty

            int count = 0;
            foreach (int number in numbers)     // Or can use for-loop
            {
                if (number == value)
                {
                    count++;
                }
            }

            return count;
        }

        public int Minimum(int[] numbers)
        {
            // TODO - Search for the smallest value in "numbers"
            // TODO - Make sure to return 0 if the array is empty

            if (numbers.Length == 0)
            {
                return 0;
            }

            int currentMinimum = numbers[0];    // First is smallest to start with
            foreach (int number in numbers)     // Could also use for starting from first element
            {
                if (number < currentMinimum)
                {
                    currentMinimum = number;
                }
            }

            return currentMinimum;
        }
    }
}
