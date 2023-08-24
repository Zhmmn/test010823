// 20. Напишите программу которая принимает на вход координаты двух точек и находит расстояние между ними 2D пространстве
// А (3,6); B(2,1) -> 5,09
// A (7, -5) B (1, -1) -> 7,21

double findDistance(int xA, int yA, int xB, int yB)
{
  return Math.Sqrt(Math.Pow(xA - xB, 2) + Math.Pow(yA - yB, 2));
}

// double sgrt = Math.Sqrt(5); // квадратный корень
// double pow = Math.Pow(5, 3); // возведение в степень

// double d = 5.098889; // 5.09
// double dRound = Math.Round(d, 2, MidpointRounding.ToZero);
// Console.WriteLine(dRound); // округление
// Console.WriteLine($"{d:F2}");

Console.WriteLine("Введите координаты первой точки: ");
Console.Write("X: ");
int xCoordinateA = Convert.ToInt32(Console.ReadLine());
Console.Write("Y: ");
int yCoordinateA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты второй точки: ");
Console.Write("X: ");
int xCoordinateB = Convert.ToInt32(Console.ReadLine());
Console.Write("Y: ");
int yCoordinateB = Convert.ToInt32(Console.ReadLine());

double result = findDistance(xCoordinateA, yCoordinateA, xCoordinateB, yCoordinateB);
Console.WriteLine(Math.Round(result, 2, MidpointRounding.ToZero));