using System;

namespace PrintDecimalInBinary
{
    class Program
    {
        //print een decimaal in binare vorm
        //divide the decimal number preatedly by 2 till it is reduced to 0
        //print the remainders in reverse order
        public void PrintBinary(int n)
        {
            if (n == 0)
            {
                return ;
            }
            PrintBinary(n /2);
            Console.WriteLine(n % 2);
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            p.PrintBinary(13);
        }
    }
}
