using System;

namespace _0012IntToRoman
{
    class Program
    {
        public string IntToRoman(int num)
        {
            if(num > 9)
            {
                if(num%10 == 1)
                {

                }
                return IntToRoman(num / 10) + $"{num%10}";
            }

            return $"{num}";
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            int s1 = 1; //1
            int s2 = 4; //4
            int s3 = 5; //5
            int s4 = 6; //6
            int s5 = 27; //27
            int s6 = 10; //10
            int s7 = 9; //9
            int s8 = 40; //40
            int s9 = 90; //90
            int s10 = 400; //400
            int s11 = 900; //900
            Console.WriteLine(p.IntToRoman(s1));
            Console.WriteLine(p.IntToRoman(s2));
            Console.WriteLine(p.IntToRoman(s3));
            Console.WriteLine(p.IntToRoman(s4));
            Console.WriteLine(p.IntToRoman(s5));
            Console.WriteLine(p.IntToRoman(s6));
            Console.WriteLine(p.IntToRoman(s7));
            Console.WriteLine(p.IntToRoman(s8));
            Console.WriteLine(p.IntToRoman(s9));
            Console.WriteLine(p.IntToRoman(s10));
            Console.WriteLine(p.IntToRoman(s11));
        }
    }
}
