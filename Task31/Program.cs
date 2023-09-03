// // Задача 31. 
// 1.Задайте массив из 12 элементов,
// 2. заполненный случайными числами из промежутка [-9, 9].
// 3.Найдите сумму отрицательных и положительных элементов массива.


int[] CreateArrayRndint(int size, int min, int max)
{
  int[] arr = new int[size];
  Random random = new Random();
  for (int i = 0; i < size; i++)
  {
    arr[i] = random.Next(min, max + 1);
  }
  return arr;
}

void PrintArray(int[] arr)
{
  Console.Write("[");
  for (int i = 0; i < arr.Length; i++)
  {
    if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
    else Console.Write($"{arr[i]} ");
  }
  Console.Write("]");
}

int[] SumPositiveNegativeElem(int[] arr)
{
  int sumPozitiv = 0;
  int sumNegativ = 0;
  for (int i = 0; i < arr.Length; i++)
  {
    if (arr[i] > 0) sumPozitiv += arr[i];
    else sumNegativ += arr[i];
  }
  return new int[] { sumPozitiv, sumNegativ };
}

int[] array = CreateArrayRndint(12, -9, 9);
PrintArray(array);
Console.WriteLine();
int[] sumPositiveNegativeElem = SumPositiveNegativeElem(array);
Console.WriteLine($"Сумма положительных элементов {sumPositiveNegativeElem[0]}");
Console.WriteLine($"Сумма отрицательных элементов {sumPositiveNegativeElem[1]}");