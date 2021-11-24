using System;

namespace _0326PowerOfThree
{
    class Program
    {

        //accepted by leetcode
        public bool IsPowerOfThree(int n)
        {
            if (n <= 0)
            {
                return false;
            }

            if (n >= 2)
            {
                if (n % 3 != 0)
                {
                    return false;
                }
                return IsPowerOfThree(n / 3);
            }
            return true;
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            Console.WriteLine(p.IsPowerOfThree(27) + " || Must be true (27)");
            Console.WriteLine(p.IsPowerOfThree(0) + " || Must be false (0)");
            Console.WriteLine(p.IsPowerOfThree(9) + " || Must be true (9)");
            Console.WriteLine(p.IsPowerOfThree(45) + " || Must be false (45)");
            Console.WriteLine(p.IsPowerOfThree(1) + " || Must be true (1)");
            Console.WriteLine(p.IsPowerOfThree(5) + " || Must be false (5)");
            Console.WriteLine(p.IsPowerOfThree(6) + " || Must be false (6)");
            Console.WriteLine(p.IsPowerOfThree(12) + " || Must be false (12)");
            Console.WriteLine(p.IsPowerOfThree(2) + " || Must be false (2)");
        }
    }
}
