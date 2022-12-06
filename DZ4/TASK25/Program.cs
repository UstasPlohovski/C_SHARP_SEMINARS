// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

Console.Write("Введите число, возводимое в степень: ");
int X = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число, равное значению степени: ");
int Y = Convert.ToInt32(Console.ReadLine());

int R = X;
try                                                         // основной блок алгоритма
{
Degree(X, Y);                                               // вызов функции возведения числа X в степень Y
PrintResult(X, Y, R);                                       // вызов функции вывода на экран результата вычислений
}
catch                                                       // блок алгоритма на случай возникновения ошибок
{
    Console.WriteLine("Ошибка. Пожалуйста проверьте корректность введенных данных.");
}

                                                            // блок функций
int Degree(int A, int B)                                    // функция возведения числа А в степень В
{
    for (int i = 1; i < B; i++)
    {
        R = R * A;
    }
    return R;
}

void PrintResult(int A, int B, int R)                       // функция печати результата вычислений
{
    Console.WriteLine();
    Console.WriteLine($"Ваш результат - число {A} в степени {B} = {R}");
    Console.WriteLine();
}