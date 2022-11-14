// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22
Console.WriteLine("Напишите первое целое число ");
int a = Convert.ToInt32 (Console.ReadLine()!);
Console.WriteLine($"Число a равно {a}");
Console.WriteLine("Напишите второе целое число ");
int b = Convert.ToInt32 (Console.ReadLine()!);
Console.WriteLine($"Число b равно {b}");
Console.WriteLine("Напишите третье целое число ");
int c = Convert.ToInt32 (Console.ReadLine()!);
Console.WriteLine($"Число c равно {c}");

int max = a;
if (b > a ) max = b;
if (c > b) max = c;
Console.WriteLine($"max={max}");