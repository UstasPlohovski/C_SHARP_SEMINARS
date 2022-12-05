
Console.WriteLine("Enter any number:");

try
{
int Number = Convert.ToInt32(Console.ReadLine());

double Size = Math.Floor(Math.Log10(Number)) + 1; 						// определение сколько десятичных разрядов имеет введенное число через применение функции Log(10)

Console.WriteLine($"Введенное число имеет разрядность {Size}");

double CountIteration = Math.Floor(Size / 2); 							// определяем количество проверок соотвертсвия внутри числа, через Math.Floor потому,что колличество цифр в числе может быть не четным

double NumberPoint = 1;

for (NumberPoint = 1; NumberPoint <= CountIteration; NumberPoint++)
{
	double NumberLeft = Math.Floor((Number / Math.Pow(10 , (Size-NumberPoint)))%10);
	double NumberRight = Math.Floor(((Number / Math.Pow(10, NumberPoint-1)) % 10));
	double Result = (NumberLeft - NumberRight);
	Console.WriteLine(Result);
	if (Result !=0)
	{
		//Console.WriteLine("-");
		break;
	}
}

double Result1 = (NumberPoint - CountIteration);
Console.WriteLine(Result1);

if (Result1 == 1)
{
	Console.WriteLine("+");
}
else
{
	Console.WriteLine("-");
}
}
catch
{
    Console.WriteLine("Вы ввели некорректное число. Введите целое положительное число.");
}


