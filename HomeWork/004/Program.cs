﻿/* Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

5 -> 2, 4
8 -> 2, 4, 6, 8
*/



Console.WriteLine("input digit");
int N = Convert.ToInt32(Console.ReadLine());

int chislo = 2;

while (chislo <= N)
{
    Console.Write(chislo + " ");
    chislo +=2;
}

