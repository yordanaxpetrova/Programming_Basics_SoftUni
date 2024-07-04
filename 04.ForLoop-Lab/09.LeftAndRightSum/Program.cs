int n = int.Parse(Console.ReadLine());
int firstResult = 0, otherResult = 0;

for (int i = 0; i < n; i++)
{
    int num = int.Parse(Console.ReadLine());
    firstResult += num;
}

for (int i = 0; i < n; i++)
{
    int num = int.Parse(Console.ReadLine());
    otherResult += num;
}

if (otherResult != firstResult)
{
    Console.WriteLine($"No, diff = {Math.Abs(firstResult - otherResult)}");
}
else
{
    Console.WriteLine($"Yes, sum = {firstResult}");
}