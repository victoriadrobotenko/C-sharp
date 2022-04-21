using System;

Console.Clear();

/*int num=new Random().Next(100,1000);
string numS=num.ToString();
int a1=Convert.ToInt32(numS[0].ToString());
int a3=Convert.ToInt32(numS[2].ToString());
Console.WriteLine($"{num}>{a1}{a3}");*/


int num1=new Random().Next(1,99);
int num2=new Random().Next(1,99);
int a1=Convert.ToInt32(num1.ToString());
int a2=Convert.ToInt32(num1.ToString());
if(num1%a2==0)
Console.WriteLine($"{a1},{a2}->kratno");
else
Console.WriteLine($"{a1},{a2}-> ne kratno, ostatok{a1%a2}");