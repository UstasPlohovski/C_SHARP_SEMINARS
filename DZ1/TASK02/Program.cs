// Задача 2 - из двух чисел найти минимальное и максимальное

Console.Write("Enter the first any integer:");

int number1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter the second any integer:");

int number2 = Convert.ToInt32(Console.ReadLine());

if (number1 > number2)
{
    Console.WriteLine($"The first number {number1} is MAX");
    Console.WriteLine($"The second number {number2} is MIN");
}
else
{
    Console.WriteLine($"The second number {number2} is MAX");
    Console.WriteLine($"The first number {number1} is MIN");
}
