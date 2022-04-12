/* Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3



*/

Console.WriteLine("input first digit");
int firstDigit = Convert.ToInt32(Console.ReadLine());


Console.WriteLine("input second digit");
int secondDigit = Convert.ToInt32(Console.ReadLine());

if (firstDigit > secondDigit)
{
    Console.WriteLine("max = " + firstDigit);
}
else
{
    Console.WriteLine("max = " + secondDigit);
}


