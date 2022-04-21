int a = 1;
int b = 2;
int c = 6;
int d = 8;
int e = 4;

int max = a;

/*

int Method (int a, int b, int c, int d, int e)
{
int max = a;
if (b > max) max = b;
if (c > max) max = c;
if (d > max) max = d;
if (e > max) max = e;
return max;
}

int max = Method (a, b, c, d, e);

*/

if (a > max) max = a;
if (b > max) max = b;
if (c > max) max = c;
if (d > max) max = d;
if (e > max) max = e;

Console.Write("max = ");
Console.WriteLine(max);