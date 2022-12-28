// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

// Сгенерировать случайный двумерный массив
// Создать циклицескую функцию построчной сортировки элементов, использую метод "мини-макс"
// Отсортированный массив вывести на экран

Console.WriteLine("Введите количество строк двумерного массива");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов двумерного массива");
int cols = Convert.ToInt32(Console.ReadLine());
int[,] ArrayStart = new int [rows, cols];
ArrayStart = FillArray(ArrayStart);
Console.WriteLine("Сформирован случайный массив:");
PrintArray(ArrayStart);
int[,] ArraySort = SortArray(ArrayStart);
Console.WriteLine("Получен отсотированный массив:");
PrintArray(ArraySort);


// Функции

int[,] FillArray(int[,] array)
{
    for (int i=0;i<array.GetLength(0);i++)
        for (int j=0;j<array.GetLength(1);j++)
            array[i,j] = new Random().Next(1,99);
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

int[,] SortArray(int[,] Array)
{
  for (int i = 0; i < Array.GetLength(0); i++)
  {
    for (int j = 0; j < Array.GetLength(1); j++)
    {
      for (int k = 0; k < Array.GetLength(1) - 1; k++)
      {
        if (Array[i, k] < Array[i, k + 1])
        {
          int TempNumb = Array[i, k + 1];
          Array[i, k + 1] = Array[i, k];
          Array[i, k] = TempNumb;
        }
      }
    }
  }
  return Array;
}
