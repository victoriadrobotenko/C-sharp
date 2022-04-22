// array



// так записывается массив.

/*

int[] array03 = { 56, 78, 98, 44, 838, 3934, 2, 9, 448, 404 };

string[] tastes = {"peach", "cherry"};


string myWords = "peach, apple";

array03[1] = 99999;



Console.WriteLine(array03[1]);


int index = 0;

while (index < 10)
{
    Console.Write($"{array03[index]} ");
    index +=1;
}



1 создать массивы типа int, string (в каждом по пять ячеек)

2 вывести в консоль один из индексов каждого массива

3 заменить внутри массива одну из ячеек*/


//             0    1   2   3   4  -индексы считаются с 0
/*int[] array = {12, 34, 11, 56, 12}; 

string[] myWord = { "a", "b", "c", "d", "c" };


string a = "fvfvfv";

array[1] = 111;

Console.WriteLine(array[1]);*/


/*int[] array = { 1, 45, 13, 34, 78, 46, 4, 2 };
int n = array.Length; // возвращает кол-во элементов массива
int find = 4;
int index = 0;
while (index < n)
{
    if (array[index]==find)
    {
        Console.WriteLine(index);
    }
    index = index + 1;
} */


/*using System;
Console.Write("Введите первое число");
int num1 = int.Parse(Console.ReadLine());
Console.Write("Введите второе число");
int num2 =int.Parse(Console.ReadLine());
Console.WriteLine(num1 % num2 ==0 ? "кратно":$"не кратно, остаток - {num1%num2} "); //? - если правда, то. : -иначе (неправда)-выведи другое
*/
/*int a = 34;
int b = 23;
int c = 13;
int max = (a>b&&a>c)?a:(b>a&&b>c)?b:c; // &&значит или
Console.WriteLine(max);
*/

Console.WriteLine("Введите число");
int num = int.Parse(Console.ReadLine());
using System;
Console.Clear;
int num = int.Parse(Console.ReadLine());
switch (num)
{
    case 1:
    {
      Console.WriteLine("x>0, y>0");
      break;
    }
   case 2:
   {
       Console.WriteLine("x<0, y>0");
       break;
   }
   case 3:
   {
       Console.WriteLine("x<0,y<0");
       break;
   }
   case 4:
   {
       Console.WriteLine("x>0, y<0");
       break;
   }
    default: // если условия не выполняются
    {
        Console.WriteLine("введена неправильная четверть");
        break;
    }
}



(a1>0&&a2>0) //&& если первое условие не выполняется, то прверить второе условие


double step = Math.Pow(3,4); // возводим в степень 3-что возводим, 4 в какую степень
 double step = Math.Sqrt(Math.Pow(3,4)); // получить квадрат из степени
double a = Math.Sqrt(3); // получить квадрат 3
