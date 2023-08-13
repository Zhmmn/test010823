// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.Write("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());


int SecondDigitThirdNumber(int number)
{
  int firstDigit = number / 100; // 456 / 100 = 4.56 = 4
  int thirdDigit = number % 10; // 456 / 10 = 45,6 = 6
  int result = (firstDigit + thirdDigit) / 2;
  return result;

}

int solution = SecondDigitThirdNumber(number);
Console.WriteLine($" Вторая цифра из трехзначного числа : {solution}");

