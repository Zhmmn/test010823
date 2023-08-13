// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите цифру: ");
int dayNumber = Convert.ToInt32(Console.ReadLine());
if (dayNumber >= 8)
{
  Console.WriteLine(" Цифра не корректна, введите заново.");
}

if (dayNumber == 1)
{
  Console.WriteLine(" Monday - not a day off, go to work!");
}
if (dayNumber == 2)
{
  Console.WriteLine(" Tuesday - not a day off, go to work!");
}
if (dayNumber == 3)
{
  Console.WriteLine(" Wednesday - not a day off, go to work!");
}
if (dayNumber == 4)
{
  Console.WriteLine(" Thursday - not a day off, go to work!");
}
if (dayNumber == 5)
{
  Console.WriteLine(" Friday - not a day off, go to work!");
}
if (dayNumber == 6)
{
  Console.WriteLine(" Saturday  - holiday, rest!");
}
if (dayNumber == 7)
{
  Console.WriteLine(" Sunday - holiday, rest!");
}