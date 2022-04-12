/* Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

4 -> да
-3 -> нет
7 -> нет

*/


Console.WriteLine("input digit");
int ourDigit = Convert.ToInt32(Console.ReadLine());



if (ourDigit % 2 == 0)
{
    Console.WriteLine("clear");
}
else
{
    Console.WriteLine("not clear");
}