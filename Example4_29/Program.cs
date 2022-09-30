using static System.Console;
Clear();
int size = 8;
int[] array = GetRandomArray(size);
PrintArray(array);











int[] GetRandomArray(int lenght)
{
    int[] result = new int[lenght];
    for (int i = 0; i < lenght; i++)
    {
        result[i] = new Random().Next(0, 101);
    }
    return result;
}

void PrintArray(int[] MyArray)
{
    Write("[");
    for (int i = 0; i < MyArray.Length - 1; i++)
    {
        Write($"{MyArray[i]},");
    }
    Write($"{MyArray[MyArray.Length - 1]}]");
}