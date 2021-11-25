using System;

namespace _0509FibonacciNumber
{
    class Program
    {
        public int Fib(int n)
        {
            if (n <= 1)
            {
                return n;
            }
            return Fib(n - 1) + Fib(n - 2);
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            Console.WriteLine(p.Fib(2) + " || Answer should be 1");
            Console.WriteLine(p.Fib(3) + " || Answer should be 2");
            Console.WriteLine(p.Fib(4) + " || Answer should be 3");
        }
    }
}
