// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

// ввод данных знаяения коэффициентов b и k через массив
// нахождение значения X
// надождение значения Y
// вывод на печать результата

Console.WriteLine("Введите значения коэффициентов для уравнения первой прямой: ");
double[] ArrayForFirstEquation = ReadArray();
Console.WriteLine("Введите значения коэффициентов для уравнения второй прямой: ");
double[] ArrayForSecondEquation = ReadArray();
double X = FindPointX(ArrayForFirstEquation, ArrayForSecondEquation); 
double Y = FindPointY(ArrayForFirstEquation, ArrayForSecondEquation, X);

Console.WriteLine($"Координаты точки пересечения прямых: X = {X} ; Y = {Y} ");

// Функции:

double[] ReadArray()                                           
{
    double[] ArrayForEquation = new double[2];
    Console.WriteLine("Введите значение коэффициента К: ");
    ArrayForEquation[0] = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Введите значение коэффициента B: ");
    ArrayForEquation[1] = Convert.ToDouble(Console.ReadLine());
    
    return ArrayForEquation;
}

double FindPointX (double[] Array1, double[]Array2)
{
    double X = (Array2[1] - Array1[1]) / (Array1[0] - Array2[0]);
    return X;
}

double FindPointY (double[] Array1, double[]Array2, double X)
{
    double Y = (Array1[0] * X + Array1[1]);
    return Y;
}