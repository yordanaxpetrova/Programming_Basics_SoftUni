string projectionType = Console.ReadLine();
int r = int.Parse(Console.ReadLine());
int c = int.Parse(Console.ReadLine());
double income = 0;

if(projectionType == "Premiere")
{
    income = r * c * 12.00;
}
else if (projectionType == "Normal")
{
    income = r * c * 7.50;
}
else if (projectionType == "Discount")
{
    income = r * c * 5.00;
}

Console.WriteLine($"{income:F2} leva");