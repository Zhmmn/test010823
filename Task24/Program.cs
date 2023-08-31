// Задача 24. Напишите программу, которая 
// принимает на вход число А и выдает сумму чисел
// от 1 до А
// 7 -> 28

int SumNumbers(int num)
{
  int sum = 0;
  for (int i = 1; i <= num; i++)
  {
    checked // команда проверяет на заполненность 
    {
      sum += i; // sum = sum + i
    }
  }
  return sum;
}


Console.WriteLine("Введите натуральное число: ");
int number = Convert.ToInt32(Console.ReadLine()); // если ответ больше 2 млрд .то значение не корректное так как в 32 битах помещается только 2 млрд
int sumNumbers = SumNumbers(number);
if (number < 1)
{
  Console.WriteLine("Введено некоректное число");
  return;
}

Console.WriteLine($" Сумма чисел от 1 до {number} = {sumNumbers}");
