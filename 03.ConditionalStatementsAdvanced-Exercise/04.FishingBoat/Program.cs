int budget = int.Parse(Console.ReadLine());
string season = Console.ReadLine();
int fishermen = int.Parse(Console.ReadLine());

double shipCharterPrice = 0;
double finalPrice = 0;

switch (season)
{
    case "Spring":
        shipCharterPrice = 3000;
        finalPrice += shipCharterPrice;
        if (fishermen <= 6)
        {
            finalPrice -= finalPrice * 0.10;
        }
        else if (fishermen >= 7 && fishermen <= 11)
        {
            finalPrice -= finalPrice * 0.15;
        }
        else if (fishermen >= 12)
        {
            finalPrice -= finalPrice * 0.25;
        }
        break;
    case "Summer":
    case "Autumn":
        shipCharterPrice = 4200;
        finalPrice += shipCharterPrice;
        if (fishermen <= 6)
        {
            finalPrice -= finalPrice * 0.10;
        }
        else if (fishermen >= 7 && fishermen <= 11)
        {
            finalPrice -= finalPrice * 0.15;
        }
        else if (fishermen >= 12)
        {
            finalPrice -= finalPrice * 0.25;
        }
        break;
    case "Winter":
        shipCharterPrice = 2600;
        finalPrice += shipCharterPrice;
        if (fishermen <= 6)
        {
            finalPrice -= finalPrice * 0.10;
        }
        else if (fishermen >= 7 && fishermen <= 11)
        {
            finalPrice -= finalPrice * 0.15;
        }
        else if (fishermen >= 12)
        {
            finalPrice -= finalPrice * 0.25;
        }
        break;
    default:
        break;
};

if (fishermen % 2 == 0 && season != "Autumn")
{
    finalPrice -= finalPrice * 0.05;
}

if (budget >= finalPrice)
{
    Console.WriteLine($"Yes! You have {budget - finalPrice:F2} leva left.");
}
else
{
    Console.WriteLine($"Not enough money! You need {finalPrice - budget:F2} leva.");
}