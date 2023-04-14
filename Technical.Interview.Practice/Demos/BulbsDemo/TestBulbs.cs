using System;
using System.Collections.Generic;
using System.Text;
using TechInterview.Practice.Demos.Tools;

namespace TechInterview.Practice.Demos.BulbsDemo
{
    class TestBulbs
    {
        private List<List<int>> bulbs = new List<List<int>>();
        private int randomSeed, numberOfTests, maxListSize;
        private Random rand;

        public TestBulbs(int randomSeed, int numberOfTests, int maxListSize)
        {
            this.randomSeed = randomSeed;
            this.numberOfTests = numberOfTests;
            this.maxListSize = maxListSize > 3 ? maxListSize : 3;
            rand = new Random(randomSeed);
        }

        public TestBulbs()
        {
            randomSeed = 1;
            numberOfTests = 10;
            maxListSize = 15;
            rand = new Random(randomSeed);
        }
        public void Run()
        {
            RunWithDetails();
            RunForPassed();
        }
        private void RunForPassed()
        {
            /*
            for (int j = 0; j < numberOfTests; j++)
            {
                
                int length = rand.Next(maxListSize);
                for (int i = 0; i < length; i++)
                {
                    bulbs[j].Add(rand.Next(2));
                }
            }*/
            Console.WriteLine($"\t    Expected\t|    Actual\t|    Result\n\t----------------|---------------|----------------");
            for (int i = 0; i < bulbs.Count; i++)
            {
                int expected = CountSwitchesSolution(bulbs[i]);
                int actual = Program.CountSwitches(bulbs[i]);
                bool passed = expected == actual;
                Console.WriteLine($"Test{i+1}:\t\t{expected}\t|\t{actual}\t|\t{passed}");
            }
            Console.WriteLine();
        }
        private void RunWithDetails()
        {
            for (int j = 0; j < numberOfTests; j++)
            {
                Console.Write($"Test{j + 1}: [");
                int length = rand.Next(maxListSize);
                length = length > 0 ? length : length + 3;
                bulbs.Add(randomList.GenerateList(length));
                for (int i = 0; i < length; i++)
                {
                    //bulbs[j].Add(rand.Next(2));
                    Console.Write(bulbs[j][i] + ", ");
                }
                Console.WriteLine(bulbs[j][bulbs[j].Count - 1] + "]");
            }
            Console.WriteLine();
            /*for (int i = 0; i < bulbs.Count; i++)
            {
                Console.WriteLine($"Test{i + 1} Presses: {Program.CountSwitches(bulbs[i])}");
            }
            Console.WriteLine();*/
        }
        private int CountSwitchesSolution(List<int> argument)
        {
            int count = 0, find = 0;
            for (int i = 0; i < argument.Count; i++)
            {
                if (argument[i] == find)
                {
                    count++;
                    find = 1 - find;
                }
            }
            return count;
        }

        
        
    }
}
