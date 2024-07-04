string input = Console.ReadLine();
int result = 0;

for (int i = 0; i < input.Length; i++)
{
    if (input[i]=='a')
    {
        result += 1;
    }
    else if (input[i] == 'e')
    {
        result += 2;
    }
    else if (input[i] == 'i')
    {
        result += 3;
    }
    else if (input[i] == 'o')
    {
        result += 4;
    }
    else if (input[i] == 'u')
    {
        result += 5;
    }
}

Console.WriteLine(result);