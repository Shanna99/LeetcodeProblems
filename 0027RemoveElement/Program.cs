using System;

namespace _0027RemoveElement
{
    class Program
    {
        public int RemoveElement(int[] nums, int val)
        {
            var countRemovedItems = 0;
            for(int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == val)
                {
                    nums[i] = 'x';
                    countRemovedItems++;
                }
            }
            foreach(var i in nums)
            {
                Console.WriteLine(i);
            }
            return nums.Length - countRemovedItems;
        }

        static void Main(string[] args)
        {
            Program p = new Program();
            int[] nums = new int[] { 3, 2, 2, 3 };
            Console.WriteLine(p.RemoveElement(nums, 3));

        }
    }
}
