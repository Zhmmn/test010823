// 16.Напишите программу, которая на вход принимает два числа и проверяет, является ли одно число квадратом другого
// 5, 25 -> yes
// -4, 16 -> yes
// 25, 5 -> yes
// 8, 9 -> no

Console.WriteLine("Введите два числа : ");
int firstnumbers = Convert.ToInt32(Console.ReadLine());
int secondnumbers = Convert.ToInt32(Console.ReadLine());

bool squareTwoNumbers(int firstnumbers, int secondnumbers)
{
  return firstnumbers * firstnumbers == secondnumbers ||
  secondnumbers * secondnumbers == firstnumbers;

}

bool result = squareTwoNumbers(firstnumbers, secondnumbers);

Console.WriteLine(result ? "Yes" : "No");

