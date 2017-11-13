using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace Buisnesslogic
{
    class Calibration
    {
        private double _sum;
        private Calibration_DTO _calibratio_DTO;

        public Calibration()
        {
           _calibratio_DTO = new Calibration_DTO(); 
        }


        public void CalculateP1(List<double> dataList)
        {
            foreach (var sample in dataList)
            {
                _sum =+ sample;
            }

            _calibratio_DTO.P1 = _sum / dataList.Count;
        }

        public void CalculateP2(List<double> dataList)
        {
            foreach (var sample in dataList)
            {
                _sum =+ sample;
            }

            _calibratio_DTO.P2 = _sum / dataList.Count;
        }

        public void CalculateP3(List<double> dataList)
        {
            foreach (var sample in dataList)
            {
                _sum =+ sample;
            }

            _calibratio_DTO.P3 = _sum / dataList.Count;
        }

        public void Calculate()
        {
            
        }


    }
}
