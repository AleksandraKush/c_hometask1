
int SelectSecondVigit(int num)
{
    int a = num % 100;
    return a / 10;
}

Console.WriteLine("Введите трехзначное число");
int number = Convert.ToInt32(Console.ReadLine());

if(number < 1000 && number > 99)
{
    int result = SelectSecondVigit(number);
    Console.WriteLine($"Вторая цифра числа {number} - {result}");
}
else Console.WriteLine("это не трехзначное число");