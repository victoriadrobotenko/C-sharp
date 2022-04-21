 // 
 
 
 /*
Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1
*/
using System;
using static System.Console;



// 1th

WriteLine("input three digit number");
int num = Convert.ToInt32(ReadLine());

int result = num / 10 % 10;

WriteLine(result);

// 2th

WriteLine("input three digit number");
string sNum = ReadLine();

WriteLine(sNum[1]);

// 3th

WriteLine("input three digit number");
string aNum = ReadLine();

int length = aNum.Length;
WriteLine(aNum[length - 2]);
