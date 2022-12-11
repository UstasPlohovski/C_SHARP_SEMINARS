// Задача 38: Задайте массив случайных вещественных чисел. Найдите разницу между максимальным
// и минимальным элементов массива.

// Старт
// Создание функции для генерации вещественных чисел
// Определение и заполнение произвольного массива
// Функция определения минимального значения в массиве
// Функция определения максимального значения в массиве
// Печать результата - разница между максимальным и минимальным значениями
// конец

Console.WriteLine("Введите размер массива: ");
int ArraySize = Convert.ToInt32(Console.ReadLine());

double [] Array = CreateArray(ArraySize);                           // создание и заполнение массива
PrintArray(Array);                                                  // печать массива
double MinNum = MinNumber(Array);                                   // нахождение минимального числа в массиве
double MaxNum = MaxNumber(Array);                                   // нахождение максимального числа в массиве
double Difference = MaxNum - MinNum;                                // разница чисел - результат задачи
Console.WriteLine();                                                // блок вывода результатов на экран
Console.WriteLine($"Минимальное число данного массива: {MinNum}");
Console.WriteLine();
Console.WriteLine($"Максимальное число данного массива: {MaxNum}");
Console.WriteLine();
Console.WriteLine($"Разница данных чисел составляет: {Difference}");
Console.WriteLine();

// Функции:

double[] CreateArray(int N)                                         // функция создания и заполнения массива
{
    double[] Array = new double[N];
    for (int i = 0; i < Array.Length; i++)
    {
        double r = (double) (i);                                    // спорная строка - написана по какому-то наитию после долгих мук, без нее цикл не работал, написана была практически методом "тыка" используя сообщения в консоли "ПРОБЛЕМЫ", но так как цикл заработал после ее добавления - она и осталась в функции
        Array[i] = (double) (RandomRealNum(r));                     // new Random().Next(0, 100);
        //Console.WriteLine(Array[i]);
    }
    return Array;
}

double RandomRealNum (double r)                                     // функция генерации случайныйх вещественных чисел от -100.000 до - 99.999
{
    Random x = new Random();                                                
    r = Convert.ToDouble(x.Next(-100000, 100000)/1000.0);
    return r;
}

void PrintArray(double[] array)                                     // функция печати массива
{
    Console.WriteLine();
    Console.WriteLine("You have new random array:");
    Console.Write("[");
    for (int i = 0; i < (array.Length - 1); i++)
    {
        Console.Write($"{array[i]}; ");
    }
    Console.Write($"{array[^1]}]");
    Console.WriteLine();
}

double MinNumber(double[] array)                                    // функция нахождения минимального значения в массиве
{
    double MinNum = array[0];
    for (int i = 0; i < (array.Length - 1); i++)
    {
        if (array[i] <= MinNum)
        {
            MinNum = array[i];
        }
    }
    return MinNum;
}

double MaxNumber(double[] array)                                    // функция нахождения минимального значения в массиве
{
    double MaxNum = array[0];
    for (int i = 0; i < (array.Length - 1); i++)
    {
        if (array[i] >= MaxNum)
        {
            MaxNum = array[i];
        }
    }
    return MaxNum;
}