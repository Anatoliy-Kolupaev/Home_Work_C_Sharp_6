System.Console.WriteLine("Добрый день!");
int n = 0;
int v = 100;
while (n < v)
{
    Console.Write("Выберите задачу которую хотите проверить №: 41, 411, 412, 43, 431):  ");
    int choice = int.Parse(Console.ReadLine());
    while (choice == 41)
    {
        Console.WriteLine();
        Console.WriteLine("Задача № 41 Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.");
        Console.WriteLine();
        if (choice == 41) Task_41();
        if (choice == 41) Task_41();
        if (choice == 41) Task_41();
        break;

    }
    while (choice == 411)
    {
        Console.WriteLine();
        Console.WriteLine("Задача № 41 Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь. Способ 1");
        Console.WriteLine();
        if (choice == 411) Task_41_1();
        if (choice == 411) Task_41_1();
        if (choice == 411) Task_41_1();
        break;
    }
    while (choice == 412)
    {
        Console.WriteLine();
        Console.WriteLine("Задача № 41 Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь. Способ 2");
        Console.WriteLine();
        if (choice == 412) Task_41_2();
        if (choice == 412) Task_41_2();
        if (choice == 412) Task_41_2();
        break;
    }
    while (choice == 43)
    {
        Console.WriteLine();
        Console.WriteLine("Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.");
        Console.WriteLine();
        if (choice == 43) Task_43();
        if (choice == 43) Task_43();
        if (choice == 43) Task_43();
        break;
    }
    while (choice == 431)
    {
        Console.WriteLine();
        Console.WriteLine("Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.");
        Console.WriteLine();
        if (choice == 431) Task_43_1();
        if (choice == 431) Task_43_1();
        if (choice == 431) Task_43_1();
        break;
    }
    n++;
}

void Task_41()
{
    string ReadData(string msg)
    {
        System.Console.Write(msg);
        string number = (System.Console.ReadLine());
        number = number + " ";
        return number;
    }

    int[] ArrayOfNumbers(string array)
    {

        int[] arrayOfNumber = new int[1];

        int j = 0;
        for (int i = 0; i < array.Length; i++)
        {
            string series = "";

            while (array[i] != ' ' && i < array.Length)
            {
                series += array[i];
                i++;
            }
            arrayOfNumber[j] = Convert.ToInt32(series);
            if (i < array.Length - 1)
            {
                arrayOfNumber = arrayOfNumber.Concat(new int[] { 0 }).ToArray();
            }
            j++;
        }
        return arrayOfNumber;
    }
    int Test(int[] arrayOfNumber)
    {
        int sum = 0;
        for (int i = 0; i < arrayOfNumber.Length; i++)
        {
            if (arrayOfNumber[i] >= 0) sum++;
        }
        return sum;
    }

    string arrLen = ReadData("Введите ряд чисел, разделенных пробелом: ");
    int[] arrayOfNumber = ArrayOfNumbers(arrLen);
    System.Console.WriteLine($"Количество введеных чисел > 0 =  {Test(arrayOfNumber)}");
}

void Task_41_1()
{
    Console.Write("Введите кол-во чисел М: ");
    int n = int.Parse(Console.ReadLine());
    int[] arr = new int[n];
    int Work(int n)
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
}
void Task_41_2()
{
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
}
void Task_43()
{
    double[,] koordinat = new double[2, 2];
    double[] koor = new double[2];

    void Userkoordinat()
    {
        for (int i = 0; i < koordinat.GetLength(0); i++)
        {
            for (int j = 0; j < koordinat.GetLength(1); j++)
            {
                if (j == 0) Console.Write($"Введите коэффициент k{i + 1}: ");
                else Console.Write($"Введите коэффициент b{i + 1}: ");
                koordinat[i, j] = Convert.ToInt32(Console.ReadLine());
            }
        }
    }

    double[] FindIntersection(double[,] koordinat)
    {
        koor[0] = (koordinat[1, 1] - koordinat[0, 1]) / (koordinat[0, 0] - koordinat[1, 0]);
        koor[1] = koor[0] * koordinat[0, 0] + koordinat[0, 1];
        return koor;
    }
    void PrintKoord(double[,] koordinat)
    {
        if (koordinat[0, 0] == koordinat[1, 0] && koordinat[0, 1] == koordinat[1, 1])
        {
            Console.Write($"Прямые совпадают");
        }
        else if (koordinat[0, 0] == koordinat[1, 0] && koordinat[0, 1] != koordinat[1, 1])
        {
            Console.Write($"Прямые параллельны");
        }
        else
        {
            FindIntersection(koordinat);
            Console.Write($"Точка пересечения прямых: ({koor[0]}, {koor[1]})");
        }
    }

    Userkoordinat();
    PrintKoord(koordinat);
}
void Task_43_1()
{
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
}