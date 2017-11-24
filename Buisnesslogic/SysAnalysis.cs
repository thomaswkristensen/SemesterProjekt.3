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
        private List<double> _diastoliclist;
        private double _limitSys;
        private double _limitDia;
        private double _sysValue;
        private double _diaValue;
        private double _allsysValues;
        private double _alldiaValues;
        private double _heartRate;
        private double _avg;

        public SysAnalysis()
        {
            _heartRate = 0;
        }

        public double SystolicPreasure(List<double> data)
        {
              _limitSys = data.Max() * 0.8;
            

            if (data.Count > 5000)
            {
                for (int i = 0; i < data.Count; i++)
                {
                    if (data[i] > _limitSys && data[i] > data[i + 1] && data[i] > data[i - 1])
                    {
                        _systoliclist.Add(i*0.001);
                        _allsysValues += data[i];
                    }
                }
                _sysValue = _allsysValues / _systoliclist.Count;
                return _sysValue;
            }

            return _sysValue;
        }

        public double diastolicPressure(List<double> data)
        {
            _limitDia = data.Min() * 1.2;
            if (data.Count > 5000)
            {
                for (int i = 0; i < data.Count; i++)
                {
                    if (data[i] < _limitDia && data[i] < data[i - 1] && data[i] < data[i + 1])
                    {
                        _diastoliclist.Add(i * 0.001);
                        _alldiaValues += data[i];
                    }
                }
                _diaValue = _alldiaValues / _diastoliclist.Count;
            }
            return _diaValue;
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

        public double MAP(List<double> data)
        {
            if (data.Count > 5000)
            {
                _avg = data.Average();
            }

            return _avg; //Hvis 0? Også for ovenstående
        }

        
    }
}
