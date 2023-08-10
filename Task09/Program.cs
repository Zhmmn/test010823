// 9.Напишите программу, которая 
// 1. Выводит случайное число из отрезка 10-99 и 
// 2. Показывает наибольшую цифру числа


// 78=> 8
// 12=>2
// 85 => 8

int number = new Random().Next(10, 100); // 99+1
Console.WriteLine($"Случайное число в диапазоне от 10-99 -> {number}");
// int firstDigit = number / 10; //  78 / 10 = 7,8 int целое число, дробная часть отпадает остается 7
// int secondDigit = number % 10; // 78 % 10 = 70 + 8

// if (firstDigit > secondDigit) Console.WriteLine($"Наибольшая цифра числа -> {firstDigit}");
// else Console.WriteLine($"Наибольшая цифра числа -> {secondDigit}");

// int result = firstDigit > secondDigit ? firstDigit : secondDigit;

// Console.WriteLine($"Наибольшая цифра числа -> {result}");

int maxDigit = MaxDigit(number);
Console.WriteLine($"Наибольшая цифра числа -> {maxDigit}");

int maxDigit1 = MaxDigit(89);
Console.WriteLine($"Наибольшая цифра числа -> {maxDigit1}");

int maxDigit2 = MaxDigit(47);
Console.WriteLine($"Наибольшая цифра числа -> {maxDigit2}");

int MaxDigit(int num)
{
  int firstDigit = num / 10;
  int secondDigit = num % 10;
  // int result = firstDigit > secondDigit ? firstDigit : secondDigit;
  return firstDigit > secondDigit ? firstDigit : secondDigit; ;
}


