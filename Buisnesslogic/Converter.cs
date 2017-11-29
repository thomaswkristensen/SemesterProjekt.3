using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace Buisnesslogic
{
    public class Converter
    {
        private  Measurement_DTO _data;
        private double _slope;
        private double _zpa;


        public Converter()
        {
            
        }
        public Measurement_DTO Convert(Measurement_DTO data)
        {
            _data = data;
            foreach (var item in data.RawData)
            {
                _data.ConvertedData.Add((item - _zpa)*_slope);
            }

            return _data;
        }

        public void SetSlopeAndZPA(double slope, double zpa)
        {
            _slope = slope;
            _zpa = zpa;
        }
    }
}
