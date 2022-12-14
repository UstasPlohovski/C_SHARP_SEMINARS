// задача 2 HARD необязательная. Сгенерировать массив случайных целых чисел размерностью m*n 
//(размерность вводим с клавиатуры). Вывести на экран красивенько таблицей. Найти минимальное 
//число и его индекс, найти максимальное число и его индекс. Вывести эту информацию на экран.

// функция генерации двухмерного массива через цикл - начиная с первой сточки заполняем каждый столбец и так до последней строчки
// функция вывода на печать сгенерированного массива
// функция поиска максимального значения через цикл аналогичный генерации массива
// функция поиска минимального значения через цикл аналогичный генерации массива
// вывод на экран результатов

int M = new Random().Next(3, 7);                                           
int N = new Random().Next(2, 6);   
Console.WriteLine();
Console.WriteLine($"Определен случайный размер массива: {M} X {N}");
Console.WriteLine();              
int[,] Array = CreateArray(M, N);                                               
PrintArray(Array, M, N);
Console.WriteLine(); 
int MinNumber = FindMinNumber(Array);
int MinIndexM = FindMinNumberInM(Array);
int MinIndexN = FindMinNumberInN(Array);       
Console.WriteLine($"Минимальный элемент массива: {MinNumber}, его индекс [{MinIndexM}, {MinIndexN}]");
int MaxNumber = FindMaxNumber(Array);
int MaxIndexM = FindMaxNumberInM(Array);
int MaxIndexN = FindMaxNumberInN(Array);       
Console.WriteLine($"Максимальный элемент массива: {MaxNumber}, его индекс [{MaxIndexM}, {MaxIndexN}]");

// Функции:

int[,] CreateArray(int M, int N)                                                   
{
    int[,] Array = new int[N,M];
    for (int i = 0; i < N; i++)
    {
        for (int j = 0; j < M; j++)
        {
            Array [i,j] = new Random().Next(1, 999);
        }
    }
    return Array;
}

void PrintArray(int[,] Array, int M, int N)
{
    for (int i = 0; i < N; i++)
    {
        for (int j = 0; j < M; j++)
        {
            Console.Write($"{Array[i,j]}\t");
        }
        Console.WriteLine();
    }
}

int FindMinNumber(int[,] Array)                                                   
{
    int MinNumber = Array[0,0];
    int MinIndexM = 0;
    int MinIndexN = 0;
    for (int i = 0; i < N; i++)
    {
        for (int j = 0; j < M; j++)
        {
            if (Array[i,j] < MinNumber)
            {
                MinNumber = Array[i,j];
                MinIndexM = i;
                MinIndexN = j;
            }
        }
    }
    return MinNumber;
}

int FindMinNumberInM(int[,] Array)                                                   
{
    int MinNumber = Array[0,0];
    int MinIndexM = 0;
    int MinIndexN = 0;
    for (int i = 0; i < N; i++)
    {
        for (int j = 0; j < M; j++)
        {
            if (Array[i,j] < MinNumber)
            {
                MinNumber = Array[i,j];
                MinIndexM = i;
                MinIndexN = j;
            }
        }
    }
    return MinIndexM;
}

int FindMinNumberInN(int[,] Array)                                                   
{
    int MinNumber = Array[0,0];
    int MinIndexM = 0;
    int MinIndexN = 0;
    for (int i = 0; i < N; i++)
    {
        for (int j = 0; j < M; j++)
        {
            if (Array[i,j] < MinNumber)
            {
                MinNumber = Array[i,j];
                MinIndexM = i;
                MinIndexN = j;
            }
        }
    }
    return MinIndexN;
}

int FindMaxNumber(int[,] Array)                                                   
{
    int MaxNumber = Array[0,0];
    int MaxIndexM = 0;
    int MaxIndexN = 0;
    for (int i = 0; i < N; i++)
    {
        for (int j = 0; j < M; j++)
        {
            if (Array[i,j] > MaxNumber)
            {
                MaxNumber = Array[i,j];
                MaxIndexM = i;
                MaxIndexN = j;
            }
        }
    }
    return MaxNumber;
}

int FindMaxNumberInM(int[,] Array)                                                   
{
    int MaxNumber = Array[0,0];
    int MaxIndexM = 0;
    int MaxIndexN = 0;
    for (int i = 0; i < N; i++)
    {
        for (int j = 0; j < M; j++)
        {
            if (Array[i,j] > MaxNumber)
            {
                MaxNumber = Array[i,j];
                MaxIndexM = i;
                MaxIndexN = j;
            }
        }
    }
    return MinIndexM;
}

int FindMaxNumberInN(int[,] Array)                                                   
{
    int MaxNumber = Array[0,0];
    int MaxIndexM = 0;
    int MaxIndexN = 0;
    for (int i = 0; i < N; i++)
    {
        for (int j = 0; j < M; j++)
        {
            if (Array[i,j] > MaxNumber)
            {
                MaxNumber = Array[i,j];
                MaxIndexM = i;
                MaxIndexN = j;
            }
        }
    }
    return MaxIndexN;
}

