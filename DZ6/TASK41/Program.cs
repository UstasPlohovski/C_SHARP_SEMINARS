// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

// создать цикл на ввод числа и его проверку с увеличением счетчика
// поставить в цикл условие на прерывание цикла
// вывод результата на печать

double Count = 0;
string Enter = "Start";
CheckNumber(Enter);
Console.WriteLine($"Колличество {Count}");

double CheckNumber(string Enter)
{
    while (Enter != "end")
    {
        Console.WriteLine("Введите число для проверки. В случае завершения ввода, введите - end.");
        Enter = Console.ReadLine();
        double Number = Convert.ToDouble(Enter);
        if (Number > 0)
        {
            Count++;
        }
        Console.WriteLine($"Колличество введенных чисел больше 0 составляет: {Count}");
    }
    return Count;
}