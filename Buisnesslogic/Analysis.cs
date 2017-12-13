using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using DTO;
using ObserverPattern;

namespace Buisnesslogic
{
    public class Analysis
    {
        
        private List<double> _analysisList;
        private int _avg;
        private HealthValues_DTO _hvDTO;
        private AnalysisContainer _analysisContainer;
        private AContainer _data;
        private AutoResetEvent _waitEvent;
        private Alarm _alarm;
        private int _counter;
        private double _olddifference;
        private double averageDifference;

        public Analysis(AnalysisContainer analysisContainer, AContainer container, AutoResetEvent waitEvent,Alarm alarm)
        {
            _alarm = alarm;
            _data = container;
            _waitEvent = waitEvent;
            _analysisList = new List<double>();
            _counter = 5;
            _avg = 0;
            _olddifference = 1000;
            _analysisContainer = analysisContainer;
        }


        public void Analyse()
        {
            
            while (true)
            {
                _waitEvent.WaitOne();
                

                foreach (var item in _data.data)
                {
                    _analysisList.Add(item);
                }

                _data.data.Clear();

                
                if (_analysisList.Count >= 2000)
                {


                    _hvDTO = new HealthValues_DTO();
                    var diffenrence = TimeDifferences(_analysisList);
                    _hvDTO.SysBP = SystolicPressure(_analysisList, diffenrence);
                    _hvDTO.DiaBP = diastolicPressure(_analysisList, diffenrence);
                    _hvDTO.AverageBP = MAP(_analysisList);
                    _hvDTO.HeartRate = HeartRate(_analysisList);
                    

                    if (_counter == 5)
                    {
                        _hvDTO.Alarm = _alarm.Check(_hvDTO);
                        _analysisContainer.SetHealthValues(_hvDTO);
                        _counter = 0;
                    }

                    _counter++;
                    _analysisList.RemoveRange(0,200);
                    
                }


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
            if (differences.Count == 0)
            {
                averageDifference = _olddifference;
            }
            else
            {
                averageDifference = differences.Average();
                _olddifference = averageDifference;
            }

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
       



        private int SystolicPressure(List<double> data,int timediff)
        {
            int startIndex = data.Count - timediff;
            var currentSamples = data.Skip(startIndex);

            int systolic = Convert.ToInt32(currentSamples.Max());

            return systolic;
        }

        private int diastolicPressure(List<double> data,int timediff)
        {
            int startIndex = data.Count - timediff;
            var currentSamples = data.Skip(startIndex);

            int diastolic = Convert.ToInt32(currentSamples.Min());

            return diastolic;
        }

        private int HeartRate(List<double> data)
        {
            int pulse = 0;
            int diff = TimeDifferences(data);

            if (diff != 0)
            {
                pulse = 60000 / diff;   
            }
            
            return pulse;

        }

        private int MAP(List<double> data)
        {
            if (data.Count > 99)
            {
                _avg = Convert.ToInt32(data.Average());
            }

            return _avg; //Hvis 0? Også for ovenstående
        }
        
    }
}
