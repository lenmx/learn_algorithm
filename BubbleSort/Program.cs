using System;

namespace BubbleSort
{
    class Program
    {
        static void Main(string[] args)
        {
            const int numCount = 100;
            const int min = 100, max = 500;

            var sorter = new BubbleSort(numCount, min, max);
            sorter.Bubble();
            Console.WriteLine(sorter.ToString());

            Console.ReadKey();
        }

    }
}
