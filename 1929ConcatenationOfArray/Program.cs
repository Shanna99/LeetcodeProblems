using System;

namespace _1929ConcatenationOfArray
{
    //accepted by leetcode
    class Program
    {
        public int[] GetConcatenation(int[] nums)
        {
            int[] ans = new int[nums.Length * 2];
            for (int i = 0; i < nums.Length; i++)
            {
                ans[i] = nums[i];
            }

            int count = 0;
            for (int i = nums.Length; i < nums.Length * 2; i++)
            {
                ans[i] = nums[count];
                count++;
            }
            return ans;
        }

        static void Main(string[] args)
        {
            Program p = new Program();
            int[] nums = { 1, 3, 2, 1 };
            var x = p.GetConcatenation(nums);
            foreach (var i in x)
            {
                Console.WriteLine(i);
            }
        }
    }
}
