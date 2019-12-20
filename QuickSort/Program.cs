using System;

namespace QuickSort
{
    class Program
    {
        static void Main(string[] args)
        {
            const int numCount = 100000;
            const int min = 0, max = 100000;

            var quickSort = new QuickSort(numCount, min, max);
            quickSort.Quick();
            Console.WriteLine(quickSort.ToString());


            //var bubbleSorter = new BubbleSort.BubbleSort(numCount, min, max);
            //bubbleSorter.Bubble();
            //Console.WriteLine(bubbleSorter.ToString());

            Console.ReadLine();
        }
    }
}
