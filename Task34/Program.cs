/* Задайте массив, заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2*/

int[] GetArray(int size, int a, int b)
{
    int[] arr = new int[size];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(a, b);
        Console.Write($"{arr[i]} ");
    }
    return arr;
}

int EvenNumbers(int[] array)
{
    int[] arr = array;
    int count = 0;
    foreach (int el in arr)
    {
        if (el % 2 == 0)
        {
            count++;
        }
    }
    return count;
}

Console.Clear();
int[] three = GetArray(10, 100, 999);
Console.WriteLine();
Console.WriteLine($"Количество чётных числе в массиве: {EvenNumbers(three)}");
