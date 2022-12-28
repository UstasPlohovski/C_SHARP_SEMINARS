// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка


// Сгенерировать случайный двухмерный массив
// Используя функцию нахождения суммы строк массива создать одномерный массив из результатов сумм строк
// В полученном двумерном массиве определить минимальный элемент и его индекс - это строка с минимальной суммой
// Вывести результаты на экран

Console.WriteLine("Введите количество строк двумерного массива");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов двумерного массива");
int cols = Convert.ToInt32(Console.ReadLine());
int[,] ArrayStart = new int [rows, cols];
ArrayStart = FillArray(ArrayStart);
Console.WriteLine("Сформирован случайный массив:");
PrintArray(ArrayStart);
int[] ArrayLine = new int [ArrayStart.GetLength(0)];
for (int i = 0; i < ArrayLine.Length; i++)
    {
        ArrayLine[i] = SumLineArray (ArrayStart, i);
    }
PrintArrayLine(ArrayLine);
Console.WriteLine();
Console.WriteLine($"Номер строки с наименьшей суммой: {FindMinNumberIn(ArrayLine)+1}");

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

int SumLineArray (int[,] array, int IndexLine)
{
    int SumLine = 0; //array[IndexLine,0];
    for (int j = 0; j < array.GetLength(1); j++)
    {
        SumLine = SumLine + array[IndexLine,j];
    }
    return SumLine;
}

void PrintArrayLine(int[] array)                                      
{
    Console.Write("Сформирован массив сумм строк: [");
    for (int i = 0; i < (array.Length - 1); i++)
    {
        Console.Write($"{array[i]}; ");
    }
    Console.Write($"{array[^1]}]");
}

int FindMinNumberIn(int[] array)                                                   
{
    int MinNumber = array[0];
    int MinIndex = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < MinNumber)
            {
                MinNumber = array[i];
                MinIndex = i;
            }
    }
    return MinIndex;
}

// int[] FillArrayLine(int[] array)
// {                                            
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = Convert.ToInt32(Console.ReadLine());
//     }
//     return Array1;
// }

// Console.WriteLine($"Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.");
// Console.WriteLine($"\nВведите размер массива m x n и диапазон случайных значений:");
// int m = InputNumbers("Введите m: ");
// int n = InputNumbers("Введите n: ");
// int range = InputNumbers("Введите диапазон: от 1 до ");

// int[,] array = new int[m, n];
// CreateArray(array);
// WriteArray(array);

// int minSumLine = 0;
// int sumLine = SumLineElements(array, 0);
// for (int i = 1; i < array.GetLength(0); i++)
// {
//   int tempSumLine = SumLineElements(array, i);
//   if (sumLine > tempSumLine)
//   {
//     sumLine = tempSumLine;
//     minSumLine = i;
//   }
// }

// Console.WriteLine($"\n{minSumLine+1} - строкa с наименьшей суммой ({sumLine}) элементов ");


// int SumLineElements(int[,] array, int i)
// {
//   int sumLine = array[i,0];
//   for (int j = 1; j < array.GetLength(1); j++)
//   {
//     sumLine += array[i,j];
//   }
//   return sumLine;
// }

// int InputNumbers(string input)
// {
//   Console.Write(input);
//   int output = Convert.ToInt32(Console.ReadLine());
//   return output;
// }

// void CreateArray(int[,] array)
// {
//   for (int i = 0; i < array.GetLength(0); i++)
//   {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//       array[i, j] = new Random().Next(range);
//     }
//   }
// }

// void WriteArray (int[,] array)
// {
//   for (int i = 0; i < array.GetLength(0); i++)
//   {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//       Console.Write(array[i,j] + " ");
//     }
//     Console.WriteLine();
//   }
// }