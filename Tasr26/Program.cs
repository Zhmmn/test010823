// задача 26 : напишите программу которая принимает на вход число и выдает количество цифр в числе
// 456 -> 3
// 78945 -> 5



int digitCount(int number)
{
  int count = 0;
  if (number == 0) return 1;


  while (number != 0)
  {
    number = number / 10;
    count++;
  }
  return count;
}

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"{number} состоит из {digitCount(number)} знаков ");