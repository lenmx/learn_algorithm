using System;
using System.Diagnostics;

namespace QuickSort
{
    public class QuickSort
    {
        int[] nums;
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


        void Sort(int l, int r)
        {
            if (l < r) {
                int partitionIndex = Partition(l, r);
                Sort(l, partitionIndex-1);
                Sort(partitionIndex+1, r);
            }
        }

        int Partition(int l, int r)
        {
            int p = l;
            int index = p + 1;

            for (int i = index; i <= r; i++)
            {
                if (nums[p] > nums[i]) {
                    Swap(i, index);
                    index++;
                }
            }


            Swap(p, index - 1);
            return index - 1;
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
