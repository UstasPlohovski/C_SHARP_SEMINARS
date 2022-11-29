// Задача - опредедить выходной или рабочий введенный день недели

Console.WriteLine("Enter your number - day of the week");
int NumberDay = Convert.ToInt32(Console.ReadLine());

if (NumberDay == 6 || NumberDay ==7 )
{
Console.WriteLine("This day is wekkend");
}
else
{
Console.WriteLine("This day is not wekkend");
}