int numberTournaments = int.Parse(Console.ReadLine());
int amountPoints = int.Parse(Console.ReadLine());

int wCounter = 0;
int amountPointss = 0;

for (int i = 1; i <= numberTournaments; i++)
{
    string stage = Console.ReadLine();

    if (stage == "W")
    {
        amountPointss += 2000;
        wCounter++;
    }
    else if (stage == "F")
    {
        amountPointss += 1200;
    }
    else if (stage == "SF")
    {
        amountPointss += 720;
    }
}

Console.WriteLine($"Final points: {amountPointss + amountPoints}");
Console.WriteLine($"Average points: {Math.Floor((double)amountPointss / numberTournaments)}");
Console.WriteLine($"{(double)wCounter / numberTournaments * 100:f2}%");