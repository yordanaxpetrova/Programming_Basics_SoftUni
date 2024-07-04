int firstN = int.Parse(Console.ReadLine());
int secondN = int.Parse(Console.ReadLine());

for (int i = firstN; i <= secondN; i++)
{
    int evenSum = 0;
    int oddSum = 0;

    string currentN = i.ToString();

    for (int j = 0;j<6;j++)
    {
        if (j % 2 == 0)
        {
            evenSum += currentN[j];
        }
        else
        {
            oddSum += currentN[j];
        }
    }

    if (evenSum == oddSum)
    {
        Console.Write(currentN + " ");
    }
}