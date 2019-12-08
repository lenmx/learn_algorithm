using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using CsvHelper;

namespace BinarySearch
{
    public class MobileRes
    {
        public long Id { get; set; }
        public long MobileRegion { get; set; }
        public string Province { get; set; }
        public string City { get; set; }
        public string CardType { get; set; }
        public string AreaZone { get; set; }
        public string ZipCode { get; set; }
    }

    public  class BinarySearchMobile
    {
        private const string MOBILE_CSV_PATH = "mobile1810.csv";
        private List<MobileRes> mobiles = new List<MobileRes>();
        
        public BinarySearchMobile()
        {
            this.Init();
        }

        public void Init()
        {

            using (var sr = new StreamReader(MOBILE_CSV_PATH, Encoding.Default))
            {
                var csv = new CsvReader(sr);
                var result = csv.GetRecords<MobileRes>().ToList();
                mobiles = result != null ? result : new List<MobileRes>();
            }
        }

        public long GetMobileRegion(long mobile)
            => long.Parse(mobile.ToString().Substring(0,7));

        public double FindIndexByBinary(long mobile, out int time, out MobileRes mobileRes)
        {
            time = 0;
            long mobileRegion = GetMobileRegion(mobile);

            Stopwatch st = new Stopwatch();
            st.Start();

            int minIndex = 0, maxIndex = mobiles.Count - 1;
            int midIndex = (minIndex + maxIndex) / 2;

            while (mobiles[midIndex].MobileRegion != mobileRegion)
            {
                time++;
                if (mobiles[midIndex].MobileRegion < mobileRegion)
                {
                    minIndex = midIndex;
                    midIndex = (minIndex+ maxIndex) / 2;
                }
                else
                {
                    maxIndex = midIndex;
                    midIndex = (minIndex + maxIndex) / 2;
                }
            }

            mobileRes = null;
            if (mobiles[midIndex].MobileRegion == mobileRegion)
                mobileRes = mobiles[midIndex];
            
            st.Stop();
            return st.Elapsed.TotalMilliseconds;
        }

        public double FindIndexByLinq(long mobile, out int time, out MobileRes mobileRes)
        {
            time = 0;
            long mobileRegion = GetMobileRegion(mobile);

            Stopwatch st = new Stopwatch();
            st.Start();

            mobileRes = mobiles.FirstOrDefault(a => a.MobileRegion == mobileRegion);

            st.Stop();
            return st.Elapsed.TotalMilliseconds;
        }


        

    }
}
