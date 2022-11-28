int[] array = new int[8];

void ArrayRandom(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(1, 100);
        if (i == arr.Length - 1) Console.Write($"{arr[i]}]");
        else Console.Write($"{arr[i]}, ");
    }
}

ArrayRandom(array);