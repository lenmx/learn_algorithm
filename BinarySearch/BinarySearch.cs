using System;
using System.Diagnostics;

namespace BinarySearch
{
    public class BinarySearch
    {
        int findNum = 0, resultNum = -1;
        int[] nums;
        int time = 0;
        double totalMS = 0;

        public BinarySearch(int numCount)
        {
            nums = new int[numCount];
            for (int i = 0; i < numCount; i++)
                nums[i] = i;
        }

        public void Search(int num)
        {
            findNum = num;

            Stopwatch st = new Stopwatch();
            st.Start();

            SearchNum(0, nums.Length);

            st.Stop();
            totalMS = st.Elapsed.TotalMilliseconds;
        }

        void SearchNum(int startIndex, int endIndex)
        {
            time++;
            int midIndex = (startIndex + endIndex) / 2;
            resultNum = nums[midIndex];


            if (resultNum == findNum)
                return;
            else if (resultNum > findNum)
                SearchNum(startIndex, midIndex);
            else
                SearchNum(midIndex, endIndex);
        }



        public override string ToString()
            => $@"search type: {nameof(BinarySearch)}, search times: {time}, time spends: {totalMS}ms.";
    }
}
