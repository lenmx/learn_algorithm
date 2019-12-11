using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace InsertionSort
{
    public class InsertionSort
    {
        int[] nums;
        int time = 0;
        double totalMS = 0;

        public InsertionSort(int numCount, int min, int max)
        {
            nums = new int[numCount];
            for (int i = 0; i < numCount; i++)
                nums[i] = new Random().Next(min, max);
        }

        public void Insertion()
        {
            Stopwatch st = new Stopwatch();
            st.Start();

            for (int i = 1; i < nums.Length; i++)
            {
                int currentNum = nums[i];
                for (int j = i-1; j >= 0; j--)
                {
                    time++;
                    if ( nums[j] > currentNum)
                    {
                        nums[j + 1] = nums[j];
                        nums[j] = currentNum;
                    }
                    else break;
                }
            }



            st.Stop();
            totalMS = st.Elapsed.TotalMilliseconds;
        }

        public override string ToString()
            => $@"sort type: {nameof(InsertionSort)}, sort times: {time}, time spends: {totalMS}ms.";
    }
}
