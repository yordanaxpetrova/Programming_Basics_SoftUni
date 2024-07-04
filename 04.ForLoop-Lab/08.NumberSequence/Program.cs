int n = int.Parse(Console.ReadLine());
int maxN = int.MinValue, minN = int.MaxValue;

for (int i = 0; i < n; i++)
{
    int num = int.Parse(Console.ReadLine());
    if (num > maxN)
    { maxN = num; }
    if (num < minN)
    { minN = num; }
}
Console.WriteLine($"Max number: {maxN}");
Console.WriteLine($"Min number: {minN}");