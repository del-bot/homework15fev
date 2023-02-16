int [] CreateNewArray (int size, int minVal, int maxVal)
{
    int [] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(minVal, maxVal);
    }
    return array;
}

void ShowArray(int [] array)
{
    for(int i= 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

int FindSumNeg(int [] array)
{
    int sum = array[0];
    for (int i = 0; i < array.Length; i++ )
    {
        if (i % 2 != 0)
        {
            sum += array[i];
        }
    }
    return sum;
}


Console.WriteLine("input size array: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("input minimum value: ");
int minVal = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("input maximum value: ");
int maxVal = Convert.ToInt32(Console.ReadLine());


int [] newArray = CreateNewArray(size, minVal, maxVal);
ShowArray(newArray);

int result = FindSumNeg(newArray);
Console.Write($"Summ of  {result}");