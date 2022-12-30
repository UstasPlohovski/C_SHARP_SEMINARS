// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в 
// промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.Write("Введите натуральное число N: ");
int N = Convert.ToInt32(Console.ReadLine());

PrintNumbersWhile(N);
Console.WriteLine();
Console.WriteLine(PrintNumbersRec(N));

void PrintNumbersWhile(int N)
{
   while (true)
   {
     Console.Write($"{N}, ");
     N--;
     if (N==0) break;
   }
}

string PrintNumbersRec(int N)
{
   string Temp = " ";
   if (N!=0)
   {
    Temp = N + ", " + PrintNumbersRec(N-1);
   } 
   return Temp;
}
