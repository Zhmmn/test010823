// Задача 28. Напишите программу, которая принимает на вход число N и выдает произведение чисел от 1 до N
// 4 -> 24

int multiplicationNums(int num)
{
  int mult = 1;
  for (int i = 1; i <= num; i++)
  {
    checked // команда проверяет на заполненность 
    {
      mult *= i;
    }
  }
  return mult;
}


Console.WriteLine("Введите натуральное число: ");
int number = Convert.ToInt32(Console.ReadLine()); // если ответ больше 2 млрд .то значение не корректное так как в 32 битах помещается только 2 млрд
if (number < 1)
{
  Console.WriteLine("Введено некоректное число");
  return;
}

Console.WriteLine($" произведение чисел {number} = {multiplicationNums(number)}");
