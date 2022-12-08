// Задача 26. - HARD необязательная Напишите программу, которая принимает на вход целое или дробное число и выдаёт количество цифр в числе.
// 452 -> 3
// 82 -> 2
// 9,012 ->4


// Ввод данных

// Проверка на тип числа ЦЕЛОЕ / НЕЦЕЛОЕ

// Если ЦЕЛОЕ - применяем "старый" алгоритм нахождания порядка разрядности числа

// Если НЕЦЕЛОЕ - применяем алгоритм приведения числа к ЦЕЛОМУ виду, а затем находим разядность по "старому" алгоритму 

// Конец

Console.Write("Введите любое число и нажмите Enter: ");

double Number = Convert.ToDouble(Console.ReadLine());
double SizeNum1 = 0;
double SizeNum2 = 0;

if ((Check1(Number)) == 0)
{
    SizeNum1 = Size1(Number); 
    PrintSize1(SizeNum1);
}
else
{
    double NumberTemp = Number;
    while (NumberTemp % 10 !=0)
    {
        NumberTemp = NumberTemp * 10;
    }
    SizeNum2 = Size1(NumberTemp) - 1; 
    PrintSize1(SizeNum2);
    // double Size = Math.Floor(Math.Log10(NumberTemp)); 
    // Console.WriteLine();
    // Console.WriteLine($"Количество цифр в введенном числе: {Size1}");
    // Console.WriteLine();
}
// Функции:

double Check1(double N)
{
    double NumberTemp1 = (N * 10) % 10;
    return NumberTemp1;
}

double Size1(double N) 
{   double SizeNum1 = Math.Floor(Math.Log10(N)) + 1;
    return SizeNum1;
}

void PrintSize1 (double Size1)
{
    Console.WriteLine();	
    Console.WriteLine($"Количество цифр в введенном числе: {Size1}");
    Console.WriteLine();
}