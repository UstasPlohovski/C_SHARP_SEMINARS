// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе. Через строку решать нельзя.
// 452 -> 11
// 82 -> 10
// 9012 -> 12


Console.Write("Enter your number: ");
double Number = Convert.ToInt32(Console.ReadLine());

double NumberSize = Math.Floor(Math.Log10(Number)) + 1; 	        // определение размерности (длинны) числа

double NumSum = 0;
double NumberTemp = 0;

try                                                                 // основной блок алгоритма
{
    Sum(Number);
    PrintSum(NumSum);
}
catch                                                               // блок алгоритма на случай возникновения ошибок
{
    Console.WriteLine("Ошибка. Пожалуйста проверьте корректность введенных данных.");
}

double Sum(double A)                                                // функция вычислений результата
{
    for (int i = 0; i < NumberSize; i++)
    {
        NumberTemp = Math.Floor((A / Math.Pow(10, (i))) % 10);
        NumSum = NumSum + NumberTemp;
    }
    return NumSum;
}

void PrintSum(double A)                                             // функция печати результата вычислений
{
    Console.WriteLine();
    Console.WriteLine($"Сумма цифр данного числа составляет: {A}");
    Console.WriteLine();
}