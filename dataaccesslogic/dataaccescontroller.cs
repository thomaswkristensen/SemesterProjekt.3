using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using DTO;
using Interfaces;

namespace DataAccessLogic
{

    public class DataAccesController : IDataAccesLogic
    {
        private LimitValues _limits;
        private PullData _pullData;
        private SaveData _saveData;

        public DataAccesController()
        {
            _limits = new LimitValues();
            _pullData = new PullData();
            _saveData = new SaveData();

        }

        public double ZPAVolt
        {
            get => _limits.ZPAVolt;
            set => _limits.ZPAVolt = value; 
        }

        public Patient_DTO verifySSN(string ssn)
        {
            return _pullData.PullPatientInformation(ssn);
        }

        public bool SaveMeasurementDataAcces(Measurement_DTO measurementDTO, string ssn, string employeeID)
        {
            if (_saveData.SaveMeasurement(measurementDTO, ssn, employeeID))
            {
                return true;
            }
            return false;
        }

        public HP_DTO getLoginDatabase(string username)
        {

            return _pullData.PullHPInformation(username);
        }

        public bool SaveCalibrationDataAcces(Calibration_DTO calibrationData)
        {
            if (_saveData.SaveCalibration(calibrationData))
            {
                return true;
            }
            return false;
        }

        public double PullSlope()
        {
            return _pullData.PullCalibration();
        }





    }
}
