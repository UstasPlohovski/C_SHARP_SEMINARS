// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся (HARD - случайные уникальные) двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

// Введение параметров создаваемого массива
// Генерация значений cозданного массива через циклическое присвоение индексов каждому сгенерированному числу
// Создание функции печати данных массива через цикл

Console.WriteLine("Введите параметры трехмерного массива");
Console.WriteLine("Введите параметр A:");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите параметр B:");
int B = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите параметр C:");
int C = Convert.ToInt32(Console.ReadLine());
int[,,] Array = new int[A, B, C];
Array = FillArray(Array);
Console.WriteLine("Сформирован трехмерный массив со следующими значениями:");
PrintArray (Array);

// Функции

int[,,] FillArray(int[,,] Array)
{
  int[] ArrayTemp = new int[Array.GetLength(0) * Array.GetLength(1) * Array.GetLength(2)];
  int  Element = 0;
  for (int i = 0; i < ArrayTemp.GetLength(0); i++)
  {
    ArrayTemp[i] = new Random().Next(1, 100);
    Element = ArrayTemp[i];
    if (i >= 1)
    {
      for (int j = 0; j < i; j++)
      {
        while (ArrayTemp[i] == ArrayTemp[j])
        {
          ArrayTemp[i] = new Random().Next(1, 100);
          j = 0;
          Element = ArrayTemp[i];
        }
          Element = ArrayTemp[i];
      }
    }
  }
  int ElementCount = 0; 
  for (int A = 0; A < Array.GetLength(0); A++)
  {
    for (int B = 0; B < Array.GetLength(1); B++)
    {
      for (int C = 0; C < Array.GetLength(2); C++)
      {
        Array[A, B, C] = ArrayTemp[ElementCount];
        ElementCount++;
      }
    }
  }
  return Array;
}

void PrintArray (int[,,] Array)
{
  for (int i = 0; i < Array.GetLength(0); i++)
  {
    for (int j = 0; j < Array.GetLength(1); j++)
    {
      for (int k = 0; k < Array.GetLength(2); k++)
      {
        Console.Write($"{Array[i,j,k],2}({i},{j},{k});\t");
      }
      Console.WriteLine();
    }
  }
}
