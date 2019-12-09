using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace BubbleSort
{
    public class BubbleSort
    {
        int[] nums;
        int time = 0;
        double totalMS = 0;

        public BubbleSort(int numCount, int min, int max)
        {
            nums = new int[numCount];
            for (int i = 0; i < numCount; i++)
                nums[i] = new Random().Next(min, max);
        }

        public void Bubble()
        {
            Stopwatch st = new Stopwatch();
            st.Start();

            int temp = 0;
            for (int i = 0; i < nums.Length - 1; i++)
                for (int j = nums.Length - 1; j > i; j--)
                {
                    time++;
                    if (nums[i] > nums[j])
                    {
                        nums[i] = nums[j];
                        nums[j] = temp;
                    }
                }


            st.Stop();
            totalMS = st.Elapsed.TotalMilliseconds;
        }

        public override string ToString()
            => $@"sort type: {nameof(BubbleSort)}, sort times: {time}, time spends: {totalMS}ms.";
    }
}
