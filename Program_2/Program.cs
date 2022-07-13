int[] CreateArray(int size, int min, int max)
{
    int[] array = new int[size];

    for(int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(min, max + 1);
    }
    return array;
}

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.WriteLine(array[i] + " ");

    Console.WriteLine();
}

int SumOfNotEven(int[] array)
{
    int sum = 0;
    for(int i = 1; i < array.Length; i++)
    {
        if(i % 2 > 0) sum += array[i]; 
    }
    return sum;
}

Console.WriteLine("Iput array size: ");
int size = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Iput array min value: ");
int min = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Iput array max value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] array = CreateArray(size, min, max);

Console.WriteLine();

ShowArray(array);

int result = SumOfNotEven(array);

Console.WriteLine("Sum of not even is: " + result);