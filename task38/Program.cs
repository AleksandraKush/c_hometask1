double [] CreateArrayRnaDouble (int size, int min, int max)
{
    double [] array = new double[size];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        double num = rnd.NextDouble() * (max - min) + min;
        array[i] = Math.Round(num, 1);
    }
    return array;
}

void PrintArray(double[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
      if(i < array.Length - 1) Console.Write($"{array[i]}, ");
      else Console.Write($"{array[i]}");
    }
    Console.WriteLine("]");
}

double FindDifference(double[] array)
{
    double max = array[array.Length - 1];
    double min = array[array.Length -1];
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] > max) max = array[i];
        if(array[i] < min) min = array[i];
    }
    return max - min;
}

double[] arr = CreateArrayRnaDouble(6, 2, 80);
PrintArray(arr);
double difference = Math.Round(FindDifference(arr), 1);
Console.WriteLine(difference);