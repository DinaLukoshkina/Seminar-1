// Напишите программу, которая на вход принимает два числа и выдает, какое больше, а какое меньше 
Console.Clear(); 
Console.WriteLine("Введите первое число: "); 
int a = int.Parse(Console.ReadLine()!); 
Console.WriteLine("Введите второе число: "); 
int b = int.Parse(Console.ReadLine()!); 
int maxValue; 
if (a > b) 
{ 
maxValue = a; 
} 
else 
{ 
maxValue = b; 
} 
Console.WriteLine($"Максимальное значение = {maxValue}");