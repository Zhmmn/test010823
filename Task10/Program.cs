// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

int SecondDigitThirdNumber(int number)
{
  int firstDigit = number % 100; // 456 % 100 = 4.56 = 56
  int result = firstDigit / 10; // 56 / 10 = 5
  return result;

}

Console.Write("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());





if (number < 100 || number > 1000)
{
  Console.WriteLine("Число не соответствует условию, введите другое число");

}
else
{
  int solution = SecondDigitThirdNumber(number);
  Console.WriteLine($" Вторая цифра из трехзначного числа : {solution}");
}


