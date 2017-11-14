using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using Interfaces;

namespace Buisnesslogic
{
    public class BusinessController : IBusinessLogic
    {
        private IDataAccesLogic _DAL;
        private Zero_pointAdjusment _ZPA;
        private Calibration _calibration;
        private Calibration_DTO _calibrationDTO;
        private double _zpa;
        private double _P1;
        private double _P2;
        private double _P3;

        public BusinessController(IDataAccesLogic DAL)
        {
            _DAL = DAL;
            _calibration = new Calibration();
            _ZPA = new Zero_pointAdjusment();
            _calibrationDTO = new Calibration_DTO();
        }

        public void StartZPA(List<double> dataList)
        {
            _zpa = _ZPA.CalculateZPA(dataList);
            _DAL.ZPA = _DAL.GetCalibration().Slope * _zpa;
        }

        public void StartCalibration(List<double> data, int value)
        {
            if (value == 10)
            {
               _calibration.CalculateP1(data); 
            }
            else if (value == 50)
            {
                _calibration.CalculateP2(data);
            }
            else if (value == 100)
            {
                _calibration.CalculateP3(data);
            }

             _calibration.CalculateSlope(_zpa);
            _DAL.P1= _P1 * _DAL.GetCalibration().Slope;
            _DAL.P2 = _P2 * _DAL.GetCalibration().Slope;
            _DAL.P3 = _P2 * _DAL.GetCalibration().Slope;
        }






    }
}
