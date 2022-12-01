int[] CreateArrayRnaInt (int size, int min, int max)
{
    int[] array = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(min, max +1);
    }
    return array;
}

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
      if(i < array.Length - 1) Console.Write($"{array[i]}, ");
      else Console.Write($"{array[i]}");
    }
    Console.WriteLine("]");
}

int SumOdd(int[] array)
{
    int result = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if((i + 1 ) % 2 != 0) result += array[i];
    }
    return result;
}

int[] arr = CreateArrayRnaInt(4, -5, 23);
PrintArray(arr);
int res = SumOdd(arr);
Console.WriteLine(res);