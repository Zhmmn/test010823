// using System;

// public class Answer
// {
//   private static double Length(int[] pointA, int[] pointB)
//   {
//     // Введите свое решение ниже
//     int CoordinateX = pointA[0] - pointB[0];
//     int CoordinateY = pointA[1] - pointB[1];
//     int CoordinateZ = pointA[2] - pointB[2];
//     double h1 = Math.Sqrt(Math.Pow(CoordinateX, 2) + Math.Pow(CoordinateY, 2));
//     double h2 = Math.Sqrt(Math.Pow(h1, 2) + Math.Pow(CoordinateZ, 2));
//     return h2;

//   }

//   // Не удаляйте и не меняйте метод Main! 
//   public static void Main(string[] args)
//   {
//     int x1, x2, x3, y1, y2, y3;

//     if (args.Length >= 6)
//     {
//       x1 = int.Parse(args[0]);
//       x2 = int.Parse(args[1]);
//       x3 = int.Parse(args[2]);
//       y1 = int.Parse(args[3]);
//       y2 = int.Parse(args[4]);
//       y3 = int.Parse(args[5]);
//     }
//     else
//     {
//       // Здесь вы можете поменять значения для отправки кода на Выполнение
//       x1 = 3;
//       x2 = 6;
//       x3 = 8;
//       y1 = 2;
//       y2 = 1;
//       y3 = -7;
//     }

//     // Не удаляйте строки ниже
//     double result = Length(new int[] { x1, x2, x3 }, new int[] { y1, y2, y3 });
//     Console.WriteLine($"{result:F2}");
//   }
// }
// int Square(int number)
// {
//   return number * number;
// }
// Console.WriteLine(Math.Sqrt(251));
void(string[] args)
{



  Console.WriteLine(args);
}