// Напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа
// 456-> 46
// 782-> 72


int number = new Random().Next(100, 1000);
// int firstDigit = number / 100;
// int thirdDigit = number % 10;
// int result = firstDigit * 10 + thirdDigit;

int digit(int num)
{
  int firstDigit = num / 100;
  int thirdDigit = num % 10;
  int result = firstDigit * 10 + thirdDigit;
  return result;
}

int solution = digit(number);
Console.WriteLine($" 2 цифры из трехзначного числа {number} -> {solution}");



