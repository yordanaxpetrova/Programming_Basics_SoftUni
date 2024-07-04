double n1 = double.Parse(Console.ReadLine());
double n2 = double.Parse(Console.ReadLine());
char symbol = char.Parse(Console.ReadLine());
double result = 0;

switch (symbol)
{
    case '/':
        if (n2 == 0)
        {
            Console.WriteLine($"Cannot divide {n1} by zero");
        }
        else
        {
            result = n1 / n2;
            Console.WriteLine($"{n1} {symbol} {n2} = {result:F2}");
        }
        break;
    case '%':
        if (n2 == 0)
        {
            Console.WriteLine($"Cannot divide {n1} by zero");
        }
        else
        {
            result = n1 % n2;
            Console.WriteLine($"{n1} {symbol} {n2} = {result}");
        }
        break;
    case '+':
        result = n1 + n2;
        if (result % 2 == 0)
        {
            Console.WriteLine($"{n1} {symbol} {n2} = {result} - even");
        }
        else
        {
            Console.WriteLine($"{n1} {symbol} {n2} = {result} - odd");
        }
        break;
    case '-':
        result = n1 - n2;
        if (result % 2 == 0)
        {
            Console.WriteLine($"{n1} {symbol} {n2} = {result} - even");
        }
        else
        {
            Console.WriteLine($"{n1} {symbol} {n2} = {result} - odd");
        }
        break;
    case '*':
        result = n1 * n2;
        if (result % 2 == 0)
        {
            Console.WriteLine($"{n1} {symbol} {n2} = {result} - even");
        }
        else
        {
            Console.WriteLine($"{n1} {symbol} {n2} = {result} - odd");
        }
        break;
}