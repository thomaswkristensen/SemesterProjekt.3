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
        private DataBaseHandler _dataBaseHandler;

        public DataAccesController()
        {
            _limits = new LimitValues();
            _dataBaseHandler = new DataBaseHandler();
        }

        public double ZPAVolt
        {
            get => _limits.ZPAVolt;
            set => _limits.ZPAVolt = value; 
        }

        public Patient_DTO verifySSN(string ssn)
        {
            return _dataBaseHandler.ExecutePatientInfoQuery(ssn);
        }

        public HP_DTO getLoginDatabase(string medarbejderID)
        {

            return _dataBaseHandler.ExecuteHPInfoQuery(medarbejderID);
        }
       






    }
}
