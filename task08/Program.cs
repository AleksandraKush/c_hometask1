Console.WriteLine("Введите число");
int a = Convert.ToInt32(Console.ReadLine());
int count = 1;
int r = 0;
while(count < a)
{
    r = count % 2;
    if(r == 0);
    {
        count++;
    }
    Console.WriteLine($"{count} ");
    count++;
    }