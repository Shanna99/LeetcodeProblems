using System;

namespace _1470ShuffleTheArray
{
    //accepted by leetcode
    class Program
    {
        public int[] Shuffle(int[] nums, int n)
        {
            int[] ans = new int[nums.Length];
            int[] xArray = new int[n];
            int[] yArray = new int[n];

            //vul xarr
            for (int i = 0; i < n; i++)
            {
                xArray[i] = nums[i];
            }

            var count = 0;
            //vul yarr
            for (int i = 0; i < n; i++)
            {
                yArray[i] = nums[n + count];
                count++;
            }

            count = 0;
            //add values to 1 arr
            for (int i = 0; i < nums.Length; i++)
            {
                if (count > n)
                {
                    break;
                }

                //if even, add x value, else add y value
                if (i % 2 == 0)
                {
                    ans[i] = xArray[count];
                }
                else
                {
                    ans[i] = yArray[count];
                    count++;
                }

            }

            return ans;
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            int[] nums = { 2, 5, 1, 3, 4, 7 };
            var x = p.Shuffle(nums, 3);
            foreach (var i in x)
            {
                Console.WriteLine(i);
            }
        }
    }
}
