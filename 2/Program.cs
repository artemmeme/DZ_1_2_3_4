﻿Console.WriteLine("Введите первое число");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число");
int num3 = Convert.ToInt32(Console.ReadLine());
int max;
max = 0;

if (num1>max)
{
    max = num1;
} 

if (num2>max)
{
    max = num2;
} 

if (num3>max)
{
    max = num3;
} 
Console.WriteLine("Большее число");
    Console.Write($"{max} ");
