using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using DTO;
using ObserverPattern;

namespace Buisnesslogic
{
    public class Converter
    {
        private  Measurement_DTO _data;
        private double _slope;
        private double _zpa;
        private Filter _filter;
        private Analysis _analysis;
        private Thread _analysisThread;
        private AutoResetEvent _waitEvent;
        private AContainer _container;


        public Converter()
        {
            _waitEvent = new AutoResetEvent(true);
            _data = new Measurement_DTO();
            _data.ConvertedData = new List<double>();
            _container = new AContainer();
            _container.data = new List<double>();
           _waitEvent = new AutoResetEvent(false);
            _slope = 0;
            _zpa = 0;
        }
        public void Convert(Measurement_DTO data)
        {
                foreach (var item in data.RawData)
                {
                    _data.ConvertedData.Add((item - _zpa) * _slope);
                }
                ;
                foreach (var item in _data.ConvertedData)
                {
                    _container.data.Add(item);
                }
                _waitEvent.Set();
                _filter.FilterMethod(_data);
                _data.ConvertedData.Clear();
            
        }

        public void SetSlopeAndZPA(AnalysisContainer analysisContainer, Filter filter,Alarm alarm
, double zpa,double slope)
        {
            _analysis = new Analysis(analysisContainer,_container,_waitEvent,alarm);
            _analysisThread = new Thread(_analysis.Analyse);
            _analysisThread.Start();
            _filter = filter;
            _slope = slope;
            _zpa = zpa;

        }
    }
}
