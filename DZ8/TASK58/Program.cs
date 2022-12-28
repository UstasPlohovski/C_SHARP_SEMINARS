// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

// Сгенерировать две мартицы с которыми возможно вычислить произведение
// Создать циклическую функцию для вычисления зачений результирующей матрицы
// Сгенерииь результирующую матрицу из полученных значений
// Результат вывести на экран

Console.WriteLine("Введите количество строк перого двумерного массива");
int RowsFirstArray = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов первого двумерного массива");
int ColsFirstArray = Convert.ToInt32(Console.ReadLine());
int[,] ArrayFirst = new int [RowsFirstArray, ColsFirstArray];
ArrayFirst = FillArray(ArrayFirst);
Console.WriteLine("Сформирован первый случайный массив:");
PrintArray(ArrayFirst);
Console.WriteLine();
Console.WriteLine($"Количество строк второго двумерного массива равно: {ColsFirstArray}");
int RowsSecondArray = ColsFirstArray;
Console.WriteLine("Введите количество столбцов второго двумерного массива");
int ColsSecondArray = Convert.ToInt32(Console.ReadLine());
int[,] ArraySecond = new int [RowsSecondArray, ColsSecondArray];
ArraySecond = FillArray(ArraySecond);
Console.WriteLine("Сформирован второй случайный массив:");
PrintArray(ArraySecond);
int[,] ArrayResult = new int[RowsFirstArray, ColsSecondArray];
ArrayResult = FillArrayResult(ArrayFirst, ArraySecond, ArrayResult);
Console.WriteLine();
Console.WriteLine("Получен результирующий массив:");
PrintArray(ArrayResult);


// Функции

int[,] FillArray(int[,] array)
{
    for (int i=0;i<array.GetLength(0);i++)
        for (int j=0;j<array.GetLength(1);j++)
            array[i,j] = new Random().Next(1,10);
    return array;
}

void PrintArray(int[,] array)
{
    for (int i=0;i<array.GetLength(0);i++)
    {
        for (int j=0;j<array.GetLength(1);j++)
            Console.Write($"{array[i,j],3}\t");
        Console.WriteLine();  
    }
}

int[,] FillArrayResult(int[,] ArrayFirst, int[,] ArraySecond, int[,] ArrayResult)
{
  for (int i = 0; i < ArrayResult.GetLength(0); i++)
  {
    for (int j = 0; j < ArrayResult.GetLength(1); j++)
    {
      int Element = 0;
      for (int k = 0; k < ArrayFirst.GetLength(1); k++)
      {
        Element = Element + (ArrayFirst[i,k] * ArraySecond[k,j]);
      }
      ArrayResult[i,j] = Element;
    }
  }
  return ArrayResult;
}

