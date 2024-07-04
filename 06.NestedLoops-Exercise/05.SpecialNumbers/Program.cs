int n = int.Parse(Console.ReadLine());

for (int i = 1; i <= 9; i++)
{
    for (int j = 1; j <= 9; j++)
    {
        for (int k = 1; k <= 9; k++)
        {
            for (int l = 1; l <= 9; l++)
            {
                bool withoutRemainder = n % l == 0 && n % k == 0 && n % j == 0 && n % i == 0;
                if (withoutRemainder)
                {
                    int specialN = i * 1000 + j * 100 + k * 10 + l;
                    Console.Write(specialN + " ");
                }
            }
        }
    }
}