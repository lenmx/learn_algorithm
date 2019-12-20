using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace QuickSort
{
    public class QuickSort
    {
        public int[] nums;
        int time = 0;
        double totalMS = 0;

        public QuickSort(int numCount, int min, int max)
        {
            nums = new int[numCount];
            for (int i = 0; i < numCount; i++)
                nums[i] = new Random().Next(min, max);
        }

        public void Quick()
        {
            Stopwatch st = new Stopwatch();
            st.Start();

            Sort(0, nums.Length);

            st.Stop();
            totalMS = st.Elapsed.TotalMilliseconds;
        }
        public void Sort(int l, int r)
        {
            if (l < r)
            {
                time++;

                int pIndex = Partition(l, r);
                Sort(l, pIndex - 1);
                Sort(pIndex + 1, r);
            }
        }
        public int Partition(int l, int r)
        {
            int p = l;
            int index = p + 1;

            for (int i = index; i < r; i++)
            {
                time++;

                if (nums[p] > nums[i])
                {
                    Swap(index, i);
                    index++;
                }
            }

            Swap(p, --index);
            return index;
        }

        void Swap(int i, int j)
        {
            int temp = nums[i];
            nums[i] = nums[j];
            nums[j] = temp;
        }

        public override string ToString()
            => $@"sort type: {nameof(QuickSort)}, sort times: {time}, time spends: {totalMS}ms.";
    }
}
