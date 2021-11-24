using System;

namespace _0405ConvertNumberToHexadecimal
{
    class Program
    {
        public string ToHex(int num)
        {
            Console.WriteLine(num);
            if(num <16)
            {
                return "";
            }
            return ToHex(num-16);
        }

        static void Main(string[] args)
        {
            Program p = new Program();
            var x = p.ToHex(956); //3bc
            var y = p.ToHex(107); //6b
            var z = p.ToHex(58); //3a
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);
        }
    }
}
