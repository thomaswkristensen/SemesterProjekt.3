using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DataAccessLogic
{
    class DataBaseHandler : IDataBaseHandler
    {
        private SqlConnection _conn;
        private const string _db = "F17ST2ITS2201607091";
        private ICommandBuilder _commandbuilder;
        private Patient_DTO patientDTO;
        public DataBaseHandler()
        {
            _conn = new SqlConnection(@"Data Source=i4dab.ase.au.dk;Initial Catalog=" + _db +
                                         ";Persist Security Info=True;User ID=" + _db + ";Password=" + _db + "");
            _conn.Open();
            _commandbuilder = new CommandBuilder();
            patientDTO = new Patient_DTO();
        }
        public void Connect()
        {
            _conn.Open();
        }

        public void Disconnect()
        {
            _conn.Close();
        }

        public Patient_DTO ExecutePatientInfoQuery(string query)
        {
            using (SqlCommand cmd = _commandbuilder.PatientInfoCommand(query, patientDTO, _conn))
            {
                cmd.ExecuteNonQuery();
            }
            return patientDTO;
        }

        public HP_DTO ExecuteHPInfoQuery(string query)
        {
            throw new NotImplementedException();
        }
    }
}
