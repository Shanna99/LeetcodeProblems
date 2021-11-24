using System;

namespace _1512NumberOfGoodPairs
{
    //accepted by leetcode
    class Program
    {
        public int NumIdenticalPairs(int[] nums)
        {
            int count = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = 1; j < nums.Length; j++)
                {
                    if(nums[i] == nums[j] && i < j)
                    {
                        count++;
                    }
                }
            }
            return count;
        }

        static void Main(string[] args)
        {
            Program p = new Program();
            int[] nums = { 1, 2, 3, 1, 1, 3 };
            var x = p.NumIdenticalPairs(nums);
            Console.WriteLine(x);
        }
    }
}
