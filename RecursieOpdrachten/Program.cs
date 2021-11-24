using System;

namespace RecursieOpdrachten
{

    class Program
    {

        // Hoe vaak spatie + d
        // "Dit doet het goed" : 1
        // "Deze niet": 0
        // "bla doe die"  : 2


        public int CountD(string s)
        {
            //if s == null return 0;
            //if s[0] ! ' ' return CountD(s.trim(0)) 
            //if s[0]  ' ' && s[1].toUpper d return CountD(s.trim(0) +1
            if (s.Length > 1)
            {
                if (s[0] != ' ')
                {
                    return CountD(s.Substring(1));
                }
                if (s[0] == ' ' && (s[1] == 'd' || s[1] == 'D'))
                {
                    return CountD(s.Substring(1)) + 1;
                }
            }

            return 0;
        }

        //recursief van int een string
        //altijd groter of gelijk dan 0
        public string ConvertIntToString(int input)
        {
            if (input > 9)
            {
                return ConvertIntToString(input / 10) + $"{input % 10}";
            }

            return $"{input}";
        }

        //recursief van string naar int
        public int ConvertStringToInt(string input)
        {
            if (input.Length > 0)
            {
                if (Char.IsDigit(input[0]))
                {
                    int x = CharToInt(input[0]);
                    return ConvertStringToInt(input.Substring(1)) ;
                }
            }
            return 0;
        }

        public static int CharToInt(char c)
        {
            return c - '0';
        }


        static void Main(string[] args)
        {
            Program p = new Program();
            string s1 = "Dit doet het goed";
            string s2 = "Deze niet";
            string s3 = "bla doe die";
            string s4 = " ";
            var x = p.CountD(s3);
            //Console.WriteLine(x);

            string y = p.ConvertIntToString(90970);
            string o = p.ConvertIntToString(9);
            string u = p.ConvertIntToString(0);
            string k = p.ConvertIntToString(10);
            string l = p.ConvertIntToString(99);
            //Console.WriteLine(y);
            //Console.WriteLine(o);
            //Console.WriteLine(u);
            //Console.WriteLine(k);
            //Console.WriteLine(l);

            var a = p.ConvertStringToInt("12");
            var b = p.ConvertStringToInt("1760");
            var c = p.ConvertStringToInt("0");
            var d = p.ConvertStringToInt("9");
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.WriteLine(d);

            string s = "1234";
            //Console.WriteLine(CharToInt(s.ToCharArray()[1]));

        }
    }
}
