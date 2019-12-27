using System;

namespace DijkstraSearch
{
    class Program
    {
        static void Main(string[] args)
        {
            var djSearch = new DJSearch();
            djSearch.Search();
            Console.WriteLine(djSearch.ToString());

            Console.ReadLine();
        }
    }
}
