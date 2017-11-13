using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DataAccessLogic
{
    class DataBaseHandler : IDataBaseHandler
    {
        public void OpenConnection()
        {
            throw new NotImplementedException();
        }

        public void CloseConnection()
        {
            throw new NotImplementedException();
        }

        public Patient_DTO ExecutePatientInfoQuery(string query)
        {
            throw new NotImplementedException();
        }

        public HP_DTO ExecuteHPInfoQuery(string query)
        {
            throw new NotImplementedException();
        }
    }
}
