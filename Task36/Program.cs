/*Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19

[-4, -6, 89, 6] -> 0*/

int[] RandomArray(int size, int min, int max)
{
    int[] array = new int[size];
    for (int count = 0; count < array.Length; count++)
    {
        array[count] = new Random().Next(min, max);
        Console.Write($"{array[count]} ");
    }
    return array;
}

int OddSumm(int[] array)
{
    int[] arr = array;
    int summ = 0;
    foreach (int el in arr)
    {
        if (el % 2 != 0)
            summ = el + summ;
    }
    return summ;
}

bool Ratio(int[] array)
{
    int[] arr = array;
    int oddSum = 0;
    int evenSum = 0;

    foreach (int el in array)
    {
        if (el % 2 == 0) evenSum = el + evenSum;
        else oddSum = el + oddSum;
    }
    if (oddSum > evenSum) return true;
    else return false;
}


Console.Clear();
int[] RandArray = RandomArray(10, 1, 10);
Console.WriteLine();
Console.WriteLine();
Console.WriteLine($"Сумма нечётных чисел в этом массиве равна {OddSumm(RandArray)}\n");
if (Ratio(RandArray) == true) Console.WriteLine("Кстати, нечётных чисел в этом массиве получилось больше, чем чётных");
else Console.WriteLine("Кстати, нечётных чисел в этом массиве получилось меньше, чем чётных");
Console.WriteLine();
