using System;
using System.Collections.Generic;
using System.Text;
using TechInterview.Practice.Demos.Tools;

namespace TechInterview.Practice.Demos.MaxProductDemo
{
    class TestMaxProduct
    {
        int seed, range, listSize, offset, numOfTests;
        List<List<int>> maxProductList;
        RandomListGenerator rand;
        public TestMaxProduct()
        {
            seed = 1;
            listSize = 10;
            range = 41;
            offset = 20;
            numOfTests = 10;
            rand = new RandomListGenerator(seed, range, offset);
        }
        public TestMaxProduct(int seed, int listSize, int range, int numOfTests)
        {
            this.seed = seed;
            this.listSize = listSize > 2 ? listSize : 3;
            this.range = range * 2 + 1;
            this.offset = this.range / 2;
            this.numOfTests = numOfTests;
            rand = new RandomListGenerator(this.seed, this.range, this.offset);
        }

        public void Run()
        {
            RunWithDetails();
            RunForPassed();
        }
        private void RunWithDetails()
        {
            maxProductList = new List<List<int>>();
            for (int i = 0; i < numOfTests; i++)
            {
                Console.Write($"Test{i+1}: [");
                maxProductList.Add(rand.GenerateList(listSize));
                for(int j = 0; j < maxProductList[i].Count-1; j++)
                {
                    Console.Write($"{maxProductList[i][j]}, ");
                }
                Console.WriteLine($"{maxProductList[i][maxProductList[i].Count - 1]}]");
            }
            Console.WriteLine();
            /*
            for(int i = 0; i < numOfTests; i++)
            {
                Console.WriteLine($"Test{i+1}: {Program.MaxProductOfThree(maxProductList[i])}");
            }
            */
        }

        private void RunForPassed()
        {
            maxProductList = new List<List<int>>();
            Console.WriteLine($"\t    Expected\t|    Actual\t|    Result\n\t----------------|---------------|----------------");
            for (int i = 0; i < numOfTests; i++)
            {
                maxProductList.Add(rand.GenerateList(listSize));
                int expected = MPTSolution(maxProductList[i]);
                int actual = Program.MaxProductOfThree(maxProductList[i]);
                bool passed = expected == actual;
                Console.WriteLine($"Test{i+1}:\t\t{expected}\t|\t{actual}\t|\t{passed}");
            }
        }
        private int MPTSolution(List<int> argument)
        {
            int size = argument.Count;
            argument.Sort();
            int positiveMax = argument[size - 1] * argument[size - 2] * argument[size - 3];
            int negativeMax = argument[size - 1] * argument[0] * argument[1];
            return Math.Max(positiveMax, negativeMax);
        }

        

    }
}
