using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace Interfaces
{
    public interface IBusinessLogic
    {
        Patient_DTO GetPatientInformation(string SSN);
        void StartZPA(List<double> dataList);
        void StartCalibration(List<double> data, int value);
        Calibration_DTO ViewCalibration();
        Calibration_DTO ChangeSlope(double slope);
        bool GetLogin(string MedarbejderID, string Password);
        bool SaveMeasurementBusiness(Measurement_DTO measurementDTO, string ssn, string employeeID);
        void UseDigitalFilter();
        bool SaveCalibrationLogic(Calibration_DTO calibrationData);
        bool SetAlarmLimitsBusiness(Alarm_DTO alarmDTO);
        void StartMeasuring();
    }
}
