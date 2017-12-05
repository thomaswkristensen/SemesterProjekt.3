using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buisnesslogic
{
    class DigitalFilter : IFilter
    {
        private double total;
        private double sum;
        
        public List<double> Filtering(List<double> list)
        {
            List<double> RawList = new List<double>();
            List<double> FilteredList = new List<double>();

            for (int i = 0; i < list.Count - 1; i += 10)
            {
                total = 0;
                for (int j = 0; j < 9; j++)
                {
                    total += list[i + j];
                }
                total = total / 10;
                RawList.Add(total);
            }

            for (int i = 0; i < RawList.Count-2; i++)
            {
                sum = 0;

                sum = RawList[i] + RawList[i + 1] + RawList[2];

                FilteredList.Add(sum/3);
            }

            return FilteredList;
        }
    }
}
