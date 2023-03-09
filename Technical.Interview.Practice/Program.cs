using System;
using System.Collections.Generic;
using TechInterview.Practice.Demos;
namespace TechInterview.Practice
{
    class Program
    {   public static int CountSwitches(List<int> argument)
        {
            return 0;
        }
        public static int MaxProductOfThree(List<int> argument)
        {
            int size = argument.Count;
            argument.Sort();
            int positiveMax = argument[size - 1] * argument[size - 2] * argument[size - 3];
            int negativeMax = argument[size - 1] * argument[0] * argument[1];
            return Math.Max(positiveMax, negativeMax);
        }

        static void Main(string[] args)
        {
            new Demos.MaxProductDemo.TestMaxProduct(2, 5, 20, 10, 5).RunWithDetails();
        }
    }
}
