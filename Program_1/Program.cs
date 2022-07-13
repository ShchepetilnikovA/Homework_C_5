int[] CreateArray()
{
    int[] array = new int[8];

    for(int i = 0; i < 8; i++)
    {
        array[i] = new Random().Next(1, 1000);
    }
    return array;
}

void ShowArray(int[] array)
{
    for(int i = 0; i < 8; i++)
        Console.WriteLine(array[i] + " ");

    Console.WriteLine();
}

int SumOfEven(int[] array)
{
    int sum = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] % 2 ==0) sum ++;
    }
    return sum;
}

int[] array = CreateArray();

ShowArray(array);

int result = SumOfEven(array);

Console.WriteLine("Sum of even is: " + result);
