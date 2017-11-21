using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DataAccessLogic
{
    public interface IDataBaseHandler
    {
        void Connect();
        void Disconnect();
        Patient_DTO ExecutePatientInfoQuery(string query);
        HP_DTO ExecuteHPInfoQuery(string query);
        bool ExecuteMeasurementSaving(Measurement_DTO measurementDto, string ssn, string employeeID);
        bool ExecuteSaveCalibration(Calibration_DTO calibrationData);
        double ExecuteSlopeInfo();
    }
}
