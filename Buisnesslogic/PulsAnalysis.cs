using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace Buisnesslogic
{
    class PulsAnalysis
    {
        private Converter _converter;
        private double _puls; 

        public PulsAnalysis()
        {
            _converter = new Converter();
        }

        public double AnalyseHR(List<double> list)
        {

            return _puls;
        }
    }
}
