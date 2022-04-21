/*
Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет
*/


using System;
using static System.Console;


WriteLine("input number of day of week");
int day = Convert.ToInt32(ReadLine());

if (day == 6 || day == 7)
{
    WriteLine("yes");
}
else
{
    WriteLine("no");
}

// 2th

string result = (day == 6 || day == 7) ? "yes" : "no";

WriteLine(result);