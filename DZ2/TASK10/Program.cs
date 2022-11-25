// Задача - определить вторую цифру в любом произвольном трехзначном заданном целом числе.

Console.WriteLine("Enter number from 1 to 999");
int Number = Convert.ToInt32(Console.ReadLine());
int Remainder = 0;

if (Number > 0 && Number < 1000)
{
    Number /= 10;
    Remainder = Number % 10;

    Console.WriteLine($"The third number from the left is {Remainder}");

}
else
{
    Console.WriteLine("You enter the number is not from 0 to 1000");
}