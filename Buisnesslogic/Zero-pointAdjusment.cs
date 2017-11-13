using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace Buisnesslogic
{
    class Zero_pointAdjusment
    {
        private double _sum;

        public Zero_pointAdjusment()
        {
            
        }

        public double CalculateZPA(List<double> dataList)
        {
            
            foreach (var sample in dataList)
            {
                _sum = +sample;
            }

            return _sum / dataList.Count;
        }
    }
}
