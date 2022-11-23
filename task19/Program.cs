Console.WriteLine("Введите пятизначное число");
int number = Convert.ToInt32(Console.ReadLine());

bool Palindrome(int num)
{
    int a = num / 10000;
    int b = num % 10; 
    int c = num / 1000 % 10;
    int d = num % 100 / 10;
    return a == b && c == d;
}

if(number < 100000 && number > 9999)
{
    bool result = Palindrome(number);
    Console.WriteLine(result ? "да" : "нет");
}
else Console.WriteLine("цифра не подходит под заданный диапазон");