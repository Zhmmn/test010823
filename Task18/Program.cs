// Задача 18: Напишите программу, которая по
// заданному номеру четверти, показывает диапазон
// возможных координат точек в этой четверти (x и y).


string CoordinateRange(int quarter)
{
  if (quarter == 1) return "x > 0, y > 0";
  if (quarter == 2) return "x < 0, y > 0";
  if (quarter == 3) return "x < 0, y < 0";
  if (quarter == 4) return "x > 0, y < 0";
  return null;
}


Console.Write("Введите номер четверти: ");
int quarter = Convert.ToInt32(Console.ReadLine());
string result = CoordinateRange(quarter);

Console.Write(result != null ? result : "Некорректный ввод!");
