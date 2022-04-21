using System;

int N = int.Parse(Console.ReadLine());
int B = -N;
while (B<=N)
{
    Console.Write($"{B} ");
    B+=1;
}