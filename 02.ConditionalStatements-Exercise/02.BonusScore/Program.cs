int startingPoints = int.Parse(Console.ReadLine());
double bonusPoints = 0.0;

if (startingPoints <= 100)
{
    bonusPoints = 5;
}
else if (startingPoints <= 1000)
{
    bonusPoints = startingPoints * 0.2;
}
else if (startingPoints > 1000)
{
    bonusPoints = startingPoints * 0.1;
}

if(startingPoints % 2 == 0)
{
    bonusPoints += 1;
}
else if (startingPoints % 10 == 5)
{
    bonusPoints += 2;
}

Console.WriteLine($"{bonusPoints:f1}");
Console.WriteLine($"{(startingPoints + bonusPoints):f1}");