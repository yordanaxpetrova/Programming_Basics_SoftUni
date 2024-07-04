double budget = double.Parse(Console.ReadLine());
int videoCards = int.Parse(Console.ReadLine());
int processors = int.Parse(Console.ReadLine());
int ramMemory = int.Parse(Console.ReadLine());
double sum = (videoCards * 250) + (processors * (videoCards * 250 * 0.35)) + (ramMemory * (videoCards * 250 * 0.10));

if (videoCards > processors)
{
    sum -= sum * 0.15;
}

if (sum <= budget)
{
    Console.WriteLine($"You have {budget - sum:f2} leva left!");
}
else
{
    Console.WriteLine($"Not enough money! You need {sum - budget:f2} leva more!");
}