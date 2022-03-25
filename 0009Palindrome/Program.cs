using System;

namespace _0013RomanToInt
{
    class Program
    {
        //Runtime: 28 ms, faster than 99.63% of C# online submissions for Palindrome Number.
        public bool GetDigits(int x, List<int> list)
        {
            if (x <= 0)
            {
                return false;
            }

            list.Add(x % 10);
            return GetDigits(x / 10, list);
        }
        public bool IsPalindrome(int x)
        {
            if (x == 0)
            {
                return true;
            }
            List<int> list = new List<int>();
            GetDigits(x, list);
            string ass = "";
            string des = "";
            for(int i = 0; i < list.Count; i++)
            {
                ass+= list[i].ToString();
            }

            for (int i = list.Count - 1; i >= 0; i--)
            {
                des += list[i].ToString();
            }
           
            if (ass==des && (ass != "" &des != "")){
                return true;
            }
           
            return false;
        }


        static void Main(string[] args)
        {
            Program p = new Program();

            Console.WriteLine(p.IsPalindrome(121)); //true
            Console.WriteLine(p.IsPalindrome(122)); //false
            Console.WriteLine(p.IsPalindrome(222)); //true
            Console.WriteLine(p.IsPalindrome(33)); //true
            Console.WriteLine(p.IsPalindrome(-121)); //false
            Console.WriteLine(p.IsPalindrome(0)); //false


        }
    }
}
