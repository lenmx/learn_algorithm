using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace MergeSort
{
    public class MergeSort
    {
        int[] nums;
        int time = 0;
        double totalMS = 0;

        public MergeSort(int numCount, int min, int max)
        {
            nums = new int[numCount];
            for (int i = 0; i < numCount; i++)
                nums[i] = new Random().Next(min, max);
        }

        public void Merge()
        {
            Stopwatch st = new Stopwatch();
            st.Start();


            int[] temp = new int[nums.Length];
            Sort(nums, 0, nums.Length - 1, temp);


            st.Stop();
            totalMS = st.Elapsed.TotalMilliseconds;
        }

        void Sort(int[] srcNums, int leftIndex, int rightIndex, int[] tempNums)
        {
            if (leftIndex >= rightIndex)
                return;

            time++;

            int midIndex = (leftIndex + rightIndex) / 2;
            Sort(srcNums, leftIndex, midIndex, tempNums);       // 左边归并
            Sort(srcNums, midIndex + 1, rightIndex, tempNums);  // 右边归并

            Merge(srcNums, leftIndex, midIndex, rightIndex, tempNums);
        }

        void Merge(int[] srcNums, int leftIndex, int midIndex, int rightIndex, int[] tempNums)
        {
            int l = leftIndex;
            int r = midIndex + 1;
            int currentIndex = 0;

            while (l <= midIndex && r <= rightIndex)
            {
                time++;

                if (srcNums[l] > srcNums[r])
                    tempNums[currentIndex++] = srcNums[r++];
                else
                    tempNums[currentIndex++] = srcNums[l++];
            }

            while (l <= midIndex)
            {
                time++;
                tempNums[currentIndex++] = srcNums[l++];
            }

            while (r <= rightIndex)
            {
                time++;
                tempNums[currentIndex++] = srcNums[r++];
            }

            currentIndex = 0;
            while (leftIndex <= rightIndex)
                nums[leftIndex++] = tempNums[currentIndex++];
        }

        public override string ToString()
            => $@"sort type: {nameof(MergeSort)}, sort times: {time}, time spends: {totalMS}ms.";
    }
}
