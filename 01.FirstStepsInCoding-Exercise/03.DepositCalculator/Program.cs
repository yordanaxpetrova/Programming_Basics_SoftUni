double depositedAmount = double.Parse(Console.ReadLine());
int depositTerm = int.Parse(Console.ReadLine());
double annualInterestRate = double.Parse(Console.ReadLine());
double sum = depositedAmount + depositTerm * ((depositedAmount * (annualInterestRate) / 100 ) / 12);
Console.WriteLine(sum);