int start = int.Parse(Console.ReadLine());
int end = int.Parse(Console.ReadLine());
int magicN = int.Parse(Console.ReadLine());
int combinations = 0;
bool flag = false;

for (int i = start; i <= end; i++)
{
    for (int j = start; j <= end; j++)
    {
        combinations++;
        if (i+j==magicN)
        {
            flag = true;
            Console.WriteLine($"Combination N:{combinations} ({i} + {j} = {magicN})");
            break;
        }
    }

    if(flag)
    { break; }
}

if (!flag)
{ 
    Console.WriteLine($"{combinations} combinations - neither equals {magicN}"); 
}
