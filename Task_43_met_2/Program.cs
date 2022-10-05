// Задача №43 
// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; 0,5)

Console.Write("Введите значение к1: ");
double k1 = double.Parse(Console.ReadLine());
Console.Write("Введите значение b1: ");
double b1 = double.Parse(Console.ReadLine());
Console.Write("Введите значение к2: ");
double k2 = double.Parse(Console.ReadLine());
Console.Write("Введите значение b2: ");
double b2 = double.Parse(Console.ReadLine());
double X(double k1, double b1, double k2, double b2)
{
    double x = 0;
    x = (b2 - b1) / (k1 - k2);
    return x;
}
double Y(double k1, double b1)
{
    double y = 0;
    y = X(k1, b1, k2, b2) * k1 + b1;
    return y;
}
void PrintKoord(double k1, double b1, double k2, double b2)
{
  if (k1 == b1 && k2 == b2) Console.Write($"Прямые совпадают");
  else if (k1 == b1 && k2 != b2) Console.Write($"Прямые параллельны");
  else Console.WriteLine($"({X(k1, b1, k2, b2)}; {Y(k1, b1)})");
}
PrintKoord(k1, b1, k2, b2);