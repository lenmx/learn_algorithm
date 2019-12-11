using BubbleSort;
using System;

namespace MergeSort
{
    class Program
    {
        static void Main(string[] args)
        {
            const int numCount = 100000;
            const int min = 0, max = 100000;

            var mergeSort = new MergeSort(numCount, min, max);
            mergeSort.Merge();
            Console.WriteLine(mergeSort.ToString());


            var bubbleSorter = new BubbleSort.BubbleSort(numCount, min, max);
            bubbleSorter.Bubble();
            Console.WriteLine(bubbleSorter.ToString());

            var tempnums = new int[numCount];
            for (int i = 0; i < numCount; i++)
                tempnums[i] = new Random().Next(min, max);
        }
    }
}
