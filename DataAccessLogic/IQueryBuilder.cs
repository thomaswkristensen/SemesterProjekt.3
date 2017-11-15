using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DTO;

namespace DataAccessLogic
{
    public interface IQueryBuilder
    {
        string PatientInfoQuery(string ssn);
        string HPInfoQuery(string username); 
    }
}
