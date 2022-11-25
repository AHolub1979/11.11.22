// Задача 25: Напишите цикл, который принимает на вход два 
// числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243
// 2, 4 -> 16

Console.WriteLine ("Введите число для возведения его в степень ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Введите степени ");
int b = Convert.ToInt32(Console.ReadLine());
if (b > 0)

{
    Console.WriteLine ($"Число {a} в степени {b} равно {Math.Pow (a , b)}");
    Console.WriteLine ($" {a} , {b} -> {Math.Pow (a , b)}");
}
else Console.WriteLine ("Введите натуральное чило");