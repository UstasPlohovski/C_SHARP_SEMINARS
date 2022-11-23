// Задача 6 - определение четности или нечетности введенного числа.

Console.Write("Enter the any integer and press Enter:");

double number = Convert.ToInt32(Console.ReadLine());

double result = number % 2;

if (result == 0)
{
    Console.WriteLine($"Nuber {number} is even number");
}
else
{

    Console.WriteLine($"Nuber {number} is not even number");
}