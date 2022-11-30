// Задача - определить вторую цифру в любом произвольном трехзначном заданном целом числе.

Console.WriteLine("Enter number from 100 to 999");
int Number = Convert.ToInt32(Console.ReadLine());
int Remainder = 0;

if (Number >= 100 && Number < 1000)
{
    Number /= 10;
    Remainder = Number % 10;

    Console.WriteLine($"The second number from the left is {Remainder}");

}
else
{
    Console.WriteLine("You entered the number is not from 100 to 999");
}