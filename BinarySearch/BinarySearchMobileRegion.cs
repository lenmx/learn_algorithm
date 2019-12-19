using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using CsvHelper;

namespace BinarySearch
{
    public class BinarySearchMobileRegion
    {
        MobileRegionRes mobile;
        MobileRegionRes[] mobiles;
        long _findMobile = 0;
        long findMobile = 0;
        int time = 0;
        double totalMS = 0;

        public BinarySearchMobileRegion()
        {
            string MOBILE_RES_PATH = "/Users/larryhuang/Projects/lear_algorithm/Resources/mobile1810.csv";
            using (var sr = new StreamReader(MOBILE_RES_PATH))
            {
                mobiles = new CsvReader(sr).GetRecords<MobileRegionRes>().ToArray();
            }
        }

        public void Search(string mobile)
        {
            _findMobile = long.Parse(mobile);
            findMobile = long.Parse(mobile.Substring(0, 7));
            Stopwatch st = new Stopwatch();
            st.Start();

            SearchNum(0, mobiles.Length);

            st.Stop();
            totalMS = st.Elapsed.TotalMilliseconds;
        }

        void SearchNum(int startIndex, int endIndex)
        {
            time++;
            int midIndex = (startIndex + endIndex) / 2;
            var temp = mobiles[midIndex];


            if (temp.MobileRegion == findMobile)
            {
                mobile = temp;
                return;
            }
            else if (temp.MobileRegion > findMobile)
                SearchNum(startIndex, midIndex);
            else
                SearchNum(midIndex, endIndex);
        }

        public override string ToString()
            => $@"search type: {nameof(BinarySearchMobileRegion)}, search times: {time}, time spends: {totalMS}ms. mobile: {_findMobile}, province: {mobile.Province}, city: {mobile.City}, card type: {mobile.CardType}";

    }

    public class MobileRegionRes
    {
        public long Id { get; set; }
        public long MobileRegion { get; set; }
        public string Province { get; set; }
        public string City { get; set; }
        public string CardType { get; set; }
        public string AreaZone { get; set; }
        public string ZipCode { get; set; }
    }

}
