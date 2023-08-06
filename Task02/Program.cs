// //Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.WriteLine("Напишите первое число");
int firstNumber = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Напишите второе число");
int secondNumber = Convert.ToInt32(Console.ReadLine());



if(firstNumber > secondNumber)
{
  Console.WriteLine($"Большее = {firstNumber} - Меньшее = {secondNumber}");
}

else
{
  Console.WriteLine($"Большее = {secondNumber} - Меньшее = {firstNumber}");
}
