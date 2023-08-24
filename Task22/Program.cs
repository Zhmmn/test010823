// 22.Создать программу, которая 
// 1 принимает на вход число (N) и 
// 2 выдает таблицу квадратов чисел от 1 до N.

void tableSquare(int number) // void в переводе пустой, не возвращает значение
{
  int i = 1;

  while (i <= number)
  {
    Console.WriteLine($"{i,3} в квадрате: {i * i,5}"); // 3 и 5 кол-во отступа для ровного выведения чисел
    i++;
  }
}


Console.WriteLine("Введите число : ");
int number = Convert.ToInt32(Console.ReadLine());

tableSquare(number);