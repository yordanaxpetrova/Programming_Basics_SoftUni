string seriesName = Console.ReadLine();
double seriesTime = double.Parse(Console.ReadLine());
int lunchBreakTime = int.Parse(Console.ReadLine());

double freeTime = lunchBreakTime - ((double)lunchBreakTime / 8) - ((double)lunchBreakTime / 4);

if (freeTime >= seriesTime)
{
    freeTime -= seriesTime;
    Console.WriteLine($"You have enough time to watch {seriesName} and left with {Math.Ceiling(freeTime)} minutes free time.");
}
else
{
    seriesTime -= freeTime;
    Console.WriteLine($"You don't have enough time to watch {seriesName}, you need {Math.Ceiling(seriesTime)} more minutes.");
}