Console.WriteLine("Введите число");
int n = Convert.ToInt32(Console.ReadLine());

void Cube(int num)
{
    int count = 1;
    while(count <= num)
    {
        int a = count * count * count;
        Console.Write($"{count} ");
        Console.WriteLine(a);
        count++;
    }
    }
if(n > 0) Cube(n);
else Console.WriteLine("число не является натуральным");