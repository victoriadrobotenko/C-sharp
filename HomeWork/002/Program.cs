/* Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22


*/


Console.WriteLine("input first digit");
int firstDigit = Convert.ToInt32(Console.ReadLine());


Console.WriteLine("input second digit");
int secondDigit = Convert.ToInt32(Console.ReadLine());


Console.WriteLine("input third digit");
int thirddDigit = Convert.ToInt32(Console.ReadLine());


int max = firstDigit;

if (max < secondDigit) max = secondDigit;
if (max < thirddDigit) max = thirddDigit;


Console.WriteLine("max = " + max);


