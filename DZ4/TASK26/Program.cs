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

if (((Number * 10) %10) == 0)
{
    double Size = Math.Floor(Math.Log10(Number)) + 1; 
    Console.WriteLine();	
    Console.WriteLine($"Количество цифр в введенном числе: {Size}");
    Console.WriteLine();
}
else
{
    double NumberTemp = Number;
    while (NumberTemp % 10 !=0)
    {
        NumberTemp = NumberTemp * 10;
    }

    double Size = Math.Floor(Math.Log10(NumberTemp)); 
    Console.WriteLine();
    Console.WriteLine($"Количество цифр в введенном числе: {Size}");
    Console.WriteLine();
}