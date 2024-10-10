using System;

class InsertionSortRecursive
{
    static void InsertionSort(int[] array, int n)
    {
        if (n <= 1)
        {
            return;
        }

        InsertionSort(array, n - 1);

        int last = array[n - 1];
        int j = n - 2;

        while (j >= 0 && array[j] > last)
        {
            array[j + 1] = array[j];
            j--;
        }

        array[j + 1] = last;
    }

    static void PrintArray(int[] array)
    {
        foreach (int element in array)
        {
            Console.Write(element + " ");
        }
        Console.WriteLine();
    }

    static void Main(string[] args)
    {
        int[] array = { 12, 11, 13, 5, 6 };

        Console.WriteLine("Original Array:");
        PrintArray(array);

        InsertionSort(array, array.Length);

        Console.WriteLine("Sorted Array:");
        PrintArray(array);
    }
}
