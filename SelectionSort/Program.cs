using BubbleSort;
using System;


namespace SelectionSort
{
    class Program
    {
        static void Main(string[] args)
        {
            const int numCount = 100000;
            const int min = 0, max = 10000;

            var selectionSorter = new SelectionSort(numCount, min, max);
            selectionSorter.Selection();
            Console.WriteLine(selectionSorter.ToString());


            var bubbleSorter = new BubbleSort.BubbleSort(numCount, min, max);
            bubbleSorter.Bubble();
            Console.WriteLine(bubbleSorter.ToString());
        }
    }
}
