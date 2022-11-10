/* Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

[3 7 22 2 78] -> 76*/

double[] RandomArray(int size, int min, int max)
{
    double[] array = new double[size];
    for (int count = 0; count < array.Length; count++)
    {
        array[count] = new Random().NextDouble();
        Console.Write($"{array[count]} ");
    }
    return array;
}

double MinValue(double[] array)
{
    double[] arr = array;
    double value = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] < value) value = array[i];
    }
    return value;
}

double MaxValue(double[] array)
{
    double[] arr = array;
    double value = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] > value) value = array[i];
    }
    return value;
}

Console.Clear();
double[] array = RandomArray(10, 1, 10);
double min = MinValue(array);
double max = MaxValue(array);
double diff = max - min;
Console.WriteLine();
Console.WriteLine($"\nРазница между максимумом и минимумом в этом массиве равна {diff}\n");