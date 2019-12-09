using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace SelectionSort
{
    public class SelectionSort
    {
        int[] nums;
        int time = 0;
        double totalMS = 0;

        public SelectionSort(int numCount, int min, int max)
        {
            nums = new int[numCount];
            for (int i = 0; i < numCount; i++)
                nums[i] = new Random().Next(min, max);
        }

        public void Selection()
        {
            Stopwatch st = new Stopwatch();
            st.Start();


            int index = 0;
            for (int i = 0; i < nums.Length - 1; i++)
            {
                index = i;
                for (int j = i + 1; j < nums.Length; j++)
                {
                    time++;
                    if (nums[index] > nums[j])
                        index = j;
                }

                if (index != i)
                {
                    int temp = nums[i];
                    nums[i] = nums[index];
                    nums[index] = temp;
                }
            }


            st.Stop();
            totalMS = st.Elapsed.TotalMilliseconds;
        }

        public override string ToString()
            => $@"sort type: {nameof(SelectionSort)}, sort times: {time}, time spends: {totalMS}ms.";

    }
}
