int numberOfPages = int.Parse(Console.ReadLine());
int pagesPerHour = int.Parse(Console.ReadLine());
int days =  int.Parse(Console.ReadLine());
int neededHours = (numberOfPages / pagesPerHour) / days;
Console.WriteLine(neededHours);
