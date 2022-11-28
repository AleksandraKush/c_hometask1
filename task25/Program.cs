Console.WriteLine("Введите число A");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B");
int b = Convert.ToInt32(Console.ReadLine());

int Exponentiation(int num1, int num2)
{
    int result = 1;
    for (int i = 1; i <= num2; i++)
    {
      result = result * num1;
    }
    return result;
}

if (b > 0) 
{
    int exponentiation = Exponentiation(a, b);
    Console.WriteLine(exponentiation);
}
else Console.WriteLine("Число В не является натуральным");