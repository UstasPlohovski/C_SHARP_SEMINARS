// Задача - программа, считывающая с пользовательского ввода целое число n (неотрицательное), выводящее это число в консоль вместе с правильным образом изменённым словом "программист", для того, чтобы робот мог нормально общаться с людьми, например: 1 программист, 2 программиста, 5 программистов.

Console.WriteLine("Enter your number");
int Number = Convert.ToInt32(Console.ReadLine());
int Remainder100 = 0;
int Remainder10 = 0;

Remainder100 = Number % 100;
Remainder10 = Number % 10;

if (Remainder100 >= 11 && Remainder100 <= 19)
{
    Console.WriteLine($"В комнате {Number} программистов");
}
else
{
    if (Remainder10 >= 5 && Remainder10 <= 9)
    {
        Console.WriteLine($"В комнате {Number} программистов");
    }
    else
    {
        if (Remainder10 >= 2 && Remainder10 <= 4)
        {
            Console.WriteLine($"В комнате {Number} программиста");
        }
        else
        {
            if (Remainder10 == 1)
            {
                Console.WriteLine($"В комнате {Number} программист");
            }
            else
            {
                Console.WriteLine($"В комнате {Number} программистов");
            }

        }
    }
}