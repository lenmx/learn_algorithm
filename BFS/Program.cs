using System;

namespace BFS
{
    class Program
    {
        static void Main(string[] args)
        {
            var breadthFirstSearch = new BreadthFirstSearch();
            breadthFirstSearch.Search("bonnie", "Design");
            Console.WriteLine(breadthFirstSearch.ToString());
            
            Console.ReadLine();
        }
    }
}
