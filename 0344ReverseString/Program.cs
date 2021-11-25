using System;

namespace _0344ReverseString
{
    //accepted by leetcode, 99,49% faster than other c# contributions 
    class Program
    {

        public void ReverseString(char[] s)
        {
            if (s.Length <= 0)
            {
                return;
            }
            ReverseString(s, 0, s.Length - 1);
        }

        public void ReverseString(char[] s, int i, int j)
        {
            if (i >= j)
            {
                return;
            }
            var temp = s[i];
            s[i] = s[j];
            s[j] = temp;
            ReverseString(s, ++i, --j);
        }

        static void Main(string[] args)
        {
            Program p = new Program();
            char[] input = new char[] { 'h', 'e', 'l', 'l', 'o' };
            p.ReverseString(input);

            foreach(var i in input)
            {
                Console.WriteLine(i);
            }

            Solution2 s2 = new Solution2();
            s2.ReverseString(input);

            foreach (var i in input)
            {
                Console.WriteLine(i);
            }
        }
    }
}
