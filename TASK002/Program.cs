// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3
Console.WriteLine("Напишите первое целое число ");
int a = Convert.ToInt32 (Console.ReadLine()!);
Console.WriteLine($"Число a равно {a}");
Console.WriteLine("Напишите второе целое число ");
int b = Convert.ToInt32 (Console.ReadLine()!);
Console.WriteLine($"Число b равно {b}");

int max = 0;
if (a < b) max = b;
else if (a > b) max = a;
Console.WriteLine($"max={max}");



