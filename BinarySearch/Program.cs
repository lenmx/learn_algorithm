using System;

namespace BinarySearch
{
    class Program
    {
        static void Main(string[] args)
        {
            const int numCount = 1000000;

            var binarySearch = new BinarySearch(numCount);
            binarySearch.Search(new Random().Next(0, numCount));
            Console.WriteLine(binarySearch.ToString());

            Console.ReadLine();

        }
    }
}
