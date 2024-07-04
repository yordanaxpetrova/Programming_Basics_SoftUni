string kindOfFlowers = Console.ReadLine();
int numberOfFlowers = int.Parse(Console.ReadLine());
int budget = int.Parse((Console.ReadLine()));

double rose = 5.00;
double dahlia = 3.80;
double tulip = 2.80;
double narcissus = 3.00;
double gladiolus = 2.50;

double finalPrice = 0;

if (numberOfFlowers >= 10 && numberOfFlowers <= 1000 && budget >= 50 && budget <= 2500)
{
    if (kindOfFlowers == "Roses")
    {
        if (numberOfFlowers > 80)
        {
            finalPrice = rose * numberOfFlowers;
            finalPrice -= finalPrice * 0.10;
        }
        else
        {
            finalPrice = rose * numberOfFlowers;
        }
    }
    else if (kindOfFlowers == "Dahlias")
    {
        if (numberOfFlowers > 90)
        {
            finalPrice = dahlia * numberOfFlowers;
            finalPrice -= finalPrice * 0.15;
        }
        else
        {
            finalPrice = dahlia * numberOfFlowers;
        }
    }
    else if (kindOfFlowers == "Tulips")
    {
        if (numberOfFlowers > 80)
        {
            finalPrice = tulip * numberOfFlowers;
            finalPrice -= finalPrice * 0.15;
        }
        else
        {
            finalPrice = tulip * numberOfFlowers;
        }
    }
    else if (kindOfFlowers == "Narcissus")
    {
        if (numberOfFlowers < 120)
        {
            finalPrice = narcissus * numberOfFlowers;
            finalPrice += finalPrice * 0.15;
        }
        else
        {
            finalPrice = narcissus * numberOfFlowers;
        }
    }
    else if (kindOfFlowers == "Gladiolus")
    {
        if (numberOfFlowers < 80)
        {
            finalPrice = gladiolus * numberOfFlowers;
            finalPrice += finalPrice * 0.20;
        }
        else
        {
            finalPrice = gladiolus * numberOfFlowers;
        }
    }
}

if (finalPrice <= budget)
{
    Console.WriteLine($"Hey, you have a great garden with {numberOfFlowers} {kindOfFlowers} and {budget - finalPrice:F2} leva left.");
}
else
{
    Console.WriteLine($"Not enough money, you need {finalPrice - budget:F2} leva more.");
}