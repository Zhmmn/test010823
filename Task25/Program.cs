// //Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// // 3, 5 -> 243 (3⁵)
// // 2, 4 -> 16


// int Prompt(string message)
// {
//   System.Console.WriteLine(message); // Выводим приглашение к вводу
//   string readInput = System.Console.ReadLine(); // Выводим значение
//   int result = int.Parse(readInput); // приводим к числу
//   return result;
// }

// int Power(int powerBase, int exponent)
// {
//   int power = 1;
//   for (int i = 0; i < exponent; i++)
//   {
//     checked
//     {
//       power *= powerBase;
//     }
//   }
//   return power;
// }

// bool ValidateExponent(int exponent)
// {
//   if (exponent < 0)
//   {
//     Console.WriteLine("Показатель не может быть меньше нуля");
//     return false;
//   }
//   return true;
// }

// int powerBase = Prompt("Введите основание: ");
// int exponent = Prompt("Введите показатель: ");
// if (ValidateExponent(exponent))
// {
//   System.Console.WriteLine($"Число {powerBase} в степени {exponent} равно {Power(powerBase, exponent)} ");
// }

int exponentNumber(int num1, int num2)
{
  int exponent = 1;
  for (int i = 0; i < num2; i++)
  {
    checked
    {
      exponent *= num1;
    }
  }
  return exponent;
}

Console.WriteLine("Введите первое число");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int num2 = Convert.ToInt32(Console.ReadLine());

if (num2 <= 0)
{
  Console.WriteLine("Введено некорректное число");
}
else
{
  Console.WriteLine($" число {num1} в степени {num2} равно {exponentNumber(num1, num2)} ");
}