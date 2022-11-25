// Задача 27: Напишите программу, которая принимает 
// на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Write("Введите число ");
int numberN = Convert.ToInt32(Console.ReadLine());

  int SumNumber(int numberN){
    
    int length = Convert.ToString(numberN).Length;
    int step = 0;
    int sum = 0;

    for (int i = 0; i < length; i++)
    {
      step = numberN - numberN % 10;
      sum = sum + (numberN - step);
      numberN = numberN / 10;
    }
   return sum;
  }

int sumNumber = SumNumber(numberN);
Console.WriteLine($"{numberN} -> {sumNumber}");
