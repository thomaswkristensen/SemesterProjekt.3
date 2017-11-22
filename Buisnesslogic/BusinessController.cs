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
        private HP_DTO _hpDTO;
        private Login _login;

        public BusinessController(IDataAccesLogic DAL)
        {
            _DAL = DAL;
            _calibration = new Calibration();
            _ZPA = new Zero_pointAdjusment();
            _hpDTO = new HP_DTO();
            _login = new Login();

        }

        public void StartZPA(List<double> dataList)
        {
            _DAL.ZPAVolt = _ZPA.CalculateZPA(dataList);
        }

        public void StartCalibration(List<double> data, int value)
        {
            _calibration.Calibrate(data, value);
        }

        public Calibration_DTO ViewCalibration()
        {
            return _calibration.ShowCalibration(_DAL.ZPAVolt);
        }

        public Calibration_DTO ChangeSlope(double slope)
        {

            return _calibration.ChangeCalibration(slope);
        }

        public bool GetLogin(string employeeID, string password)
        {
            _hpDTO = _DAL.getLoginDatabase(employeeID);

            return _login.get_Login(employeeID, password, _hpDTO);
        }

        public bool SaveMeasurementBusiness(Measurement_DTO measurementDTO, string ssn, string employeeID)
        {
            if (_DAL.SaveMeasurementDataAcces(measurementDTO, ssn, employeeID))
            {
                return true;
            }
            return false;
        }
       

        public Patient_DTO GetPatientInformation(string ssn)
        {
            Patient_DTO patient;

            patient = _DAL.verifySSN(ssn);

            return patient;
        }

        public bool SaveCalibrationLogic(Calibration_DTO calibrationData)
        {
            if (_DAL.SaveCalibrationDataAcces(calibrationData))
            {
                return true;
            }
            return false;

        }

    }
}
