using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DTO;

namespace DataAccessLogic
{
    public interface ICommandBuilder
    {
        SqlCommand PatientInfoCommand(string ssn, Patient_DTO patientDTO, SqlConnection conn);
        SqlCommand HPIinfoCommand(HP_DTO hpDTO);

    }
}
