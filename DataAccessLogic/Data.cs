using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLogic
{
    public class Data :IData
    {
        private List<double> _data;
        private NI_DAQ _datacollector;

        public Data()
        {
            _data = new List<double>();
            _datacollector = new NI_DAQ();
            _datacollector.deviceName = "Dev3/ai0";

            _datacollector.rangeMaximumVolt = 5;
            _datacollector.samplesPerChannel = 200;
            _datacollector.sampleRateInHz = 1000;

        }

        public List<double> getData()
        {

            _datacollector.getVoltageSeqBlocking();
            _data = _datacollector.currentVoltageSeq;

            return _data;

        }
        
        

    }
}
