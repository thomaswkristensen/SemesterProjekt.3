using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DataAccessLogic
{
    public interface IQueryBuilder
    {
        string GetPatientInfo(string ssn);

    }
}
