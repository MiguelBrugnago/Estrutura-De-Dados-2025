<<<<<<< HEAD
﻿Console.WriteLine("enter the lenght of the fibbonacci series ");

string input = Console.ReadLine(); 

int lenght = 0;

if(!Int32.TryParse(input , out lenght))
{
    Console.WriteLine("Numero Invalido");
    return;
}

for (int i = 0; i < lenght; i++)
{
    Console.Write("{0} ", FibonacciSeries(i));
}
Console.ReadKey();


static int FibonacciSeries(int n)
{
    if (n == 0) return 0; // to return the first number fibonacci number
    if (n == 1) return 1; // to return the second number fibonacci number
    return FibonacciSeries(n - 1) + FibonacciSeries(n - 2);
}
=======
﻿Console.Write("enter the lenght of the fibbonacci series");

string input = Console.ReadLine(); 

int lenght = 0;

if(!Int32.TryParse(input , out lenght))
{
    Console.WriteLine("Numero Invalido");
    return;
}

for (int i = 0; i < lenght; i++)
{
    Console.Write("{0} ", FibonacciSeries(i));
}
Console.ReadKey();


static int FibonacciSeries(int n)
{
    if (n == 0) return 0; // to return the first number fibonacci number
    if (n == 1) return 1; // to return the second number fibonacci number
    return FibonacciSeries(n - 1) + FibonacciSeries(n - 2);
}

// recursive function
static int factorial(int num)
{
    // terminal condition
    if (num == 0)
        return 1;
    else
        // recursive call
        return num * factorial(num - 1);
}
>>>>>>> 4860050dd2d4dd74d82b4df8905058b29ccbab6b
