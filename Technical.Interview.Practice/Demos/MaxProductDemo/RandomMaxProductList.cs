using System;
using System.Collections.Generic;
using System.Text;

namespace TechInterview.Practice.Demos.MaxProductDemo
{
    class RandomMaxProductList
    {
        private int seed, size, range, offset;
        private Random rand;
        public RandomMaxProductList()
        {
            seed = 1;
            range = 41;
            offset = -20;
            rand = new Random(seed);
        }
        public RandomMaxProductList(int seed, int range, int offset)
        {
            this.seed = seed;
            this.range = range;
            this.offset = offset;
            rand = new Random(this.seed);
        }
        
        public List<int> GenerateList()
        {
            List<int> ret = new List<int>();
            for (int i = 0; i < size; i++)
            {
                ret.Add(rand.Next(range) - offset);
            }
            return ret;
        }

        public List<int> GenerateList(int size)
        {
            List<int> ret = new List<int>();
            for(int i = 0; i < size; i++)
            {
                ret.Add(rand.Next(range) - offset);
            }
            return ret;
        }
    }
}
