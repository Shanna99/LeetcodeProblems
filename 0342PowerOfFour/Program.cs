using System;

namespace _0342PowerOfFour
{
    class Program
    {
        //accepted by leetcode
        public bool IsPowerOfFour(int n)
        {
            if (n <= 0)
            {
                return false;
            }
            if (n > 1)
            {
                if (n % 4 != 0)
                {
                    return false;
                }
                return IsPowerOfFour(n / 4);
            }
            return true;
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            Console.WriteLine(p.IsPowerOfFour(1) + " || Must be true (1)");
            Console.WriteLine(p.IsPowerOfFour(16) + " || Must be true (16)");
            Console.WriteLine(p.IsPowerOfFour(5) + " || Must be false (5)");
            Console.WriteLine(p.IsPowerOfFour(2) + " || Must be false (2)");
            Console.WriteLine(p.IsPowerOfFour(8) + " || Must be false (8)");
            Console.WriteLine(p.IsPowerOfFour(3) + " || Must be false (3)");
            Console.WriteLine(p.IsPowerOfFour(12) + " || Must be false (12)");
            Console.WriteLine(p.IsPowerOfFour(64) + " || Must be true (64)");
            Console.WriteLine(p.IsPowerOfFour(6) + " || Must be false (6)");
        }
    }
}
