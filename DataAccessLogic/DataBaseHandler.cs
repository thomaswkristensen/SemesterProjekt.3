using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DataAccessLogic
{
    class DataBaseHandler : IDataBaseHandler
    {
        private SqlConnection _conn;
        private const string _db = "F17ST2ITS2201607091";
        private IQueryBuilder _querybuilder;
        private Patient_DTO _patientDTO;
        private SqlCommand cmd;
        private SqlDataReader rdr;
        public DataBaseHandler()
        {
            _conn = new SqlConnection(@"Data Source=i4dab.ase.au.dk;Initial Catalog=" + _db +
                                         ";Persist Security Info=True;User ID=" + _db + ";Password=" + _db + "");
            
            _querybuilder = new QueryBuilder();
        }
        public void Connect()
        {
            _conn.Open();
        }

        public void Disconnect()
        {
            _conn.Close();
        }

        public Patient_DTO ExecutePatientInfoQuery(string ssn)
        {
            cmd = new SqlCommand(_querybuilder.PatientInfoQuery(ssn), _conn);
            Connect();
            rdr = cmd.ExecuteReader();
            Patient_DTO patientDTO = new Patient_DTO();

            if (rdr.Read())
            {
                if (ssn == Convert.ToString(rdr["SSN"]))
                {
                    patientDTO.SSN = ssn;
                    patientDTO.FirstName = Convert.ToString(rdr["First name"]);
                    patientDTO.LastName = Convert.ToString(rdr["Last name"]);
                    patientDTO.Age = Convert.ToInt32(rdr["Age"]);
                }
                else patientDTO = null;
            }

            Disconnect();

            return patientDTO;
        }

        public HP_DTO ExecuteHPInfoQuery(string username)
        {
            cmd = new SqlCommand(_querybuilder.HPInfoQuery(username),_conn);
            Connect();
            rdr = cmd.ExecuteReader();
            HP_DTO hpDTO = new HP_DTO();

            if (rdr.Reader())
            {
                if (username == Convert.ToString(rdr["EmployeeID"]))
                {
                    hpDTO.EmployeeID = username;
                    hpDTO.Password = Convert.ToString(rdr["Password"]);
                }
                else hpDTO = null;
            }
            Disconnect();

            return hpDTO;
        }
    }
}
