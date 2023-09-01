// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int sumAllDigit(int number)
{
  int result = 0;
  while (number > 0)
  {
    result = result + (number % 10); // 123 % 10 = 3 || 2 цикл 12 % 10 = 2 || 1 % 10 = 1
    number = number / 10; // 123 / 10 = 12 || 12 / 10 = 1 || 1 / 10 = 0
  }
  return result;
}


Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Сумма всех цифр в числе {number} равен {sumAllDigit(number)}");