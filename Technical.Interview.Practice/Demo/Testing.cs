using System;
using System.Collections.Generic;
using System.Text;

namespace TechInterview.Practice.Demo
{
    class TestAnswer
    {
        List<List<int>> bulbs = new List<List<int>>();
        int randomSeed, numberOfTests, maxListSize;
        Random rand;
        public void RunForPassed()
        {
            for (int j = 0; j < numberOfTests; j++)
            {
                bulbs.Add(new List<int>());
                int length = rand.Next(maxListSize) + 3;
                for (int i = 0; i < length; i++)
                {
                    bulbs[j].Add(rand.Next(2));
                }
            }
            Console.WriteLine($"    Expected\t|    Actual\t|    Result\n----------------|---------------|----------------");
            for (int i = 0; i < bulbs.Count; i++)
            {
                int expected = CountSwitchesSolution(bulbs[i]);
                int actual = Program.CountSwitches(bulbs[i]);
                bool passed = expected == actual;
                Console.WriteLine($"\t{expected}\t|\t{actual}\t|\t{passed}");
            }
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
        public void RunWithDetails()
        {
            for (int j = 0; j < numberOfTests; j++)
            {
                Console.Write($"Test{j + 1}: [");
                bulbs.Add(new List<int>());
                int length = rand.Next(maxListSize) + 3;
                for (int i = 0; i < length; i++)
                {
                    bulbs[j].Add(rand.Next(2));
                    Console.Write(bulbs[j][i] + ", ");
                }
                Console.WriteLine(bulbs[j][bulbs[j].Count - 1] + "]");
            }
            for (int i = 0; i < bulbs.Count; i++)
            {
                Console.WriteLine($"Test{i} Presses: {Program.CountSwitches(bulbs[i])}");
            }
        }

        public TestAnswer(int randomSeed, int numberOfTests, int maxListSize)
        {
            this.randomSeed = randomSeed;
            this.numberOfTests = numberOfTests;
            this.maxListSize = maxListSize > 3 ? maxListSize : 3;
            rand = new Random(randomSeed);
        }

        public TestAnswer()
        {
            randomSeed = 1;
            numberOfTests = 10;
            maxListSize = 15;
            rand = new Random(randomSeed);
        }
        
    }
}
