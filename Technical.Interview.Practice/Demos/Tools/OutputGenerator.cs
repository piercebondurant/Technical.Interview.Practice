using System;
using System.Collections.Generic;
using System.Text;

namespace TechInterview.Practice.Demos.Tools
{
    class OutputGenerator
    {
        List<int> resultSet, expectedSet;
        public OutputGenerator(List<int> resultSet, List<int> expectedSet) 
        {
            this.resultSet = new List<int>(resultSet);
            this.expectedSet = new List<int>(expectedSet);
        }
        public void Print() 
        {
            Console.WriteLine($"\t    Expected\t|    Actual\t|    Result\n\t----------------|---------------|----------------");
            for (int i = 0; i < expectedSet.Count; i++)
            {
                int expected = expectedSet[i];
                int actual = resultSet[i];
                bool passed = expected == actual;
                Console.WriteLine($"Test{i + 1}:\t\t{expected}\t|\t{actual}\t|\t{passed}");
            }
            Console.WriteLine();
        }
    }
}
