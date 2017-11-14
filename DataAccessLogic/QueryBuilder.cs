using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DataAccessLogic
{
    class CommandBuilder : ICommandBuilder
    {
        public SqlCommand PatientInfoCommand(string ssn, Patient_DTO patientDTO, SqlConnection connection)
        {
            string query = "SELECT * FROM Patientinfo WHERE SSN = @SSN" + "AND First name = @Firstname" +
                           "AND Last name = @Lastname" + "AND Age = @Age";
            var cmd = new SqlCommand(query, connection);

            cmd.Parameters.AddWithValue(@"SSN", ssn);
            cmd.Parameters.AddWithValue(@"Firstname", patientDTO.FirstName);
            cmd.Parameters.AddWithValue(@"Lastname", patientDTO.LastName);
            cmd.Parameters.AddWithValue(@"Age", patientDTO.Age);

            return cmd;
        }

        public SqlCommand HPIinfoCommand(HP_DTO hpDTO)
        {
            throw new NotImplementedException();
        }
    }
}
