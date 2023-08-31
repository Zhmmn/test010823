﻿// Задача 24. Напишите программу, которая 
// принимает на вход число А и выдает сумму чисел
// от 1 до А
// 7 -> 28

int SumNumbers(int num)
{
  int sum = 0;
  for (int i = 1; i <= num; i++)
  {
    sum += i; // sum = sum + i
  }
  return sum;
}


Console.WriteLine("Введите натуральное число: ");
int number = Convert.ToInt32(Console.ReadLine());
int sumNumbers = SumNumbers(number);
if (number < 1)
{
  Console.WriteLine("Введено некоректное число");
  return;
}

Console.WriteLine($" Сумма чисел от 1 до {number} = {sumNumbers}");