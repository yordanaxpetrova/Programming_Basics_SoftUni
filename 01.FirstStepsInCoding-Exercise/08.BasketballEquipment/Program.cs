int yearlyTax = int.Parse(Console.ReadLine());
double shoes = yearlyTax - (yearlyTax * 0.4); //yearlyTax * 0.6
double outfit = shoes - (shoes * 0.2); //yearlyTax * 0.8
double ball = outfit / 4;
double accessories = ball / 5;
double sum = yearlyTax + shoes + outfit + ball + accessories;

Console.WriteLine(sum);