﻿int n = int.Parse(Console.ReadLine());
int result = 0;
for (int i = 0; i < n; i++)
{
    int num = int.Parse(Console.ReadLine());
    result += num;
}
Console.WriteLine(result);