// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу,
// которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int N = new Random().Next(8, 16);                                           // определяем случайный размер массива
Console.WriteLine();
Console.Write($"Определен случайный размер массива (N): {N}");              // от 9 до 15 (крайние значения в случайной выборке не берутся)
int[] Array1 = ReadArray1(N);                                               // функция заполнения массива
WriteArray1(Array1);                                                        // функция печати массива

int CountEvent = CheckForEvent(Array1);                                     // функия проверки числа на четность и суммирования их (четных) количества
Console.WriteLine($"Колличество четных чисел в данном массиве: {CountEvent}");
Console.WriteLine();


// Функции:

int[] ReadArray1(int N)                                                     // функция заполнения массива
{
    int[] Array1 = new int[N];
    for (int i = 0; i < Array1.Length; i++)
    {
        Array1[i] = new Random().Next(100, 999);
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

int CheckForEvent(int[] Array1)                                             // функия проверки числа на четность и суммирования их (четных) количества
{
    int CountEvent = 0;
    for (int i = 0; i < Array1.Length; i++)
    {
        if ((Array1[i] % 2) == 0)
        {
            CountEvent++;
        }
    }
    return CountEvent;
}