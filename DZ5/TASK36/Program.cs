// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, 
// стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

// старт
// формирование массива произвольной размерности от 9 до 15 и заполнеение случайными числами от 1 до 100
// цикл суммирования значений нечетных позиций (i + 2)

int N = new Random().Next(8, 16);                                           // определяем случайный размер массива
Console.WriteLine();
Console.Write($"Определен случайный размер массива (N): {N}");              // от 9 до 15 (крайние значения в случайной выборке не берутся)
int[] Array1 = ReadArray1(N);                                               // функция заполнения массива
WriteArray1(Array1);       

int SumNotEvent = CheckForNotEvent(Array1);                                     // функия проверки числа на четность и суммирования их (четных) количества
Console.WriteLine($"Сумма элементов нечетных позиций массива составляет: {SumNotEvent}");
Console.WriteLine();


// Функции:

int[] ReadArray1(int N)                                                     // функция заполнения массива
{
    int[] Array1 = new int[N];
    for (int i = 0; i < Array1.Length; i++)
    {
        Array1[i] = new Random().Next(0, 100);
    }
    return Array1;
}

void WriteArray1(int[] Array1)                                              // функция печати массива
{
    Console.WriteLine();
    Console.WriteLine("You have new random array:");
    Console.Write("[");
    for (int i = 0; i < (Array1.Length - 1); i++)
    {
        Console.Write($"{Array1[i]}; ");
    }
    Console.Write($"{Array1[^1]}]");
    Console.WriteLine();
}

int CheckForNotEvent(int[] Array1)                                             // функия суммирования чисел в нечетных позициях массива
{
    int SumNotEvent = 0;
    for (int i = 1; i < Array1.Length; i = i+2)
    {
        SumNotEvent = SumNotEvent + Array1[i];
    }
    return SumNotEvent;
}