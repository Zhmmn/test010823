// Задача 30. Напишите программу, которая выводит массив  из 8 элементов, заполненный
// нулями и единицами в случайном порядке

// [1,0,1,0,0,1,0,1]


// int[] array = new int[8];
// for (int i = 1; i < array.Length; i++)
// {
//   array[i] = i * i;
//   Console.Write(array[i] + " ");
// }

void FillArray(int[] massiv)
{
  int i = 0;
  var random = new Random();
  while (i < massiv.Length)
  {
    massiv[i] = new Random().Next(2);
    i++;
  }
}

void printArray(int[] massiv)
{
  int i = 0;
  while (i < massiv.Length)
  {
    Console.Write($"{massiv[i]} ");
    i++;
  }
}

int[] array = new int[8];
FillArray(array);
printArray(array);

