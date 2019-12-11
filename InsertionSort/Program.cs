using BubbleSort;
using System;

namespace InsertionSort
{
    class Program
    {
        static void Main(string[] args)
        {
            const int numCount = 10000;
            const int min = 0, max = 10000;

            var insertSorter = new InsertionSort(numCount, min, max);
            insertSorter.Insertion();
            Console.WriteLine(insertSorter.ToString());


            var bubbleSorter = new BubbleSort.BubbleSort(numCount, min, max);
            bubbleSorter.Bubble();
            Console.WriteLine(bubbleSorter.ToString());
        }
    }
}
