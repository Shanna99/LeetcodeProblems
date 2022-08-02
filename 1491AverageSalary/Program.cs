// See https://aka.ms/new-console-template for more information
//accepted, 128ms 45,54% faster than others
double Average(int[] salary)
{
    double max = salary.Max();
    double min = salary.Min();
    double sum = 0;
    for (int i = 0; i < salary.Length; i++)
    {
        if (salary[i] != min && salary[i] != max)
        {
            sum += salary[i];
        }
    }

    return Math.Abs(sum / (salary.Length - 2));

}
int[] sal = { 48000, 59000, 99000, 13000, 78000, 45000, 31000, 17000, 39000, 37000, 93000, 77000, 33000, 28000, 4000, 54000, 67000, 6000, 1000, 11000 };
var x = Average(sal);
Console.WriteLine(x);
Console.WriteLine("Hello, World!");
