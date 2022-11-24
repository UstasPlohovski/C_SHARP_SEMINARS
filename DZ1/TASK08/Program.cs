// Задача - вывести все четные числа от 1 до N

Console.WriteLine("Enter number");
int Number = Convert.ToInt32(Console.ReadLine());
int CurrentNumber = 1;

while (CurrentNumber <= Number)

{
    if (CurrentNumber%2 == 0)
    { 
        Console.Write($"{CurrentNumber}, ");
    }
        CurrentNumber++ ;
}
