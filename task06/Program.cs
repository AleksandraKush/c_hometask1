Console.WriteLine("Введите число");
int a = Convert.ToInt32(Console.ReadLine());
int b = 0;
b = a % 2;
if(b == 0)
{
    Console.WriteLine($"Число {a} является четным");
}
else
{
    Console.WriteLine($"Число {a} не является четным");
}