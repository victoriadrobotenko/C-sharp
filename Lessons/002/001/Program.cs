// Methods


int a1 = 15;
int b1 = 21;
int c1 = 39;

int a2 = 12;
int b2 = 2311;
int c2 = 33;

int a3 = 13;
int b3 = 23111;
int c3 = 313;


int Max(int arg1, int arg2, int arg3)
{
    int max = arg1;
    if (arg2 > max) max = arg2;
    if (arg3 > max) max = arg3;
    return max;
}

int max01 = Max(a1, b1, c1);
int max02 = Max(a2, b2, c2);
int max03 = Max(a3, b3, c3);


int result = Max(max01, max02, max03);

Console.WriteLine("result = " + result);



























/*
//int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
}


int max1 = Max(a1, b1, c1);
int max2 = Max(a2, b2, c2);
int max3 = Max(a3, b3, c3);

int max = Max(max1, max2, max3);
Console.WriteLine(max);


















int x01 = 3;
int x02 = 5;
int x03 = 77;

// +100-35+5*3

// x01 = x01 +100-35+5+3;

int Method (int item)
{
    int result = item + 100-35+3;
    return result;
}


int result = Method (x01);

Console.WriteLine(result);*/



































