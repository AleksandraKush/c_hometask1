bool DayCheck(int num)
{
    return num == 6 || num == 7;
}

Console.WriteLine("Введите цифру от 1 до 7");
int number = Convert.ToInt32(Console.ReadLine());

if(number < 8 && number > 0)
{
    bool result = DayCheck(number);
    Console.WriteLine(result ? "да" : "нет");
}
else Console.WriteLine("цифра не подходит под заданный диапазон");