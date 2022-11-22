// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
// что третьей цифры нет. Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).
// // 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

// Console.Write("Введи число: ");
// int number = Convert.ToInt32(Console.ReadLine());

// if (number % 100 > 1 && number % 1000 < 1) 
// {
//   int number2 = number % 10;  
//   Console.WriteLine($"третья цифра ->  {number2}");
//   Console.WriteLine("-> третьей цифры нет");
// }

Console.WriteLine("Напишите целое число ");
int a = Convert.ToInt32 (Console.ReadLine()!);

if (a < 999  && a >=100 )
{
    int num = (a% 100);
    int num2 = (num%10);
    Console.WriteLine (num2);
}
else
Console.WriteLine("-> третьей цифры нет");
     
 
    
    
