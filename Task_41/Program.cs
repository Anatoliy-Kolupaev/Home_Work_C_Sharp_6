// Задача № 41
// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

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

  int j =0;
  for (int i = 0; i < array.Length; i++)
  {
    string series = "";

    while (array[i] != ' ' && i < array.Length)
    {
      series += array[i];
      i++;
    }
    arrayOfNumber[j] = Convert.ToInt32(series);    
    if (i < array.Length-1)
    {
      arrayOfNumber = arrayOfNumber.Concat(new int[] {0}).ToArray();    
    }
    j++;
  }
  return arrayOfNumber;
}
int Test (int [] arrayOfNumber)
{
    int sum = 0;
    for (int i = 0; i < arrayOfNumber.Length; i++)
  {
     if (arrayOfNumber[i] >= 0) sum++;
  }
  return sum;
}

string arrLen = ReadData("Введите ряд чисел, разделенных пробелом: ");
int[] arrayOfNumber =  ArrayOfNumbers(arrLen);
System.Console.WriteLine($"Количество введеных чисел > 0 =  {Test(arrayOfNumber)}");