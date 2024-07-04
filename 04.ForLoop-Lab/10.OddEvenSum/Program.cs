int n = int.Parse(Console.ReadLine());
int evenResult = 0, oddResult = 0;

for (int i = 1; i <= n; i++)
{
    if (i % 2 == 0)
    {
        int num = int.Parse(Console.ReadLine());
        evenResult += num;
    }
    else
    {
        int num = int.Parse(Console.ReadLine());
        oddResult += num;
    }
}

if (evenResult == oddResult)
{
    Console.WriteLine("Yes");
    Console.WriteLine($"Sum = {evenResult}");
}
else
{
    Console.WriteLine("No");
    Console.WriteLine($"Diff = {Math.Abs(evenResult-oddResult)}");
}
