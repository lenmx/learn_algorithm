using System;

namespace BinarySearch
{
    class Program
    {
        static void Main(string[] args)
        {
            //const int numCount = 1000000;

            //var binarySearch = new BinarySearch(numCount);
            //binarySearch.Search(new Random().Next(0, numCount));
            //Console.WriteLine(binarySearch.ToString());

            var binarySearchMobile = new BinarySearchMobileRegion();
            binarySearchMobile.Search("18373112475");
            Console.WriteLine(binarySearchMobile.ToString());


            Console.ReadLine();

        }
    }
}
