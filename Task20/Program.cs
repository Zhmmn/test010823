// 20. Напишите программу которая принимает на вход координаты двух точек и находит расстояние между ними 2D пространстве
// А (3,6); B(2,1) -> 5,09
// A (7, -5) B (1, -1) -> 7,21

int Quarter(int x, int y)
{
  if (x > 0 && y > 0) return 1;
  if (x < 0 && y > 0) return 2;
  if (x < 0 && y < 0) return 3;
  if (x > 0 && y < 0) return 4;
  return 0;
}

double sgrt = Math.Sqrt(5);
double pow = Math.Pow(5, 3);

double d = 5.098889; // 5.09
double dRound = Math.Round(d, 2, MidpointRounding.ToZero);
Console.WriteLine(dRound);
Console.WriteLine($"{d:F2}");