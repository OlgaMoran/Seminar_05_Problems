// 3. Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

double MaxArray(double[] array)
{
    int length = array.Length;
    double max = array[0];
    for (int index = 0; index < length; index++)
    {
        if (array[index] > max) max = array[index];
    }
    return max;
}
double MinArray(double[] array)
{
    int count = array.Length;
    double min = array[0];
    for (int position = 0; position < count; position++)
    {
        if (array[position] < min) min = array[position];

    }
    return min;
}

double[] myArray = { 20, -3, 9.3, 6, -28 };
double result = MaxArray(myArray) - MinArray(myArray);

Console.WriteLine(MaxArray(myArray));
Console.WriteLine(MinArray(myArray));
Console.WriteLine();
Console.WriteLine(result);