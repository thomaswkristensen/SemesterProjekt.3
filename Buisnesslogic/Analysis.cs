using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using DTO;
using ObserverPattern;

namespace Buisnesslogic
{
    class Analysis
    {
        
        private List<double> _systoliclist;
        private List<double> _diastoliclist;
        private List<double> _analysisList;
        private double _limitSys;
        private double _limitDia;
        private double _sysValue;
        private double _diaValue;
        private double _allsysValues;
        private double _alldiaValues;
        private double _heartRate;
        private double _avg;
        private HealthValues_DTO _hvDTO;
        private AnalysisContainer _analysisContainer;
        private AContainer _data;
        private AutoResetEvent _waitEvent;

        public Analysis(AnalysisContainer analysisContainer, AContainer container, AutoResetEvent waitEvent)
        {
            _data = container;
            _waitEvent = waitEvent;
            _systoliclist = new List<double>();
            _diastoliclist = new List<double>();
            _heartRate = 0;
            _sysValue = 0;
            _diaValue = 0;
            _avg = 0;
            _analysisContainer = analysisContainer;
        }


        public void Analyse()
        {
            
            while (true)
            {
                _waitEvent.WaitOne();
                _analysisList = _data.data;

                _hvDTO = new HealthValues_DTO();

                _hvDTO.SysBP = SystolicPressure(_analysisList);
                _hvDTO.DiaBP = diastolicPressure(_analysisList);
                _hvDTO.AverageBP = MAP(_analysisList);
                _hvDTO.HeartRate = HeartRate(_analysisList);

                _analysisContainer.SetHealthValues(_hvDTO);
            }
        }
        private double SystolicPressure(List<double> data)
        {
              _limitSys = data.Max() * 0.8;
            

            if (data.Count > 99)
            {
                for (int i = 1; i < data.Count - 1; i++)
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

        private double diastolicPressure(List<double> data)
        {
            _limitDia = data.Min() * 1.2;
            if (data.Count > 99)
            {
                for (int i = 1; i < data.Count - 1; i++)
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

        private double HeartRate(List<double> data)
        {
            if (data.Count > 99)
            {
                double difference = _systoliclist[_systoliclist.Count - 1] - _systoliclist[0];
                _heartRate = (data.Count - 1) / difference * 60;

            }

            return _heartRate/1000;
        }

        private double MAP(List<double> data)
        {
            if (data.Count > 99)
            {
                _avg = data.Average();
            }

            return _avg; //Hvis 0? Også for ovenstående
        }
        
    }
}
