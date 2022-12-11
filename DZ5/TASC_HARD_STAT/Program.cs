// Задача HARD STAT необязательная: Задайте массив случайных целых чисел. Найдите максимальный элемент 
// и его индекс, минимальный элемент и его индекс, среднее арифметическое всех элементов. Сохранить эту 
// инфу в отдельный массив и вывести на экран с пояснениями. Найти медианное значение первоначалального 
// массива , возможно придется кое-что для этого дополнительно выполнить.

// старт
// создание и заполнение массива случайных целых (int) чисел;
// функция нахождения максимального элемента и его индекса (к функции MaxNuber добавить в цикл переменную CurrentIndexMax)
// функция нахождения минимального элемента и его индекса (к функции MinNuber добавить в цикл переменную CurrentIndexMin)
// функция нахождения среднего арифметического через суммирование всех элементов и деление на размер массива
// создание нового массива и заполнение данными, полученных результатов
// блок вывода на экран результирующего массива с пояснениями
// функция нахождения медианного значения первого массива
// вывод на экран результата
// конец

Console.Write("Введите размерность массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = CreateArray(size);
PrintArray(array);
Console.WriteLine();

int MaxNumberArray = FindMaxNumber(array);

int MaxNumberIndexArray = FindMaxNumberIndex(array);

int MinNumberArray = FindMinNumber(array);

int MinNumberIndexArray = FindMinNumberIndex(array);

int AverageArray = FindAverageArray(array);

int[] ArrayResult = CreateArrayResult(MaxNumberArray, MaxNumberIndexArray, 
                                    MinNumberArray, MinNumberIndexArray, AverageArray);
string[] ArrayComment = {"MaxNumberArray", "MaxNumberIndexArray", 
                        "MinNumberArray", "MinNumberIndexArray", "AverageArray"};

PrintTwoArray(ArrayComment, ArrayResult);

Console.WriteLine($"{(FindMedianeArray(array)-1)} - индекс медианного элемента массива");       // значение индекса "-1" потому что в цикле поиска медианы значению нулевого элемента соответствует значение счетчика уже "1"
Console.WriteLine();



// Функции:

int[] CreateArray(int size)  // Функция принимает размер массива и возвращает сгенерированный массив.
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
        //array[i] = new Random().Next(-2147483648, 2147483647);  // указаны максимально возможные ограничения для типа "int"
        array[i] = new Random().Next(0, 101);
    return array;
}

void PrintArray(int[] array)
{
    Console.WriteLine("Ваш случайный массив:");
    foreach (int Element in array)
        Console.Write($"{Element}; ");
    Console.WriteLine();
}

void PrintTwoArray(string[] ArrayText, int[] ArrayValues)
{
    for (int i = 0; i < 4; i++)
    {
        Console.WriteLine($"{ArrayText[i]}: {ArrayValues[i]}");
        Console.WriteLine();
    }
}

int FindMaxNumber (int[] array) // Функция нахождения максимального значения и его индекса в массиве
{
    int MaxNumber = array[0];
    //int CurrentIndexMax = 0;
    for (int i = 1; i < array.Length; i++)
        if (array[i] >= MaxNumber)
        { 
            MaxNumber = array[i];
            //CurrentIndexMax = i;
        }
    //int[] ArrayMax = {MaxNumber, CurrentIndexMax};    
    return MaxNumber;
   
}

int FindMaxNumberIndex (int[] array) // Функция нахождения индекса максимального значения массива
{
    int MaxNumber = array[0];
    int CurrentIndexMax = 0;
    for (int i = 1; i < array.Length; i++)
        if (array[i] > MaxNumber)
        { 
            MaxNumber = array[i];
            CurrentIndexMax = i;
        } 
    return CurrentIndexMax;
   
}

int FindMinNumber (int[] array) // Функция нахождения минимального значения и его индекса в массиве
{
    int MinNumber = array[0];
    //int CurrentIndexMin = 0;
    for (int i = 1; i < array.Length; i++)
        if (array[i] <= MinNumber)
        { 
            MinNumber = array[i];
            //CurrentIndexMin = i;
        }
    //int[] ArrayMin = {MinNumber, CurrentIndexMin};    
    return MinNumber;
   
}

int FindMinNumberIndex (int[] array) // Функция нахождения индекса минимального значения массива
{
    int MinNumber = array[0];
    int CurrentIndexMin = 0;
    for (int i = 1; i < array.Length; i++)
        if (array[i] < MinNumber)
        { 
            MinNumber = array[i];
            CurrentIndexMin = i;
        } 
    return CurrentIndexMin;
   
}

int FindAverageArray (int[] array)  // функция нахождения среднего арифметического массива.
{
    int SumArray = 0;
    for (int i = 0; i < array.Length; i++) SumArray = SumArray + array[i];
    int AverageArray = SumArray / array.Length;
    return AverageArray;
}

int[] CreateArrayResult(int A, int B, int C, int D, int E)  // Функция создания массива с результатами
{
    int[] array = new int [5];
    array [0] = A; 
    array [1] = B;
    array [2] = C;
    array [3] = D;
    array [4] = E;
    return array;
}

int FindMedianeArray (int[] array)          // Функция нахождения медианного элемента массива.
{
    int SumArray = 0;
    int TempSumArray = 0;
    int CurrentIndex = 0;
    for (int i = 0; i < array.Length; i++) 
    {
        SumArray = SumArray + array[i];
    }
    
    for (int i = 0; i < array.Length; i = i+1)
    {
        if (TempSumArray <= (SumArray / 2))
        {
            TempSumArray = TempSumArray + array[i];
            CurrentIndex = CurrentIndex + 1;
        }
    }
    return CurrentIndex;
}