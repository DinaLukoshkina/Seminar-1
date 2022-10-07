// Напишите программу, которая на вход принимает число (N), а на выходе показыввет все четные числа от 1 до N 
Console.Clear(); 
Console.WriteLine("Введите число: "); 
int N = int.Parse(Console.ReadLine()!); 
int I = 1; 
while (I <= N) 
{ 
if (I % 2 == 0) 
{ 
Console.Write($"{I} "); 
} 
I = I + 1; 
}