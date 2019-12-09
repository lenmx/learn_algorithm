using System;
using System.Diagnostics;

namespace BinarySearch
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            const int numCount = 1000000;
            int time = 0;
            double totalMS = 0;
            MobileRes mobileRes = new MobileRes();

            var searcher = new BinarySearch(numCount);
            var searchMobiler = new BinarySearchMobile();

            totalMS = searcher.FindIndexByBinary(new Random().Next(0, numCount), out time);
            Console.WriteLine($"binary search nums, time: {time}, total ms: {totalMS}");

            totalMS = searcher.FindIndexByFor(new Random().Next(0, numCount), out time);
            Console.WriteLine($"for search nums, time: {time}, total ms: {totalMS}");

            totalMS = searchMobiler.FindIndexByBinary(15802657544, out time, out mobileRes);
            Console.WriteLine($@"binary search mobile, time: {time}, total ms: {totalMS}, mobile info: {mobileRes.Id} {mobileRes.MobileRegion} {mobileRes.Province}{mobileRes.City} {mobileRes.CardType}");

            totalMS = searchMobiler.FindIndexByLinq(15802657544, out time, out mobileRes);
            Console.WriteLine($@"linq search mobile, time: {time}, total ms: {totalMS}, mobile info: {mobileRes.Id} {mobileRes.MobileRegion} {mobileRes.Province}{mobileRes.City} {mobileRes.CardType}");

            Console.ReadKey();
        }

    }
}
