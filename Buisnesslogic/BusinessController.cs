using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using Interfaces;
using DTO;

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
        private Login _login;

        public BusinessController(IDataAccesLogic DAL)
        {
            _DAL = DAL;
            _calibration = new Calibration();
            _ZPA = new Zero_pointAdjusment();
            _calibrationDTO = new Calibration_DTO();

        }

        public void StartZPA(List<double> dataList)
        {
            _DAL.ZPAVolt = _ZPA.CalculateZPA(dataList);
        }

        public void StartCalibration(List<double> data, int value)
        {
            if (value == 10)
            {
               _P1 = _calibration.CalculateP1(data); 
            }
            else if (value == 50)
            {
                _P2 = _calibration.CalculateP2(data);
            }
            else if (value == 100)
            {
                _P3 =_calibration.CalculateP3(data);
            }
        }

        public Calibration_DTO ViewCalibration()
        {
            _calibrationDTO.Slope = _calibration.CalculateSlope(_DAL.ZPAVolt);

            _calibrationDTO.ZPA = _DAL.ZPAVolt * _calibrationDTO.Slope;
            _calibrationDTO.P1 = _P1 * _calibrationDTO.Slope;
            _calibrationDTO.P2 = _P2 * _calibrationDTO.Slope;
            _calibrationDTO.P3 = _P3 * _calibrationDTO.Slope;

            return _calibrationDTO;
        }

        public Calibration_DTO ChangeSlope(double slope)
        {
            _calibrationDTO.ZPA = _calibrationDTO.ZPA / _calibrationDTO.Slope * slope;
            _calibrationDTO.P1 = _calibrationDTO.P1 / _calibrationDTO.Slope * slope;
            _calibrationDTO.P2 = _calibrationDTO.P2 / _calibrationDTO.Slope * slope;
            _calibrationDTO.P3 = _calibrationDTO.P3 / _calibrationDTO.Slope * slope;
            _calibrationDTO.Slope = slope;

            return _calibrationDTO;
        }

        public HP_DTO GetLogin(string MedarbejderID, string Password)
        {
            return  _login.get_Login(MedarbejderID, Password);
        }

        public Patient_DTO getSSN(string SSN)
        {
            Patient_DTO patient;
            patient = _DAL.verifySSN(SSN);
            return patient;
        }

    }
}
