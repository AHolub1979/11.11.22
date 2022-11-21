// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 5 -> 
// 1 | 1
// 2 | 8
// 3 | 27
// 4 | 64
// 5 | 125


Console.Write("Введите число  ");
int number = Convert.ToInt32(Console.ReadLine());
void Square(int numb)
{
    int count = 1;
    while (count <= numb)
    {
        //Console.WriteLine($"{count} | {count * count * count}"); 
        Console.WriteLine($"{count} | {Math.Pow(count, 3)}"); // Этот способ мне нравится больше
        count++;
    }

}
Square(number);