Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());

int Sum(int num)
{
    int result = 0;
    while(num != 0)
    {
       result = result + num % 10;
       num = num / 10;
    }
    return result;
    }

int sum = Sum(number);
Console.WriteLine(sum);