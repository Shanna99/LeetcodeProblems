using System;

namespace _0070ClimbStairs
{
    class Program
    {

        public int ClimbStairs(int n)
        {
            if(n <= 0)
            {
                return 0;
            }

            return ClimbStairs(n - 1) + 1;
        }

        public int ClimbStairs2(int n)
        {
            if (n <= 1)
            {
                return 1;
            }

            return ClimbStairs2(n - 2) + 1;
        }

        static void Main(string[] args)
        {
            Program p = new Program();

            Console.WriteLine(p.ClimbStairs(2));
            Console.WriteLine(p.ClimbStairs(3));
            Console.WriteLine(p.ClimbStairs(4));
            Console.WriteLine(p.ClimbStairs(5));

            Console.WriteLine("---");
            Console.WriteLine(p.ClimbStairs2(2));
            Console.WriteLine(p.ClimbStairs2(3));
            Console.WriteLine(p.ClimbStairs2(4));
            Console.WriteLine(p.ClimbStairs2(5));
        }
    }
}
