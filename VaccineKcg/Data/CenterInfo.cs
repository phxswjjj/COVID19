using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VaccineKcg.Data
{
    class CenterInfo
    {
        public string name;
        public string town;
        public string serviceTime;
        public string address;
        public List<ServicePeriod> servicePeriods;

        public static CenterInfoComparer Comparer => new CenterInfoComparer();

        public class CenterInfoComparer : IComparer<CenterInfo>
        {
            public int Compare(CenterInfo x, CenterInfo y)
            {
                var t = x.town.CompareTo(y.town);
                if (t == 0)
                    t = x.name.CompareTo(y.name);
                return t;
            }
        }
    }
}
