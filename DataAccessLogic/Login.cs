using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DataAccessLogic
{
    class Login
    {
        private Database _DB;

        public Login()
        {
            
        }
        public HP_DTO verifyLoginInformation(HP_DTO HealthProfessional)
        {
            _DB = new Database();
            return _DB.VerifyLoginInformation(HealthProfessional);
        }

        public bool verifySSN(string)
        {
            return true;
        }

        public bool saveMeasurement()
        {
            return true;
        }
    }
}
