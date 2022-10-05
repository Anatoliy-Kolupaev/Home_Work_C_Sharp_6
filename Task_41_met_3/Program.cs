// Задача № 41
// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3
// Без использования массива

Console.Write("Введите кол-во чисел M: ");
int n = int.Parse(Console.ReadLine());
int sum = 0;
int num = 0;
for (int i = 0; i < n; i++)
{
    System.Console.Write($"Введите {i + 1} число: ");
    num = int.Parse(Console.ReadLine());
    if (num > 0) sum++;
}
System.Console.WriteLine($"Еол-во чисел больше 0 = {sum}");