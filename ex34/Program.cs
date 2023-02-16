int [] CreateNewArray(int size_array)
{
    int [] random01array = new int [size_array];
    for (int i= 0; i < size_array; i++)
    {
        random01array[i] = new Random().Next(100, 1000);
    }
    return random01array;
}

void ShowCreatedArray(int [] array01)
{
    int quan = 0;
    int even = 0;
    for (int i = 0; i < array01.Length; i++)
       {Console.WriteLine(array01[i] + " ");
        even = array01[i] % 2;
            if (even == 0)
            {
                 quan ++;
            }
       }
       Console.WriteLine(quan);
}

Console.WriteLine("input the length of array: ");
int lengthArray = Convert.ToInt32(Console.ReadLine());
ShowCreatedArray(CreateNewArray(lengthArray));