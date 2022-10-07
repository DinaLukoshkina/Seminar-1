// Напишите программу, которая принимает на вход три числа и выдает максимальное из этих чисел 
Console.Clear(); 
Console.WriteLine("Введите первое число: "); 
int a = int.Parse(Console.ReadLine()!); 
Console.WriteLine("Введите второе число: "); 
int b = int.Parse(Console.ReadLine()!); 
Console.WriteLine("Введите третье число: "); 
int c = int.Parse(Console.ReadLine()!); 
int maxValue = a; 
if (maxValue < b) 
{ 
maxValue = b; 
} 
if (maxValue < c) 
{ 
maxValue = c; 
} 
Console.WriteLine($"Максимальное значение = {maxValue}");