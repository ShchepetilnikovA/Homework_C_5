double[] CreateArray(int size, int min, int max)
{
   
    double[] array = new double[size];

    for(int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(min, max + 1) + new Random().NextDouble();
    }
    return array;
}

void ShowArray(double[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.WriteLine(array[i] + " ");

    Console.WriteLine();
}

double SumOfMaxMin(double[] array)
{
    double min = array[0];
    for(int i = 0; i < array.Length - 1; i++)
    {
        if(array[i] > min) min = array[i];
    }

    double max = array[0];
    for(int j = 0; j < array.Length - 1; j++)
    {
        if(array[j] < max) max = array[j];
    }
    
    double result = min + max;
    return result;
}

Console.WriteLine("Iput array size: ");
int size = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Iput array min value: ");
int min = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Iput array max value: ");
int max = Convert.ToInt32(Console.ReadLine());

double[] array = CreateArray(size, min,max);
Console.WriteLine();

ShowArray(array);
Console.WriteLine();

double result = SumOfMaxMin(array);

Console.WriteLine("Sum of max and min: " + result);