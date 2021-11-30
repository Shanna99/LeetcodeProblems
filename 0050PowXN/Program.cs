using System;

namespace _0050PowXN
{
    class Program
    {
        public double MyPow(double x, int n)
        {
            if (n == 1)
            {
                return x;
            }
            if(n < 1)
            {
                return MyPow(x, n + 1) / x;
            }
           
            return MyPow(x, n - 1)  * x;
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            Console.WriteLine(p.MyPow(2, 10));
            Console.WriteLine(p.MyPow(0.00001, 214748367));

        }
    }
}
