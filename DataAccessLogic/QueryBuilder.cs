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

    }
}
