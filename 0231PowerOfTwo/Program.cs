using System;

namespace _0231PowerOfTwo
{
    class Program
    {
        //accepted by leetcode
        public bool IsPowerOfTwo(int n)
        {
            if (n <= 0)
            {
                return false;
            }
            if (n > 1)
            {
                if (n % 2 == 1)
                {
                    return false;
                }
                return IsPowerOfTwo(n / 2);
            }
            return true;
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            Console.WriteLine(p.IsPowerOfTwo(16)); //true
            Console.WriteLine(p.IsPowerOfTwo(1)); //true
            Console.WriteLine(p.IsPowerOfTwo(12));//false
            Console.WriteLine(p.IsPowerOfTwo(8));//true
            Console.WriteLine(p.IsPowerOfTwo(5));//false
            Console.WriteLine(p.IsPowerOfTwo(64));//true
            Console.WriteLine(p.IsPowerOfTwo(0));//false
        }
    }
}
