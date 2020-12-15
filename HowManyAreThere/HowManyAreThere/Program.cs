using System;
using System.Linq;

namespace HowManyAreThere
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayHelper helper = new ArrayHelper();

            int[] values = { 1, 15, 22, -3, 8, 22, 15, 0 };
            int[] empty = { };

            Console.WriteLine($"Smallest number in values: {helper.Minimum(values)}");
            Console.WriteLine($"Smallest number in empty: {helper.Minimum(empty)}");

            int find = 22;
            Console.WriteLine($"Counting {find} in values: {helper.Count(values, find)}");
            Console.WriteLine($"Counting {find} in empty: {helper.Count(empty, find)}");

            int nonExisting = -606;
            Console.WriteLine($"Counting {nonExisting} in values: {helper.Count(values, nonExisting)}");
            Console.WriteLine($"Counting {nonExisting} in empty: {helper.Count(empty, nonExisting)}");
        }
    }
}
