int FindThirdVigit(int num, int res)
{
    while(num > 99)
    {
        res = num % 10;
        num = num / 10;
    }
    return res;
}


Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
int result = 0;

if(number > 99)
{
    int thirdvigit = FindThirdVigit(number, result);
    Console.WriteLine($"Третья цифра числа {number} - {thirdvigit}");
}
else Console.WriteLine("третьей цифры нет");