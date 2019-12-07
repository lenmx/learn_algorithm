using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace learn_algorithm
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            const int numCount = 1000000000;
            int[] nums = new int[numCount];
            for (int i = 0; i < numCount; i++)
                nums[i] = i;

            Stopwatch st = new Stopwatch();
            int num = new Random().Next(0, numCount);
            int index = 0;
            int time = 0;

            st.Start();
            index = FindIndexByDicphoni(nums, num, out time);
            st.Stop();
            Console.WriteLine($"find index by dicphoni, find time {time}, timespan: {st.Elapsed.Milliseconds}ms" );
            

            st = new Stopwatch();
            st.Start();
            time = 0;
            index = FindIndexByFor(nums, num, out time);
            st.Stop();
            Console.WriteLine($"find index by for, find time {time}, timespan: {st.Elapsed.Milliseconds}ms");
            
            Console.ReadLine();
        }
        
        public static int FindIndexByDicphoni(int[] nums, int num, out int time)
        {
            time = 0;
            int min = nums[0], max = nums[nums.Length - 1];
            int mid = (min+max) / 2;

            while (nums[mid] != num) {
                time++;
                if (nums[mid] < num)
                {
                    min = mid;
                    mid = (min + max) / 2;
                }
                else {
                    max = mid;
                    mid = (min + max) / 2;
                }
            }

            return mid;
        }

        public static int FindIndexByFor(int[] nums, int num, out int time)
        {
            time = 0;
            int index = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                time++;
                if (nums[i] == num) {
                    index = i;
                    break;
                }
            }

            return index;
        }

    }
}
