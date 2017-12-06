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

                //Have styr på hvor stor listen skal være de analysere.

                _hvDTO = new HealthValues_DTO();
                var diffenrence= TimeDifferences(_analysisList);
                _hvDTO.SysBP = SystolicPressure(_analysisList, diffenrence);
                _hvDTO.DiaBP = diastolicPressure(_analysisList,diffenrence);
                _hvDTO.AverageBP = MAP(_analysisList);
                _hvDTO.HeartRate = HeartRate(_analysisList);

                _analysisContainer.SetHealthValues(_hvDTO);

            }
        }

        

        public int TimeDifferences(List<double> data)
        {
            List<int> _times = Times(data);

            List<double> differences = new List<double>();

            
            for (int i = 1; i < _times.Count; i++)
            {
                int diff = _times[i] - _times[i - 1];
                differences.Add(diff);
            }
            double averageDifference = differences.Average();

            return Convert.ToInt32(averageDifference);
        }



        public List<int> Times(List<double> values)
        {
            List<int> peaks = new List<int>();
            int count = 0;
            double threshold = values.Max() * 0.8;

            for (int i = 20; i < values.Count - 20; i += 20)
            {
                if (values[i] > threshold && i >= 20)
                {
                    if (values[i] > values[i - 20] && values[i] > values[i + 20])
                    {
                        peaks.Add(i);
                    }
                }
            }

            return peaks;
        }
       



        private double SystolicPressure(List<double> data,int timediff)
        {
            int startIndex = data.Count - timediff;
            var currentSamples = data.Skip(startIndex);

            int systolic = Convert.ToInt32(currentSamples.Max());

            return systolic;
        }

        private double diastolicPressure(List<double> data,int timediff)
        {
            int startIndex = data.Count - timediff;
            var currentSamples = data.Skip(startIndex);

            int diastolic = Convert.ToInt32(currentSamples.Min());

            return diastolic;
        }

        private double HeartRate(List<double> data)
        {
            double pulse = 0;
            int diff = TimeDifferences(data);

            if (diff != 0)
            {
                pulse = 60000 / diff; // 60000 sample divideret med den gennemsnitlige tidsforskel mellem toppunkterne og derefter dividere vi med en faktor 1000, da der er 1000 sample pr. sekund. 
            }

            return pulse;

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
