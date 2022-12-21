// Задача HARD SORT необязательная. Считается за три обязательных 
// Задайте двумерный массив из целых чисел. Количество строк и столбцов задается с клавиатуры. Отсортировать элементы по возрастанию слева направо и сверху вниз.
// Например, задан массив:
// 1 4 7 2
// 5 9 10 3
// После сортировки
// 1 2 3 4
// 5 7 9 10


// Создание и заполнение двумерного массивва размером m×n, заполненного случайными целыми числами.
// Трансформация двумерного массива в одномерный.
// Сортировка одномерного массива.
// Трансформация одномерного отсортированного массива в двумерный начальной размерности.

Console.WriteLine("Введите количество строк двумерного массива");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов двумерного массива");
int cols = Convert.ToInt32(Console.ReadLine());
int[,] ArrayStart = new int [rows, cols];
ArrayStart = FillArray(ArrayStart);
Console.WriteLine("Сформирован случайный массив:");
PrintArray(ArrayStart);
int[] ArrayTemp = ArrayTransform(ArrayStart, rows, cols);
Console.WriteLine();
Console.WriteLine("Массив трансформирован в одномерный:");
PrintArrayTemp(ArrayTemp);
Console.WriteLine();
int[] ArraySelect = SelectionSort(ArrayTemp);
Console.WriteLine("Массив отсортирован:");
PrintArrayTemp(ArraySelect);
Console.WriteLine();
int[,] ArrayFinish = new int[rows, cols];
ArrayFinish = ArrayFinishTransform(ArrayTemp, rows, cols);
Console.WriteLine("Массив трансформирован обратно в двумерный:");
PrintArray(ArrayFinish);

// Функции

int[,] FillArray(int[,] array)
{
    for (int i=0;i<array.GetLength(0);i++)
        for (int j=0;j<array.GetLength(1);j++)
            array[i,j] = new Random().Next(1,99);
    return array;
}

int[] ArrayTransform(int[,] array, int rows, int cols)
{
    int SizeForArrayTemp = rows * cols;
    int[] ArrayTemp = new int [SizeForArrayTemp];
    int Index = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    for (int j = 0; j < array.GetLength(1); j++)
    {
        ArrayTemp[Index] = array[i,j];
        Index++;
    }
    return ArrayTemp;
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

void PrintArrayTemp(int[] array) 
{ 
    foreach (int el in array)
        Console.Write($"{el} "); 
    Console.WriteLine(); 
} 

int[,] ArrayFinishTransform(int[] array, int rows, int cols)
{
    int[,] ArrayFinish = new int[rows, cols];

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            ArrayFinish[i,j] = array[i*rows+j];
        }
    }
    return ArrayFinish;
}

int[] SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int MinPosition = i;
        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] < array[MinPosition])
            {
                MinPosition = j;
            }
        }
        int temporary = array[i];
        array[i] = array[MinPosition];
        array[MinPosition] = temporary;
    }
    return array;
}