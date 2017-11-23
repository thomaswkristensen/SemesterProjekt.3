using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buisnesslogic
{
    class SysAnalysis
    {
        
        private List<double> _systoliclist;
        private double _limit;
        private double _sysValue;
        private double _allsysValue;
        private double _heartRate;

        public SysAnalysis()
        {
            _heartRate = 0;
        }

        public double SystolicPreasure(List<double> data)
        {
              _limit = data.Max() * 0.8;
            

            if (data.Count > 5000)
            {
                for (int i = 0; i < data.Count; i++)
                {
                    if (data[i] > _limit && data[i] > data[i + 1] && data[i] > data[i - 1])
                    {
                        _systoliclist.Add(i*0.001);
                        _allsysValue += data[i];
                    }
                }
                _sysValue = _allsysValue / _systoliclist.Count;
                return _sysValue;
            }

            return _sysValue;
        }

        public double HeartRate(List<double> data)
        {
            if (data.Count > 5000)
            {
                double difference = _systoliclist[_systoliclist.Count - 1] - _systoliclist[0];
                _heartRate = (data.Count - 1) / difference * 60;

            }

            return _heartRate;
        }
    }
}
