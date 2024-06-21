int[] array = { 7, 0, -4, 3, 1, -2, 5 };

int buf = 0;

for (int i = 0; i < array.Length; i++)
{
    Console.Write($"{array[i]}\t");
}
Console.WriteLine();

for (int i = array.Length - 1; i > 0; i--)
{
    for (int j = 0; j < i; j++)
    {
        if (array[j] > array[j + 1])
        {
            buf = array[j];
            array[j] = array[j + 1];
            array[j + 1] = buf;
        }
    }

    for (int j = 0; j < array.Length; j++)
    {
        Console.Write($"{array[j]}\t");
    }
    Console.WriteLine();

}
