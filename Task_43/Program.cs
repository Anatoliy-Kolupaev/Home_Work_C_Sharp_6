// Задача №43 
// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; 0,5)

double[,] koordinat = new double[2, 2];
double[] koor = new double[2];

void Userkoordinat()
{
  for (int i = 0; i < koordinat.GetLength(0); i++)
  {
        for (int j = 0; j < koordinat.GetLength(1); j++)
    {
      if(j==0) Console.Write($"Введите коэффициент k{i+1}: ");
      else Console.Write($"Введите коэффициент b{i+1}: ");
      koordinat[i,j] = Convert.ToInt32(Console.ReadLine());
    }
  }
}

double[] FindIntersection(double[,] koordinat)
{
    koor[0] = (koordinat[1,1] - koordinat[0,1]) / (koordinat[0,0] - koordinat[1,0]);
    koor[1] = koor[0] * koordinat[0,0] + koordinat[0,1];
    return koor;
}
void PrintKoord(double[,] koordinat)
{
  if (koordinat[0,0] == koordinat[1,0] && koordinat[0,1] == koordinat[1,1]) 
  {
    Console.Write($"Прямые совпадают");
  }
  else if (koordinat[0,0] == koordinat[1,0] && koordinat[0,1] != koordinat[1,1]) 
  {
    Console.Write($"Прямые параллельны");
  }
  else 
  {
    FindIntersection(koordinat);
    Console.Write($"Точка пересечения прямых: ({koor[0]}, {koor [1]})");
  }
}

Userkoordinat();
PrintKoord(koordinat);