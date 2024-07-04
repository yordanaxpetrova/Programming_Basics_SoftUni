string month = Console.ReadLine();
int overnightStays = int.Parse(Console.ReadLine());
double studio = 0;
double apartment = 0;
double finalStudioPrice = 0;
double finalApartmentPrice = 0;

switch (month)
{
    case "May":
    case "October":
        studio = 50;
        apartment = 65;
        finalStudioPrice = overnightStays * studio;
        finalApartmentPrice = overnightStays * apartment;
        if (overnightStays > 7 && overnightStays <= 14)
        {
            finalStudioPrice -= finalStudioPrice * 0.05;
        }
        else if (overnightStays > 14)
        {
            finalStudioPrice -= finalStudioPrice * 0.30;
        }
        break;
    case "June":
    case "September":
        studio = 75.20;
        apartment = 68.70;
        finalStudioPrice = overnightStays * studio;
        finalApartmentPrice = overnightStays * apartment;
        if (overnightStays > 14)
        {
            finalStudioPrice -= finalStudioPrice * 0.20;
        }
        break;
    case "July":
    case "August":
        studio = 76;
        apartment = 77;
        finalStudioPrice = overnightStays * studio;
        finalApartmentPrice = overnightStays * apartment;
        break;
};
if (overnightStays > 14)
{
    finalApartmentPrice -= finalApartmentPrice * 0.10;
}

Console.WriteLine($"Apartment: {finalApartmentPrice:F2} lv.");
Console.WriteLine($"Studio: {finalStudioPrice:F2} lv.");