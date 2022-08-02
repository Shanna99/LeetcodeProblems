// See https://aka.ms/new-console-template for more information

//accepted by leetcode, 21 ms runtime 97,02% faster than other 
int CountOdds(int low, int high)
{
    int count = (high - low) / 2;
    if (low % 2 == 1 || high % 2 == 1)
    {
        count++;
    }

    return count;
}

var y = CountOdds(3, 7);
var x = CountOdds(8, 1000000000);
Console.WriteLine(x);

Console.WriteLine("Hello, World!");
