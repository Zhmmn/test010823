// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

// int number = new Random().Next(1, 1000000);
// Console.WriteLine($" Случайное число : {number}");
int number = 1;

while (number > 999)
{
  number = number / 10;
}
if (number < 100)
{
  Console.WriteLine("Третьей цифры нет");
}
else
{
  number = number % 10;
  Console.WriteLine($"Третья цифра заданного числа: {number}");
}


