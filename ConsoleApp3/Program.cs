Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());
number = Math.Abs(number);

if ( number == 1 || number == 2 || number == 3 || number == 4 || number == 5 )
{
    Console.WriteLine("Сегодня не выходной день.");
}

if ( number == 6 || number == 7 )
{
    Console.WriteLine("Выходной!");
}

if ( number < 1 || number > 7 )
{
    Console.WriteLine("Введите число от 1 до 7!");
}