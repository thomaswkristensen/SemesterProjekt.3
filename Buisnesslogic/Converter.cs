using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
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


        public Converter()
        {
            _slope = 1;
            _zpa = 0;
        }
        public void Convert(Measurement_DTO data)
        {
            _data = data;
            foreach (var item in data.RawData)
            {
                _data.ConvertedData.Add((item - _zpa)*_slope);
            }
            _filter.FilterMethod(_data);
        }

        public void SetSlopeAndZPA(FilterContainer filterContainer/*, double slope, double zpa*/)
        {
            _filter = new Filter(filterContainer);
            //_slope = slope;
            //_zpa = zpa;

        }
    }
}
