using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DataAccessLogic
{
    class SaveData
    {
        private IDataBaseHandler _dataBaseHandler;

        public SaveData()
        {
            _dataBaseHandler = new DataBaseHandler();
        }

        public bool SaveMeasurement(Measurement_DTO measurementDTO, string ssn, string employeeID)
        {
            return _dataBaseHandler.ExecuteMeasurementSaving(measurementDTO, ssn, employeeID);
        }

        public bool SaveCalibration(Calibration_DTO calibrationData)
        {
            return _dataBaseHandler.ExecuteSaveCalibration(calibrationData);
        }

    }
}
