using System;

namespace DFS
{
    class Program
    {
        static void Main(string[] args)
        {
            var deepFirstSearch = new DeepFirstSearch();
            deepFirstSearch.Search("bonnie", "Design");
            Console.WriteLine(deepFirstSearch.ToString());

            Console.ReadLine();
        }
    }
}
