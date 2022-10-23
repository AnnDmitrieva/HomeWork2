Console.Write("Введите трехзначное число: ");
int number = int.Parse(Console.ReadLine());
number = Math.Abs(number);

int a1 = number % 10;
int number2 = ( number - a1 ) / 10;
int a2 =  number2 % 10;
int number3 = ( number2 - a2 ) / 10;

if ( number3 < 1 )
{
     Console.WriteLine("Вы ввели двухзначное число");
}
 else
{
     Console.WriteLine(a2);
}
    
   