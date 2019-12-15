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


            for (int i = 0; i < nums.Length; i++)
            {
                int index = FindSmallIndex(nums, i);
                if (index != i) {
                    Swap(nums, index, i);
                }
            }


            st.Stop();
            totalMS = st.Elapsed.TotalMilliseconds;
        }

        int FindSmallIndex(int[] arr, int startIndex)
        {
            int index = startIndex;
            int num = arr[startIndex];
            for (int i = startIndex; i < nums.Length; i++)
            {
                time++;

                if (num > arr[i])
                {
                    num = arr[i];
                    index = i;
                }
            }

            return index;
        }

        void Swap(int[] arr, int i, int j)
        {
            int temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }

        public override string ToString()
            => $@"sort type: {nameof(SelectionSort)}, sort times: {time}, time spends: {totalMS}ms.";

    }
}
