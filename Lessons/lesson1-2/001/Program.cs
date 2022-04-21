Console.WriteLine("Hello, World!"); - //то. что должно быть написано в консоли
/*текст*/ string username = Console.ReadLine(); - // возьми то что справа и положи в то что слева
          int = /*целое число*/
          double = /*вещественные числа делятся с остатком*/


Console.WriteLine(username); //написать то, что напишется в Сonsole.readline
//git add + имя папки
//git commit -m + комментарий
//git push
int numberA = 3;
int numberB = 2;
int result = numberA + numberB;
Console.WriteLine(result);


int numberA = new Random().Next(1.10); /*случайное новое число*/
Console.WriteLine(numberA);
int numberB = new Random().Next(1, 10);
Console.WriteLine(numberB);
Console.WriteLine(numberA + numberB);


Console.WriteLine("ВВедите имя");
string username = Console.ReadLine();
 if(username.ToLower() == "masha")  /* == это равно, ToLower - переводит все в нижний регистр*/
{
    Console.WriteLine("ура, это Masha");
}
 else
 {
     Console.WriteLine("hello");
     Console.WriteLine(username);
 }


 int A = 5;
 int B = 6;
 int C = 3
 int max = A;
 if (A > max) max = A;
 if (B > max) max = B;
 if (C > max) max = C;
 Console.WriteLine("max = ");
 Console.WriteLine(max);


 Console.Clear(); /*перед каждым запуском программы вся консоль будет очищаться*/
 Console.SetCursorPosition(10, 4); /*рисует линии отступ от левого края и от верхнего*/
 Console.WriteLine("+");


 int number = int.Parse(Console.ReadLine()); /* считать число*/
 /*или*/
 using System;
 using static System.Console;
 WriteLine("input number");
 int number=int.Parse(ReadLine());
 int sqr = number * number;
 WriteLine($"result = {sqr}"); /* доллар позволяет в строку вводить переменную*/


 int day = Convert.ToInt32(Console.ReadLine()); /* значит конвертировать это в число*/

 using System;
 int N =int.Parse(ReadLine());
 int B = -N;
 while (B<=N) /* <=  значит меньше или равно*/
 {
     Console.Write($"{B}"):
     B+=1;   /* += значит В = В + 1, может быть В/=2 - В=В:2, В*=2 - В=В*2*/
 }

 
 using System;
int number = int.Parse(Console.ReadLine());
int x = number/10;
int y = number%10; /* % равно остаток от деления*/
Console.WriteLine($"x={x}   y={y} ");

