using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DataAccessLogic
{
    class PullData
    {
        private IDataBaseHandler _dataBaseHandler;

        public PullData()
        {
            _dataBaseHandler = new DataBaseHandler();
        }

        public Patient_DTO PullPatientInformation(string ssn)
        {
            return _dataBaseHandler.ExecutePatientInfoQuery(ssn);
        }

        public HP_DTO PullHPInformation(string username)
        {

            return _dataBaseHandler.ExecuteHPInfoQuery(username);
        }

        public double PullCalibration()
        {
            return _dataBaseHandler.ExecuteSlopeInfo();
        }
    }
}
