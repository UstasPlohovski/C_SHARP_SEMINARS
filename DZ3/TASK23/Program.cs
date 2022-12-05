// Задача 23 Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

try                                                                     // основной блок алгоритма
{
    Console.WriteLine("Введите любое положительное целое число:");
    int Number = Convert.ToInt32(Console.ReadLine());

    for (int i=1; i<=Number; i++)
    {
        Console.Write($"Куб числа {i} = ");
        Console.WriteLine(Kube(i));
    }

}
catch                                                                   // блок алгоритма для ошибок
{
    Console.WriteLine("Введенное число не корректно");
}

// Создание функции возвратного типа
int Kube (int n)
{
    return n*n*n;
}