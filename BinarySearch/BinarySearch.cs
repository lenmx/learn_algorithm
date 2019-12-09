using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace BinarySearch
{
    public  class BinarySearch
    {
        int[] nums;
        public BinarySearch(int numCount)
        {
            nums = new int[numCount];
            for (int i = 0; i < numCount; i++)
                nums[i] = i;
        }

        public double FindIndexByBinary(int num, out int time)
        {
            Stopwatch st = new Stopwatch();
            st.Start();

            time = 0;
            int min = 0, max = nums.Length - 1;
            int mid = (min + max) / 2;

            while (nums[mid] != num)
            {
                time++;
                if (nums[mid] < num)
                {
                    min = mid;
                    mid = (min + max) / 2;
                }
                else
                {
                    max = mid;
                    mid = (min + max) / 2;
                }
            }

            st.Stop();
            return st.Elapsed.TotalMilliseconds;
        }

        public double FindIndexByFor(int num, out int time)
        {
            Stopwatch st = new Stopwatch();
            st.Start();

            time = 0;
            int index = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                time++;
                if (nums[i] == num)
                {
                    index = i;
                    break;
                }
            }

            st.Stop();
            return st.Elapsed.TotalMilliseconds;
        }

        

    }
}
