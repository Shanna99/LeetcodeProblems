using System;

namespace _0013RomanToInt
{
    class Program
    {
        //Accepted by leetcode
        //Runtime: 80 ms, faster than 72.54% of C# online submissions for Roman to Integer.
        public int RomanToInt(string s)
        {
            int sum = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == 'I')
                {
                    if (i < s.Length - 1 && s[i + 1] != 'I')
                    {
                        sum -= 1;
                    }
                    else
                    {
                        sum += 1;
                    }
                }
                if (s[i] == 'V')
                {
                    sum += 5;
                }
                if (s[i] == 'X')
                {
                    if (i < s.Length - 1 && (s[i + 1] != 'X' && s[i + 1] != 'I' && s[i + 1] != 'V'))
                    {
                        sum -= 10;
                    }
                    else
                    {
                        sum += 10;
                    }
                }

                if (s[i] == 'L')
                {
                    sum += 50;
                }
                if (s[i] == 'C')
                {
                    if (i < s.Length - 1 && (s[i + 1] != 'C' && s[i + 1] != 'I' && s[i + 1] != 'X' && s[i + 1] != 'V' && s[i + 1] != 'L'))
                    {
                        sum -= 100;
                    }
                    else
                    {
                        sum += 100;
                    }
                }
                if (s[i] == 'D')
                {
                    sum += 500;
                }

                if (s[i] == 'M')
                {
                    sum += 1000;
                }
            }

            return sum;
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            string s1 = "I"; //1
            string s2 = "IV"; //4
            string s3 = "V"; //5
            string s4 = "VI"; //6
            string s5 = "XXVII"; //27
            string s6 = "X"; //10
            string s7 = "IX"; //9
            string s8 = "XL"; //40
            string s9 = "XC"; //90
            string s10 = "CD"; //400
            string s11 = "CM"; //900
            Console.WriteLine(p.RomanToInt(s1));
            Console.WriteLine(p.RomanToInt(s2));
            Console.WriteLine(p.RomanToInt(s3));
            Console.WriteLine(p.RomanToInt(s4));
            Console.WriteLine(p.RomanToInt(s5));
            Console.WriteLine(p.RomanToInt(s6));
            Console.WriteLine(p.RomanToInt(s7));
            Console.WriteLine(p.RomanToInt(s8));
            Console.WriteLine(p.RomanToInt(s9));
            Console.WriteLine(p.RomanToInt(s10));
            Console.WriteLine(p.RomanToInt(s11));
            Console.WriteLine(p.RomanToInt("MCMXCIV"));
            Console.WriteLine(p.RomanToInt("DCXXI"));
            Console.WriteLine(p.RomanToInt("MCMXCVI"));
            Console.WriteLine(p.RomanToInt("MDCCCLXXXIV"));
            Console.WriteLine(p.RomanToInt("MCDLXXVI"));
        }
    }
}
