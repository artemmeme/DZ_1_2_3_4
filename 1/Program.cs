Console.WriteLine("Введите первое число");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int num2 = Convert.ToInt32(Console.ReadLine());
int max;
max = num1;

if (num1>num2)
{
    max = num1;
    Console.WriteLine("Большее число");
    Console.Write($"{max} ");
} 
else 
{
    max = num2;
    Console.WriteLine("Большее число");
    Console.Write($"{max} ");
} 
Console.WriteLine();

