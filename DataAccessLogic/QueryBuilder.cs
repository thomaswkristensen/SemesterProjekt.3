using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DataAccessLogic
{
    class QueryBuilder : IQueryBuilder
    {
        public string PatientInfoQuery(string ssn)
        {
            string query = "SELECT * FROM Patientinfo WHERE SSN = '" + ssn + "'";

            return query;
        }

        public string HPInfoQuery(string username)
        {
            string query = "SELECT * FROM Health_professional WHERE EmployeeID = '" + username + "'";

            return query;
        }

        public string SaveDataQuery()
        {
            string query =
                "INSERT INTO measurement(Raw_Value, Converted_Value, EmployeeID, Date, SSN, Samplerate_Hz)"
                + "VALUES(@RawValue, @ConvertedValue, @EmployeeID, @Date, @SSN, @Samplerate)";

            return query;
        }

        public string SaveCalibrationQuery()
        {
            string query =
                "INSERT INTO Calibration(Slope,CalibrationTime)" + "VALUES(@Slope,@CalibrationTime)";
            return query;
        }

        public string CalibrationInfoQuery()
        {
            string query = "SELECT top(1) Slope from Calibration WHERE CalibrationTime <= @dato";
            return query;
        }

    }
}
