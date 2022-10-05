// Задача № 41
// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3
// С использованием массива

Console.Write("Введите кол-во чисел М: ");
int n = int.Parse(Console.ReadLine());
int [] arr = new int [n];
int Work (int n)
{
    int sum = 0;
    for (int i = 0; i < n; i++)
    {
        Console.Write($"Введите {i + 1} число: ");
        arr[i] = int.Parse(Console.ReadLine());
        if (arr[i] > 0) sum++;
    }
    return sum;
}

Console.WriteLine($"Еол-во чисел больше 0 = {Work(n)}");
