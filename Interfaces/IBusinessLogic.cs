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
        void StartZPA();
        bool StartCalibration(int value);
        Calibration_DTO ViewCalibration();
        Calibration_DTO ChangeSlope(double slope);
        bool GetLogin(string MedarbejderID, string Password);
        bool SaveMeasurementBusiness(Measurement_DTO measurementDTO, string ssn, string employeeID);
        void UseDigitalFilterBL();
        bool SaveCalibrationLogic(Calibration_DTO calibrationData);
        void SetAlarmLimitsBusiness(Alarm_DTO alarmDTO);
        void StartMeasuringBL();
        void StopMeasuringBL();
        void StopAlarm();
        void StartAlarm();
        void StopAlarmTone();

    }
}
