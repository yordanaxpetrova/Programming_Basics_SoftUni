string movie = Console.ReadLine();

int studentsTickets = 0;
int standartsTickets = 0;
int kidsTickets = 0;

while (movie != "Finish")
{
    int freeTickets = int.Parse(Console.ReadLine());
    int soldTickets = 0;

    string ticketType = Console.ReadLine();
    while (ticketType != "End")
    {
        soldTickets++;

        switch (ticketType)
        {
            case "student":
                studentsTickets++;
                break;
            case "standard":
                standartsTickets++;
                break;
            case "kid":
                kidsTickets++;
                break;
            default:
                break;
        }

        if (soldTickets == freeTickets)
        {
            break;
        }

        ticketType = Console.ReadLine();
    }

    Console.WriteLine($"{movie} - {(double)soldTickets / freeTickets * 100:f2}% full.");
    movie = Console.ReadLine();
}

double tickets = studentsTickets + standartsTickets + kidsTickets;
Console.WriteLine($"Total tickets: {tickets}");
Console.WriteLine($"{studentsTickets / tickets * 100:f2}% student tickets.");
Console.WriteLine($"{standartsTickets / tickets * 100:f2}% standard tickets.");
Console.WriteLine($"{kidsTickets / tickets * 100:f2}% kids tickets.");