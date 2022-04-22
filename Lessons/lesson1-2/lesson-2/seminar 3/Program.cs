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