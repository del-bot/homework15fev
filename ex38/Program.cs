double [] CreateNewArray (int size)
{
    double [] array = new double[size];
    for (int i = 0; i < size; i++)
    {
       
        array[i] = new Random().NextDouble() * 100;
        Console.Write("{0,6:F2}", array[i]);
    
    }
    Console.WriteLine();
    return array;
}

void MinMaxArray (double [] array)
{
    double result = 0;
    double minValue = array[0];
    double maxValue = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if ( array[i] < minValue)
        {
            minValue = array[i];
        }   
        else if (array[i] > maxValue)
        {
            maxValue = array[i];
        }
    
    }
    result = maxValue - minValue;
    Console.WriteLine( "{0,6:F2}", result);
}




Console.Write("input array size: ");
int userSize = Convert.ToInt32(Console.ReadLine());

MinMaxArray(CreateNewArray(userSize));



