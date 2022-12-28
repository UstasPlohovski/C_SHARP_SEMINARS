// Задача 62: Заполните спирально массив 4 на 4.
// 1 2 3 4
// 12 13 14 5
// 11 16 15 6
// 10 9 8 7

// Цикличный алгоритм сданный на Контроле версий заполнение с чередованием строки и столбца меняя направления с уменьшением счетчика

Console.WriteLine("Введите параметр массива (N x N):");
int Size = Convert.ToInt32(Console.ReadLine());
int[,] ArraySpiral = new int[Size, Size];
ArraySpiral = FillArraySpiral (ArraySpiral, Size);
PrintArray (ArraySpiral);


// Функции

int[,] FillArraySpiral (int[,] ArraySpiral, int Size)
{
    int ElementTemp = 1;
    int i = 0;
    int j = 0;
    while (ElementTemp <= Size * Size)
    {
    ArraySpiral[i, j] = ElementTemp;
    ElementTemp++;
    if (i <= j + 1 && i + j < ArraySpiral.GetLength(1) - 1)
        j++;
    else if (i < j && i + j >= ArraySpiral.GetLength(0) - 1)
        i++;
    else if (i >= j && i + j > ArraySpiral.GetLength(1) - 1)
        j--;
    else
        i--;
    }
    return ArraySpiral;
}

void PrintArray (int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      if (array[i,j] / 10 <= 0)
      Console.Write($" {array[i,j]} ");

      else Console.Write($"{array[i,j]} ");
    }
    Console.WriteLine();
  }
}