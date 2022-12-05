// Задача 21 - HARD необязательная. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в N-мерном пространстве. Сначала задается N с клавиатуры, потом задаются координаты точек.

try                                                                 // основной блок алгоритма
{
    Console.WriteLine("Введите размерность пространства (N): ");    // определяем размерность пространства
    int N = Convert.ToInt32(Console.ReadLine());

    int[] ArrayA = new int [N];                                     // вводим координаты точки А в виде массива
    for (int i = 0; i < ArrayA.Length; i++)
    {
        Console.WriteLine($"Введите {(i+1)}ую координату точки A");
        ArrayA[i] = Convert.ToInt32(Console.ReadLine());
    }

    int[] ArrayB = new int [N];                                     // вводим координаты точки В в виде массива
    for (int i = 0; i < ArrayB.Length; i++)
    {
        Console.WriteLine($"Введите {(i+1)}ую координату точки B");
        ArrayB[i] = Convert.ToInt32(Console.ReadLine());
    }
    
    int[] ArrayResult = new int [N];                                // формируем массив в результатами - квадратов разницы соответствующих координат двух точек
    for (int i = 0; i < ArrayResult.Length; i++)
    {
        ArrayResult[i] = ((ArrayA[i]-ArrayB[i]) * (ArrayA[i]-ArrayB[i]));
    }
    int SumArrayResult = 0;                                         // определяем сумму всех элементов итогового (результирующего) массива
    Array.ForEach(ArrayResult, i => SumArrayResult += i);
    // Console.WriteLine(SumArrayResult);                           // вспомогательная строка для контроля работы алгоритма

    double Distance = Math.Sqrt(SumArrayResult);                    // расчитываем дистанцию между точками через извлечение квадратного корня из суммы всех элементов результирующего массива
    Console.WriteLine($"Расстояние между точками составляет {Distance} ед.");
}

catch                                                               // блок алгоритма на случай ошибок в основном блоке
{
    Console.WriteLine("Ошибка: проверьте корректность введенных данных.");
}