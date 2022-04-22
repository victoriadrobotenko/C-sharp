/*
Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

645 -> 5

78 -> третьей цифры нет

32679 -> 6
*/

using System;
using static System.Console;


WriteLine("input three digit number");
string num = (ReadLine());

int length = num.Length;

if (length < 3)
{
    WriteLine("it isnt a three digit number");
}
else
{
    WriteLine(num[2]);
}


// 2th
WriteLine("input three digit number");
int iNum = Convert.ToInt32(ReadLine());

if (iNum < 100)
{
    WriteLine("it isnt a three digit number");
}
else
{
    while (iNum > 999)
    {
        iNum = iNum / 10; // index /= 10
    }
    WriteLine(iNum % 10);
}
