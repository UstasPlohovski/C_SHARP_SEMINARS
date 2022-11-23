// Задача 4 - из трех чисел найти максимальное

Console.Write("Enter the first any integer and press Enter:");

int number1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter the second any integer and press Enter:");

int number2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter the third any integer and press Enter:");

int number3 = Convert.ToInt32(Console.ReadLine());

int max = 0;

if (number1 > number2)
{
    max = number1;
    if (number3 > number1)
    {
        max = number3;
        Console.WriteLine($"The number {max} is MAX");
    }
    else
    {
        Console.WriteLine($"The number {max} is MAX");
    }
}
else
{
    if (number3 > number2)
    {
        max = number3;
        Console.WriteLine($"The number {max} is MAX");
    }
    else
    {
        max = number2;
        Console.WriteLine($"The number {max} is MAX");
    }
}
