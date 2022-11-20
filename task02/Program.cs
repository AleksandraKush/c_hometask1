Console.WriteLine("Введите первое число");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ввкедите второе число");
int b = Convert.ToInt32(Console.ReadLine());
int max = a;
int min = b;
if(a > b)
{
    Console.WriteLine($"Большее число - {max}, меньшее число - {min}");
}
else
{
    max = b;
    min = a;
    Console.WriteLine($"Большее число - {max}, меньшее число - {min}");
}