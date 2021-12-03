using System;
using System.Collections.Generic;
using System.Linq;

namespace _1431KidsWithGreatestNumberOfCandy
{
    class Program
    {

        public IList<bool> KidsWithCandies(int[] candies, int extraCandies)
        {
            List<bool> list = new List<bool>();
            int max = candies.Max();

            for (int i = 0; i < candies.Count(); i++)
            {
                if (candies[i] + extraCandies >= max)
                {
                    list.Add(true);
                }
                else
                {
                    list.Add(false);
                }
            }
            return list;
        }

        static void Main(string[] args)
        {
            Program p = new Program();
            int[] candies = new int[] { 2, 3, 5, 1, 3 };
            var x =p.KidsWithCandies(candies, 3);

            foreach(var i in x)
            {
                Console.WriteLine(  i);
            }
        }
    }
}
