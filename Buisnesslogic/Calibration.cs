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
        private Slope _slope;
        private double _P1;
        private double _P2;
        private double _P3;
        private Calibration_DTO _calibrationDTO;

        public Calibration()
        {
            _slope = new Slope();
            _calibrationDTO = new Calibration_DTO();
        }


        public void Calibrate(List<double>data, int value)
        {
            if (value == 10)
            {
                _P1 = _slope.CalculateP1(data);
            }
            else if (value == 50)
            {
                _P2 = _slope.CalculateP2(data);
            }
            else if (value == 100)
            {
                _P3 = _slope.CalculateP3(data);
            }
        }

        public Calibration_DTO ShowCalibration(double zpa)
        {
            _calibrationDTO.Slope = _slope.CalculateSlope(zpa);

            _calibrationDTO.ZPA = zpa / _calibrationDTO.Slope;
            _calibrationDTO.P1 = _P1 / _calibrationDTO.Slope;
            _calibrationDTO.P2 = _P2 / _calibrationDTO.Slope;
            _calibrationDTO.P3 = _P3 / _calibrationDTO.Slope;

            return _calibrationDTO;
        }

        public Calibration_DTO ChangeCalibration(double slope)
        {
            _calibrationDTO.ZPA = _calibrationDTO.ZPA / _calibrationDTO.Slope * slope;
            _calibrationDTO.P1 = _calibrationDTO.P1 / _calibrationDTO.Slope * slope;
            _calibrationDTO.P2 = _calibrationDTO.P2 / _calibrationDTO.Slope * slope;
            _calibrationDTO.P3 = _calibrationDTO.P3 / _calibrationDTO.Slope * slope;
            _calibrationDTO.Slope = slope;

            return _calibrationDTO;
        }

    }
}
