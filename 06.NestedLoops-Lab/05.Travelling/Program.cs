string destination = Console.ReadLine();

while(destination!="End")
{
    double neededMoney = double.Parse(Console.ReadLine());
    double savedMoney = 0; 

    while (savedMoney < neededMoney)
    {
        double addedMoney = double.Parse((Console.ReadLine()));
        savedMoney += addedMoney;
    }

    Console.WriteLine($"Going to {destination}!");

    destination = Console.ReadLine();
}