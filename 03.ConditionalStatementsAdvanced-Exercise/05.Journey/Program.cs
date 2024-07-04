double budget = double.Parse(Console.ReadLine());
string season = Console.ReadLine();

string destination = "";
string kindOfVacantion = "";
double amountSpent = 0;

switch (budget)
{
    case <= 100:
        destination = "Bulgaria";
        switch (season)
        {
            case "summer":
                kindOfVacantion = "Camp";
                amountSpent = budget * 0.30;
                break;
            case "winter":
                kindOfVacantion = "Hotel";
                amountSpent = budget * 0.70;
                break;
        }
        break;
    case <= 1000:
        destination = "Balkans";
        switch (season)
        {
            case "summer":
                kindOfVacantion = "Camp";
                amountSpent = budget * 0.40;
                break;
            case "winter":
                kindOfVacantion = "Hotel";
                amountSpent = budget * 0.80;
                break;
        }
        break;
    case > 1000:
        destination = "Europe";
        switch (season)
        {
            case "summer":
            case "winter":
                kindOfVacantion = "Hotel";
                amountSpent = budget * 0.90;
                break;
        }
        break;
};
Console.WriteLine($"Somewhere in {destination}");
Console.WriteLine($"{kindOfVacantion} - {amountSpent:F2}");