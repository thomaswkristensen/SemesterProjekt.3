using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buisnesslogic
{
    class Zero_pointAdjusment
    {
        private double sum;

        public Zero_pointAdjusment()
        {
            
        }

        public double Calculate(List<double> dataList)
        {
            

            foreach (var sample in dataList)
            {
                sum = +sample;
            }

            return sum / dataList.Count;
        }
    }
}
