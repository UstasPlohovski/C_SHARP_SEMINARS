// Задача 19 - HARD необязательная.
// Напишите программу, которая принимает на вход целое число любой разрядности и проверяет, является ли оно палиндромом. Через строку нельзя решать само собой.

Console.WriteLine("Введите любое целое положительное число и нажмите Enter:");

try																		// основной блок алгоритма
{
int Number = Convert.ToInt32(Console.ReadLine());

double Size = Math.Floor(Math.Log10(Number)) + 1; 						// определение сколько десятичных разрядов имеет введенное число через применение функции Log(10)

// Console.WriteLine($"Введенное число имеет разрядность {Size}");		// вспомогательная строка использовалась для контроля работы алгоритма

double CountIteration = Math.Floor(Size / 2); 							// определяем количество проверок соотвертсвия внутри числа, через Math.Floor потому,что колличество цифр в числе может быть не четным

double NumberPoint = 1;

for (NumberPoint = 1; NumberPoint <= CountIteration; NumberPoint++)		// цикл для определения сравниваемых цифр в числе
{
	double NumberLeft = Math.Floor((Number / Math.Pow(10 , (Size-NumberPoint)))%10);
	double NumberRight = Math.Floor(((Number / Math.Pow(10, NumberPoint-1)) % 10));
	double Result = (NumberLeft - NumberRight);
	// Console.WriteLine(Result);										// вспомогательная строка использовалась для контроля работы алгоритма
    // double Palindrom(NumberPoint, CountIteration);					// неудачная попытка сделать через метод (функию), не
	if (Result !=0)														// проверка - в случае определения перого же не соответствия сравнивамых цифр - останавливаем дальнейшие проверки, число не палиндром
	{
		//Console.WriteLine("-");
		break;
	}
}

double Result1 = (NumberPoint - CountIteration);						// переменная, проверяющая, что цикл проверки соответствия цифр был пройден полностью, т.е. все сверяемые пары цифр совпали
// Console.WriteLine(Result1);											// вспомогательная строка использовалась для контроля работы алгоритма

if (Result1 == 1)
{
	Console.WriteLine($"Введенное число {Number} - палиндром");
}
else
{
	Console.WriteLine($"Введенное число {Number} - не палиндром");
}
}
catch																	// вспомогательный блок алгоритма для некорректного ввода
{
    Console.WriteLine("Вы ввели некорректное число. Введите целое положительное число.");
}

// double Palindrom (double Result)											// попытка создания метода
// {
//  double NumberLeft = Math.Floor((Number / Math.Pow(10 , (Size-NumberPoint)))%10);
// 	double NumberRight = Math.Floor(((Number / Math.Pow(10, NumberPoint-1)) % 10));
// 	double Result = (NumberLeft - NumberRight);
// 	Console.WriteLine(Result);
// }
