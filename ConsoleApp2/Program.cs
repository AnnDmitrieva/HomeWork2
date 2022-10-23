Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());
number = Math.Abs(number);

if (number < 99)
{
    Console.WriteLine("Вы ввели не трехзначное число, третьего числа нет.");
}

else
{
    if (number < 1000)
    {
        int rem = number % 10;
        Console.WriteLine(rem);
    }
    else
    {
        while (number >= 1000)
        {
            int rem1 = number % 10;
            number = (number - rem1) / 10;
        }
    int rem = number % 10;
    Console.WriteLine(rem);
    }
}