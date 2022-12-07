// Задача 29: Напишите программу, которая задаёт массив из 8 целых чисел с клавиатуры и далее выводит массив на экран в одну строку.

Console.WriteLine("Введите размер массива (N): ");                  // определяем размер массива
int N = Convert.ToInt32(Console.ReadLine());

int[] ArrayA = new int[N];                                          // создаем пустой массив заданного размера
for (int i = 0; i < ArrayA.Length; i++)
{
    Console.WriteLine($"Введите значение {i}-го элемента массива");
    ArrayA[i] = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine();
Console.Write("You have new array: [");
for (int i = 0; i < (ArrayA.Length - 1); i++)
{
    Console.Write($"{ArrayA[i]}; ");
}
Console.Write($"{ArrayA[^1]}]");